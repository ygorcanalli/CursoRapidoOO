using System;

namespace Aula02_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Camisa T-shirt", 59.90);
            produto1.Imprimir();

            Produto produto2 = new Produto("Calça Jeans", 89.90);
            produto2.Imprimir();
        }
    }
}