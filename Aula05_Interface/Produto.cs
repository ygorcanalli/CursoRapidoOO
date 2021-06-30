using System;

namespace Aula05_Interface
{
    public abstract class Produto : IImprimivel
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public virtual void Imprimir()
        {
            Console.WriteLine("\nNome: {0}", this.Nome);
            Console.WriteLine("Total: {0:0.00}", this.CalculaValorTotal());
            Console.WriteLine("Preço: {0:0.00}", this.Preco);
        }

        public abstract double CalculaValorTotal();
    }
}