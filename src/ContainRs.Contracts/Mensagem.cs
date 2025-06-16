namespace ContainRs.Contracts;

public class Mensagem<T>
{
    public Guid Id { get; set; }
    public required T Corpo { get; set; }
}
