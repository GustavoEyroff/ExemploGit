// Classe base (Pessoa)
public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor com parâmetros
    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
}



