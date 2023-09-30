public class Produto
{

    public int ID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }


    public Produto(int id, string nome, string descricao, decimal preco, int estoque)
    {
        ID = id;
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
    }

    public void ExibirProduto()
    {
        Console.WriteLine($"ID do Produto: {ID}");
        Console.WriteLine($"Nome do Produto: {Nome}");
        Console.WriteLine($"Descrição do Produto: {Descricao}");
        Console.WriteLine($"Preço do Produto: R$ {Preco}");
        Console.WriteLine($"Qtd em Estoque: {Estoque} unidades");
    }
}
