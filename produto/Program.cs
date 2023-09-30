using produto;
using System;
using System.Collections.Generic;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Cliente cliente1 = new Cliente();
        cliente1.nome = "gustavo";
        cliente1.Telefone = "47997833368";
        cliente1.
        cliente1.Apresentar();
        cliente1.ExibirDadosCliente();

        Produto produto1 = new Produto(1, "1k de vp no Valorant", "Moeda virtual dentro do jogo Valorant", 30, 100);
        produto1.ExibirProduto();
    }





}

