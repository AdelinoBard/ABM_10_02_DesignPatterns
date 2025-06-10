using Criacionais.AbstractFactory;

namespace Criacionais
{
    static class ExemploAbstractFactoryRunner
    {
        public static void Run(string[] args)
        {
            // Abstract Factory
            ExemploAbstractFactory.IFabricaInterfaceGrafica fabrica;
            ExemploAbstractFactory.Aplicacao aplicacao;

            Console.WriteLine("Digite 'claro' para o tema Claro ou 'escuro' para o tema Escuro:");
            string? tema = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(tema))
            {
                Console.WriteLine("Nenhum tema foi fornecido. Usando tema padrao: 'claro'.");
                tema = "claro";
            }

            if (tema == "claro")
            {
                fabrica = new ExemploAbstractFactory.FabricaTemaClaro();
            }
            else
            {
                fabrica = new ExemploAbstractFactory.FabricaTemaEscuro();
            }

            aplicacao = new ExemploAbstractFactory.Aplicacao(fabrica);
            aplicacao.Desenhar();

            Console.ReadKey();
        }
    }
}