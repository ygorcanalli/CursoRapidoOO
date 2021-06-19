using System;

namespace Aula02_Metodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public void Imprimir()
        {
            Console.WriteLine("Nome: {0}", this.Nome);
            Console.WriteLine("Preço: {0:0.00}\n", this.Preco);
        }
    }
}