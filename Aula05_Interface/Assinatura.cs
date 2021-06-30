﻿using System;

namespace Aula05_Interface
{
    public class Assinatura : Licensa
    {
        public int Duracao;

        public Assinatura(string nome, double preco, int duracao, string chave) : base(nome, preco, chave)
        {
            this.Duracao = duracao;
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