
using ContainRs.Api.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ContainRs.Api.Events;

public class EventoManager(AppDbContext context) : IEventoManager
{
    private readonly AppDbContext _context = context;

    public async Task MarcarComoLidaAsync(Guid idEvento, string tipoLeitor)
    {
        var outbox = await _context.Outbox.FirstOrDefaultAsync(o => o.Id == idEvento);
        
        if (outbox == null)
            return;

        var inbox = new InboxMessage() 
        { 
            Id = Guid.NewGuid(),
            OutboxMessageId = outbox.Id,
            Evento = outbox,
            TipoLeitor = tipoLeitor,
            DataProcessamento = DateTime.Now
        };

        await  _context.Inbox.AddAsync(inbox);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Mensagem<T>>> RecuperNaoLidasAsync<T>(string tipoEvento, string tipoLeitor)
    {
        var mensagens = await _context.Outbox.FromSqlRaw(
            @"
                SELECT O.* 
                FROM Outbox o
                LEFT JOIN Inbox i ON i.OutboxMessageId = o.Id AND i.TipoLeitor = {0}
                WHERE i.Id IS NULL AND o.TipoEvento = {1}
            ", tipoLeitor, tipoEvento
            ).ToListAsync();

        var saida = mensagens.Select(outbox =>
        {
            var obj = JsonSerializer.Deserialize<T>(outbox.InfoEvento);
            return new Mensagem<T>() { Id = outbox.Id, Corpo = obj! };
        }).ToList();

        return saida;
    }
}
