namespace ContainRs.Vendas.Propostas;

public interface IPropostaService
{
    Task<Proposta?> AprovarAsync(AprovarProposta comando);
}
