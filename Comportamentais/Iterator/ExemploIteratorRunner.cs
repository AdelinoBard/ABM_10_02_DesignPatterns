using Comportamentais.Iterator;

namespace Comportamentais
{
    public class ExemploIteratorRunner
    {
        // Renomear o método Main para evitar conflito de ponto de entrada
        public static void Run(string[] args)
        {
            // Iterator
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Add(new Livro("1984", "George Orwell"));
            biblioteca.Add(new Livro("A Revolução dos Bichos", "George Orwell"));
            biblioteca.Add(new Livro("Cem Anos de Solidão", "Gabriel Garcia Marquez"));

            IIterator<Livro> iterator = biblioteca.CreateIterator();
            while (iterator.HasNext())
            {
                Livro livro = iterator.Next();
                Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
            }

            Console.ReadKey();
        }
    }
}