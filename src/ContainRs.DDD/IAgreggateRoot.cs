namespace ContainRs.DDD;

public interface IAgreggateRoot
{
    ICollection<IDomainEvent> Events { get; }
    void RemoverEventos();
}