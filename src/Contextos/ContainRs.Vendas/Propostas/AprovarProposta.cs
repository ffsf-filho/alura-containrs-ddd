using ContainRs.Vendas.Locacoes;
using System.Transactions;

namespace ContainRs.Vendas.Propostas;

public class AprovarProposta(Guid idPedido, Guid idProposta)
{
    public Guid IdPedido { get; } = idPedido;
    public Guid IdProposta { get; } = idProposta;
}