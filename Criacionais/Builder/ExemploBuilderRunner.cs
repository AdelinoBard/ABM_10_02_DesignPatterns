using Criacionais.Builder;
using static Criacionais.Builder.ExemploBuilder;

namespace Criacionais
{
    static class ExemploBuilderRunner
    {
        public static void Run(string[] args)
        {
            DiretorInterface diretor = new DiretorInterface();
            InterfaceBuilder builder;

            Console.WriteLine("Digite o tipo de cliente ('padrao', 'vip',  'consultor'):");
            string? tipoCliente = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(tipoCliente))
            {
                Console.WriteLine("Entrada inv�lida. Usando cliente padr�o.");
                tipoCliente = "padrao";
            }

            switch (tipoCliente)
            {
                case "vip":
                    builder = new ClienteVIPBuilder();
                    break;
                case "consultor":
                    builder = new ClienteConsultorBuilder();
                    break;
                default:
                    builder = new ClientePadraoBuilder();
                    break;
            }

            var interfaceUsuario = diretor.MontarInterface(builder);
            interfaceUsuario.MostrarInterface();
            Console.ReadKey();
        }
    }
}