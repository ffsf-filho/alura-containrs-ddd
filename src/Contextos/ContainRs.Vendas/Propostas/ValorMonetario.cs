namespace ContainRs.Vendas.Propostas;

public record ValorMonetario
{
    public ValorMonetario(decimal valor)
    {
        if(valor < 0)
            valor = 0;

        Valor = valor;
    }

    public decimal Valor { get; }
}