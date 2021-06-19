using System;

namespace Aula03_Heranca
{
    public class ProdutoFisico : Produto
    {
        public double Frete;

        public ProdutoFisico(string nome, double preco, double frete) : base(nome, preco)
        {
            this.Frete = frete;
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Frete: {0:0.00}\n", this.Frete);
        }

    }
}