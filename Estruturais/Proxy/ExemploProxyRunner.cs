using Estruturais.Proxy;

namespace Estruturais
{
    public static class ExemploProxyRunner
    {
        public static void Run(string[] args)
        {
            // Proxy
            ProxyDocumento proxy = new ProxyDocumento("Conteúdo Sensível", new PermissaoUsuario());
            proxy.MostrarDocumento("admin");
            proxy.MostrarDocumento("guest");
            Console.ReadKey();
        }
    }
}