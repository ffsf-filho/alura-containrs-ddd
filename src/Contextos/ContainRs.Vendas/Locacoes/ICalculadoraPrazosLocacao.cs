using ContainRs.Vendas.Propostas;

namespace ContainRs.Vendas.Locacoes;

public interface ICalculadoraPrazosLocacao
{
    DateTime CalculaDataPrevistaParaEntrega(Proposta proposta);
    DateTime CalculaDataPrevistaParaTermino(Proposta proposta);
}