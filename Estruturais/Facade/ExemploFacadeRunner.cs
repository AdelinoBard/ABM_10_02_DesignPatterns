using Estruturais.Facade;

namespace Estruturais
{
    public class ExemploFacadeRunner
    {
        public static void Run(string[] args)
        {
            // Facade
            BibliotecaFacade biblioteca = new BibliotecaFacade();
            biblioteca.EmprestarLivro("João", "1984");

            Console.ReadKey();
        }
    }
}