using System;

namespace Aula06_Encapsulamento
{
    public class Licensa : Produto
    {
        protected string _chave;

        public string Chave
        {
            get
            {
                return _chave;
            }
        }
        public Licensa(string nome, double preco, string chave) : base(nome, preco)
        {
            this._chave = chave;
        }
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Chave:\t{0}", this.Chave);
        }

        public override double CalculaValorTotal()
        {
            return this.Preco;
        }
    }
}