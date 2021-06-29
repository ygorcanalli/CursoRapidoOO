using System;

namespace Aula04_Classe_Abstrata_e_Polimorfismo
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

        public override double CalculaValorTotal()
        {
            return this.Preco;
        }
    }
}