using System;

namespace Aula03_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Camisa T-shirt", 59.90);
            produto1.Imprimir();

            Produto produto2 = new ProdutoFisico("Calça Jeans", 89.90, 15.90);
            produto2.Imprimir();

            Produto produto3 = new Licensa("Editor de Imagens", 89.90, "BHG8-HGF76-YGF");
            produto3.Imprimir();
        }
    }
}