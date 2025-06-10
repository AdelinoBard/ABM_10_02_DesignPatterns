namespace Comportamentais.Strategy
{
    public interface IRotaStrategy
    {
        void CalcularRota(string pontoA, string pontoB);
    }

    // Concrete strategies
    public class RotaMaisRapida : IRotaStrategy
    {
        public void CalcularRota(string pontoA, string pontoB)
        {
            Console.WriteLine($"Calculando a rota mais rápida entre {pontoA} e {pontoB}");
        }
    }

    public class RotaMaisCurta : IRotaStrategy
    {
        public void CalcularRota(string pontoA, string pontoB)
        {
            Console.WriteLine($"Calculando a rota mais curta entre {pontoA} e {pontoB}");
        }
    }

    public class RotaMaisBarata : IRotaStrategy
    {
        public void CalcularRota(string pontoA, string pontoB)
        {
            Console.WriteLine($"Calculando a rota mais barata entre {pontoA} e {pontoB}");
        }
    }

    // Context
    public class CalculadorDeRota
    {
        private IRotaStrategy _estrategiaDeRota;

        public CalculadorDeRota(IRotaStrategy estrategia)
        {
            _estrategiaDeRota = estrategia;
        }

        public void DefinirEstrategia(IRotaStrategy estrategia)
        {
            _estrategiaDeRota = estrategia;
        }

        public void CalcularRota(string pontoA, string pontoB)
        {
            _estrategiaDeRota.CalcularRota(pontoA, pontoB);
        }
    }
}
