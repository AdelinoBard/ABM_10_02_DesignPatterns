using Criacionais.Factory;
using System;

namespace Criacionais
{
    class ExemploFactoryRunner
    {
        public static void Run(string[] args)
        {
            ExemploFactory.CriadorDeLog logCreator;
            Console.WriteLine("Digite 'simples' para log simples ou qualquer outra coisa para log detalhado:");
            string input = Console.ReadLine() ?? string.Empty;

            if (input.ToLower() == "simples")
            {
                logCreator = new ExemploFactory.CriadorLogSimples();
            }
            else
            {
                logCreator = new ExemploFactory.CriadorLogDetalhado();
            }

            logCreator.LogMessage("Este é um teste de log!");

            Console.ReadKey();
        }
    }
}