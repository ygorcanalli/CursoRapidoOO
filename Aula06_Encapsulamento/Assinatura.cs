using System;

namespace Aula06_Encapsulamento
{
    public class Assinatura : Licensa
    {
        private int _duracao;

        public int Duracao
        {
            get
            {
                return this._duracao;
            }
        }
        public Assinatura(string nome, double preco, int duracao, string chave) : base(nome, preco, chave)
        {
            this._duracao = duracao;
        }

        public override double CalculaValorTotal()
        {
            return this.Duracao * this.Preco;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Duração:\t{0}", this.Duracao);
            
        }
    }
}