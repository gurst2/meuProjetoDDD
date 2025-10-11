namespace MeuProjetoDDD.Application.DTOs

public class ProdutoDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public DateTime DataCriacao { get; set; }
}