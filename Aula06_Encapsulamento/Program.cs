using System;

namespace Aula06_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Assinatura("Serviço de nuvem", 9.90, 12, "HSDA7-SHJ2-NSDT2");
            Produto produto2 = new ProdutoFisico("Calça Jeans", 89.90, 15.90);
            Licensa produto3 = new Licensa("Editor de Imagens", 89.90, "BHG8-HGF76-YGF");

            Console.WriteLine(produto3.Nome);
            
            Relatorio relatorioDeProdutos = new Relatorio("Produtos", "Relatório dos produos da loja");
            
            relatorioDeProdutos.AdicionarItem(produto1);
            relatorioDeProdutos.AdicionarItem(produto2);
            relatorioDeProdutos.AdicionarItem(produto3);
            relatorioDeProdutos.ImprimirRelatorio();

            Cliente cliente1 = new Cliente("Fulano", "fulano@email.com");
            Cliente cliente2 = new Cliente("Siclana", "siclana@email.com");
            Cliente cliente3 = new Cliente("Beltrano", "beltrano@email.com");

            Relatorio relatorioDeClientes = new Relatorio("Cliente", "Relatório de todos os clientes da loja");
            
            relatorioDeClientes.AdicionarItem(cliente1);
            relatorioDeClientes.AdicionarItem(cliente2);
            relatorioDeClientes.AdicionarItem(cliente3);
            relatorioDeClientes.ImprimirRelatorio();

        }
    }
}