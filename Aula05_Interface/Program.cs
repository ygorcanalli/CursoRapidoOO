using System;

namespace Aula05_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Assinatura("Serviço de nuvem", 9.90, 12, "HSDA7-SHJ2-NSDT2");
            Produto produto2 = new ProdutoFisico("Calça Jeans", 89.90, 15.90);
            Produto produto3 = new Licensa("Editor de Imagens", 89.90, "BHG8-HGF76-YGF");

            Relatorio relatorioDeProdutos = new Relatorio("Produtos", "Relatório dos produos da loja");
            
            relatorioDeProdutos.Itens.Add(produto1);
            relatorioDeProdutos.Itens.Add(produto2);
            relatorioDeProdutos.Itens.Add(produto3);
            relatorioDeProdutos.ImprimirRelatorio();

            Cliente cliente1 = new Cliente("Fulano", "fulano@email.com");
            Cliente cliente2 = new Cliente("Siclana", "siclana@email.com");
            Cliente cliente3 = new Cliente("Beltrano", "beltrano@email.com");

            Relatorio relatorioDeClientes = new Relatorio("Cliente", "Relatório de todos os clientes da loja");
            
            relatorioDeClientes.Itens.Add(cliente1);
            relatorioDeClientes.Itens.Add(cliente2);
            relatorioDeClientes.Itens.Add(cliente3);
            relatorioDeClientes.ImprimirRelatorio();

            Relatorio relatorioGeral = new Relatorio("Tudo", "Relatório com tudo da loja");
            
            relatorioGeral.Itens.Add(produto1);
            relatorioGeral.Itens.Add(produto2);
            relatorioGeral.Itens.Add(produto3);
            relatorioGeral.Itens.Add(cliente1);
            relatorioGeral.Itens.Add(cliente2);
            relatorioGeral.Itens.Add(cliente3);
            relatorioGeral.ImprimirRelatorio();

        }
    }
}