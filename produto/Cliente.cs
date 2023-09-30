using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produto
{
    public class Cliente : Pessoa
    {
        public int NumeroCliente { get; set; }
        public string CpfCliente { get; set; }

        public Cliente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public Cliente()
        {
        }

        public void ExibirDadosCliente()
        {
            Console.WriteLine($"Número do Cliente: {NumeroCliente}");
            Console.WriteLine($"O CPF do Cliente {Nome} é: {CpfCliente}");
        }
    }
}
