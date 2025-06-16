using ContainRs.Api.Domain;

namespace ContainRs.Api.Data.Repositories;

public class ConteinerRepository(AppDbContext dbContext) : BaseRepository<Conteiner>(dbContext)
{
}
