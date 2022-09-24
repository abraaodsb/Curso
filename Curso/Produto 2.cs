using System;
using System.Globalization;

namespace Curso
{
    class Produto_2

    { 
           

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto_2()
        {
            Quantidade = 10;
        }
        public Produto_2 (string nome, double preco, int quantidade) : this()
        {
        
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto_2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
            Quantidade = Quantidade; 
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}
