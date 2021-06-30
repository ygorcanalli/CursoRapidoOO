using System;
using System.Collections.Generic;

namespace Aula06_Encapsulamento
{
    public class Relatorio
    {
        private string Titulo;
        private string Descricacao;
        private List<IImprimivel> Itens;

        public Relatorio(string titulo, string descricao)
        {
            this.Titulo = titulo;
            this.Descricacao = descricao;
            this.Itens = new List<IImprimivel>();
        }

        public void AdicionarItem(IImprimivel item)
        {
            this.Itens.Add(item);
        }
        
        public void ImprimirRelatorio()
        {
            Console.WriteLine("===================");
            Console.WriteLine(this.Titulo);
            Console.WriteLine("-------------------");
            Console.WriteLine(this.Descricacao);
            Console.WriteLine("-------------------");
            foreach (var item in Itens)
            {
                item.Imprimir();
                Console.WriteLine("-------------------");
            }
            Console.WriteLine("===================");
        }
        
    }
}