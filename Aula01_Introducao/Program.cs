using System;

namespace Aula01_Introducao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Nome = "Camisa T-shirt";
            produto1.Preco = 59.90;
            Console.WriteLine("Nome: {0}", produto1.Nome);
            Console.WriteLine("Preço: {0:0.00}\n", produto1.Preco);
            

            Produto produto2 = new Produto();
            produto2.Nome = "Calça Jeans";
            produto2.Preco = 89.90;
            Console.WriteLine("Nome: {0}", produto2.Nome);
            Console.WriteLine("Preço: {0:0.00}\n", produto2.Preco);
        }
    }
}