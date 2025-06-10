using System;

namespace Criacionais
{
    // Classe Singleton
    public class MeubancoDados
    {
        private static MeubancoDados? instancia;
        private static readonly object lockObj = new object();

        // Construtor privado para evitar instanciação externa
        private MeubancoDados()
        {
            Console.WriteLine("Instância do banco de dados criada.");
        }

        public static MeubancoDados ObterInstancia()
        {
            if (instancia == null)
            {
                lock (lockObj)
                {
                    if (instancia == null)
                    {
                        instancia = new MeubancoDados();
                    }
                }
            }

            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectando ao banco de dados...");
        }
    }

    // Classe Runner
    public static class ExemploSingletonRunner
    {
        public static void Run(string[] args)
        {
            var instancia1 = MeubancoDados.ObterInstancia();
            instancia1.Conectar();

            var instancia2 = MeubancoDados.ObterInstancia();
            instancia2.Conectar();

            Console.WriteLine($"As instâncias são iguais? {ReferenceEquals(instancia1, instancia2)}");
        }
    }
}
