using Estruturais.Adapter;

namespace Estruturais
{
    public class ExemploAdapterRunner
    {
        public static void Run(string[] args)
        {
            // Adapter

            var clienteApiExterna = new ClienteApiExterna
            {
                Nome = "Ada",
                Sobrenome = "Lovelace",
                DataNascimento = new DateTime(1815, 12, 10),
                Cpf = "000.000.000-00"
            };

            var bancoDeDados = new BancoDeDados();

            var cliente = clienteApiExterna.ConverterParaCliente();

            bancoDeDados.SalvarCliente(cliente);

            Console.ReadKey();
        }
    }
}