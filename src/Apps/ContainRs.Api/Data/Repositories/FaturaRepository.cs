using ContainRs.Financeiro.Faturamento;

namespace ContainRs.Api.Data.Repositories;

internal class FaturaRepository : IRepository<Fatura>
{
    public Task<Fatura> AddAsync(Fatura obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Fatura?> GetFirstAsync<TProperty>(System.Linq.Expressions.Expression<Func<Fatura, bool>> filtro, System.Linq.Expressions.Expression<Func<Fatura, TProperty>> orderBy, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Fatura>> GetWhereAsync(System.Linq.Expressions.Expression<Func<Fatura, bool>>? filtro = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Fatura obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Fatura> UpdateAsync(Fatura obj, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
