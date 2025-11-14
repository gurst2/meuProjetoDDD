namespace MeuProjetoDDD.Domain.Entities;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }    
    public int Estoque { get; set; }
    public DateTime DataCriacao { get; set; }

    // Constructor vazio para o EF Core
    protected Produto() { }

    // Constructor com validações (regra de negócio)
    public Produto()
    {
        if (string.IsNullOrEmpty(Nome))
            throw new ArgumentException("Nome não pode estar vazio");

        if (Preco < 0)
            throw new ArgumentException("Preço não pode ser negativo");

        if (Estoque < 0)
            throw new ArgumentException("Estoque não pode ser negativo");

        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        DataCriacao = dataCriacao;
    }

    // Métodos de negócio
    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
            throw new ArgumentException("Preço não pode ser negativo");

        Preco = novoPreco;
    }

    public void DiminuirEstoque(int quantidade)
    {
        if (quantidade > Estoque)
            throw new InvalidOperationException("Estoque insuficiente");

        Estoque -= quantidade;
    }
}

