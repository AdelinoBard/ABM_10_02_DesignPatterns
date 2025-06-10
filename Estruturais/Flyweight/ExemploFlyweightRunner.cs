using System;
using Estruturais.Flyweight;

namespace Estruturais
{
    public class ExemploFlyweightRunner
    {
        public static void Run(string[] args)
        {
            // Flyweight
            Documento doc = new Documento("Título padrão", "Conteúdo padrão");
            // Adicionando alguns caracteres ao documento
            doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 1);
            doc.AdicionarCaractere('B', "Arial", 12, ConsoleColor.Red, 2);
            doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 3);  // Reutilizando o objeto Flyweight
            Console.ReadKey();
        }
    }
}