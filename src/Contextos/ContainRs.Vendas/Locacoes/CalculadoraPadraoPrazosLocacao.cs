using ContainRs.Vendas.Propostas;

namespace ContainRs.Vendas.Locacoes;

public class CalculadoraPadraoPrazosLocacao : ICalculadoraPrazosLocacao
{
    public DateTime CalculaDataPrevistaParaEntrega(Proposta proposta)
    {
        return proposta.Solicitacao
            .DataInicioOperacao
            .AddDays(-proposta.Solicitacao.DisponibilidadePrevia);
    }

    public DateTime CalculaDataPrevistaParaTermino(Proposta proposta)
    {
        return proposta.Solicitacao
            .DataInicioOperacao
            .AddDays(proposta.Solicitacao.DuracaoPrevistaLocacao);
    }
}