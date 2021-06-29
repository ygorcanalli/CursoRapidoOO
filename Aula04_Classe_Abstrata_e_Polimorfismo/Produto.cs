using System;

namespace Aula04_Classe_Abstrata_e_Polimorfismo
{
    public abstract class Produto
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
            Console.WriteLine("Preço: {0:0.00}", this.Preco);
        }

        public abstract double CalculaValorTotal();
    }
}