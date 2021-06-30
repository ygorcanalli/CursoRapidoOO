using System;

namespace Aula06_Encapsulamento
{
    public abstract class Produto : IImprimivel
    {
        protected string _nome;
        protected double _preco;

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public double Preco
        {
            get
            {
                return _preco;
            }
        }

        public Produto(string nome, double preco)
        {
            this._nome = nome;
            this._preco = preco;
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