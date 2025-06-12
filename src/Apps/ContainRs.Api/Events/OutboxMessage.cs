namespace ContainRs.Api.Events;

public class OutboxMessage
{
    public Guid Id { get; set; }
    public required string TipoEvento { get; set; }
    public required string InfoEvento { get; set; }
    public required DateTime DataCriacao { get; set; } = DateTime.Now;
}