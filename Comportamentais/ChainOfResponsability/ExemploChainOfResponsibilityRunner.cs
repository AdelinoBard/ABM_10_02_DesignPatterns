using Comportamentais.ChainOfResponsability;

namespace Comportamentais.ChainOfResponsability
{
    public static class ExemploChainOfResponsabilityRunner
    {
        // Renomear o método Main para evitar conflito com outros pontos de entrada
        public static void Run(string[] args)
        {
            //ChainOfResponsability
            var gerente = new Gerente("Marcos", 10000);
            var gerenteSenior = new Gerente("Mariana", 25000);
            var diretor = new Gerente("Cecília", 100000);

            gerente.ProximoAprovador = gerenteSenior;
            gerenteSenior.ProximoAprovador = diretor;

            // Gerar e processar pedidos de compra
            var p1 = new Compra(1, 4500, "Materiais");
            var p2 = new Compra(2, 17500, "Projeto X");
            var p3 = new Compra(3, 75000, "Projeto Y");

            gerente.ProcessarPedido(p1);
            gerente.ProcessarPedido(p2);
            gerente.ProcessarPedido(p3);

            Console.ReadKey();
        }
    }
}