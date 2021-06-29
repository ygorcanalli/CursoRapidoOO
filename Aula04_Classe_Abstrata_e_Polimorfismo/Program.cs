using System;

namespace Aula04_Classe_Abstrata_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Assinatura("Serviço de nuvem", 9.90, 12, "HSDA7-SHJ2-NSDT2");
            produto1.Imprimir();
            Console.WriteLine("Total: {0:0.00}", produto1.CalculaValorTotal());
            
            Produto produto2 = new ProdutoFisico("Calça Jeans", 89.90, 15.90);
            produto2.Imprimir();
            Console.WriteLine("Total: {0:0.00}", produto2.CalculaValorTotal());

            Produto produto3 = new Licensa("Editor de Imagens", 89.90, "BHG8-HGF76-YGF");
            produto3.Imprimir();
            Console.WriteLine("Total: {0:0.00}", produto3.CalculaValorTotal());
        }
    }
}