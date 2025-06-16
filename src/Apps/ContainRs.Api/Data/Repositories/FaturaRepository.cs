using ContainRs.Financeiro.Faturamento;

namespace ContainRs.Api.Data.Repositories;

internal class FaturaRepository(AppDbContext dbContext) : BaseRepository<Fatura>(dbContext)
{
 
}
