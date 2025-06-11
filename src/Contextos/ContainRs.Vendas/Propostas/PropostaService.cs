using ContainRs.Contracts;
using ContainRs.Vendas.Locacoes;
using System.Transactions;

namespace ContainRs.Vendas.Propostas;

public class PropostaService(IRepository<Proposta> repoProprosta, IRepository<Locacao> repoLocacaso) : IPropostaService
{
    private readonly IRepository<Proposta> _repoProposta = repoProprosta;
    private readonly IRepository<Locacao> _repoLocacao = repoLocacaso;

    public async Task<Proposta?> AprovarAsync(AprovarProposta comando)
    {
        var proposta = await _repoProposta
                                .GetFirstAsync(
                                p => p.Id == comando.IdProposta && p.SolicitacaoId == comando.IdPedido,
                                p => p.Id);

        if (proposta is null)
            return null;

        if (proposta.Aprovar())
        {
            // criar locação a partir da proposta aceita
            var locacao = new Locacao()
            {
                PropostaId = proposta.Id,
                DataInicio = DateTime.Now,
                DataPrevistaEntrega = proposta.Solicitacao.DataInicioOperacao.AddDays(-proposta.Solicitacao.DisponibilidadePrevia),
                DataTermino = proposta.Solicitacao.DataInicioOperacao.AddDays(proposta.Solicitacao.DuracaoPrevistaLocacao)
            };

            using var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);

            await _repoProposta.UpdateAsync(proposta);
            await _repoLocacao.AddAsync(locacao);

            scope.Complete();
        }

        return proposta;
    }

    public async Task<Proposta?> ComentarAsync(ComentarProposta comando)
    {
        var proposta = await _repoProposta
                                .GetFirstAsync(
                                    p => p.Id == comando.IdProposta && p.SolicitacaoId == comando.IdPedido,
                                    p => p.Id
                                 );
        
        if (proposta is null) 
            return null;

        proposta.AddComentario(new Comentario()
        {
            Id = Guid.NewGuid(),
            Data = DateTime.Now,
            Usuario = comando.Pessoa,
            Texto = comando.Mensagem
        });

        await _repoProposta.UpdateAsync(proposta);

        return proposta;
    }
}