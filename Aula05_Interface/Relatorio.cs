using System;
using System.Collections.Generic;

namespace Aula05_Interface
{
    public class Relatorio
    {
        public string Titulo;
        public string Descricacao;
        public List<IImprimivel> Itens;

        public Relatorio(string titulo, string descricao)
        {
            this.Titulo = titulo;
            this.Descricacao = descricao;
            this.Itens = new List<IImprimivel>();
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