]namespace ContainRs.Contracts;

public interface IEventoManager
{
    Task<IEnumerable<Mensagem<T>>> RecuperNaoLidasAsync<T>(string tipoEvento, string tipoLeitor);
    Task MarcarComoLidaAsync(Guid idEvento, string tipoLeitor);
}
