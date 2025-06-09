namespace ContainRs.Clientes.Cadastro;

public interface IAcessoManager
{
    Task AdicionarClienteAsymc(string email, CancellationToken cancellationToken);
    Task RemoveClienteasync(string email, CancellationToken cancellationToken);
    Task<bool?> ClientePossuiAcessoAsync(string email, CancellationToken cancellationToken);
    Task BloquearClienteAsync(string email, CancellationToken cancellationToken);
}
