using System;

namespace Aula03_Heranca
{
    public class Licensa : Produto
    {
        public string Chave;

        public Licensa(string nome, double preco, string chave) : base(nome, preco)
        {
            this.Chave = chave;
        }
        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Chave:\t{0}", this.Chave);
        }
    }
}