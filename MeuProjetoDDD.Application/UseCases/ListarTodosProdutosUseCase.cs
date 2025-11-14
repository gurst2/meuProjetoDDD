using MeuProjetoDDD.Domain.Repositories;
using MeuProjetoDDD.Application.DTOs;

namespace MeuProjetoDDD.Application.UseCases;

public class ListarTodosOsProdutosUseCases
{
    private readonly IProdutoRepository _produtoRepository;

    public ListarTodosProdutosUseCase(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }
    

    public async Task<IEnumerable<ProdutoDTO>> ExecuteAsync()
    {
        var produtos = await _produtoRepository.GetAllAsync();
    }
}