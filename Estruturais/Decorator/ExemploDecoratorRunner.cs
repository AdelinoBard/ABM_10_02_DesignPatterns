using Estruturais.Decorator;

namespace Estruturais
{
    public class ExemploDecoratorRunner
    {
        public static void Run(string[] args)
        {
            // Decorator
            Bebida bebida = new Cafe();
            Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

            // Adiciona Leite
            bebida = new Leite(bebida);
            Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

            // Adiciona Chantilly
            bebida = new Chantilly(bebida);
            Console.WriteLine($"{bebida.Descricao}: ${bebida.Custo()}");

            Console.ReadKey();
        }
    }
}