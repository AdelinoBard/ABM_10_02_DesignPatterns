
namespace Criacionais.Singleton
{
    internal class ExemploSingleton
    {
        internal static void Run()
        {
            throw new NotImplementedException();
        }

        public class MeuBancoDeDados
        {
            private static MeuBancoDeDados? _instancia;
            public static MeuBancoDeDados ObterInstancia()
            {
                if (_instancia == null)
                {
                    _instancia = new MeuBancoDeDados();
                }

                return _instancia;
            }
        }
    }
}