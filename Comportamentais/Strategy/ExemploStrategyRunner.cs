using Comportamentais.Strategy;

namespace Comportamentais
{
    public static class ExemploStrategyRunner
    {
        public static void Run(string[] args)
        {
            // Strategy
            var calculador = new CalculadorDeRota(new RotaMaisRapida());
            calculador.CalcularRota("Ponto A", "Ponto B");

            // Mudar a estratégia para Rota Mais Curta
            calculador.DefinirEstrategia(new RotaMaisCurta());
            calculador.CalcularRota("Ponto A", "Ponto B");

            // Mudar a estratégia para Rota Mais Barata
            calculador.DefinirEstrategia(new RotaMaisBarata());
            calculador.CalcularRota("Ponto A", "Ponto B");

            Console.ReadKey();
        }
    }
}