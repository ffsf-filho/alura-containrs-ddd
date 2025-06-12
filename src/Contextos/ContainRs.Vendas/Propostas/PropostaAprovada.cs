using ContainRs.DDD;

namespace ContainRs.Vendas.Propostas;

public class PropostaAprovada(Guid idproposta, decimal valorProposta) : IDomainEvent
{
    public Guid IdProposta { get; } = idproposta;
    public decimal ValorProposta { get; } = valorProposta;
}