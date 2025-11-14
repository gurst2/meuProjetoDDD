using MeuProjetoDDD.Domain.Entities;

namespace MeuProjetoDDD.Domain.Repositories;

public interface IProdutoRepository
{
    Task<Produto> GetByIdAsync(int Id);
    Task<IEnumerable<Produto>> GetAllAssync();
    Task<Produto> AddAsync(Produto produto);
    Task<Produto> UpdateAsync(Produto produto);
    Task<bool> DeleteAsync(int id);
}