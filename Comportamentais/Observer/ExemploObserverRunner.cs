using Comportamentais.Observer;

namespace Comportamentais
{
    public static class ExemploObserverRunner
    {
        public static void Run(string[] args)
        {
            // Observer
            var pedidoService = new PedidoService();
            var geradorNF = new GeradorNF();
            var separadorEstoque = new SeparadorEstoque();
            var enviadorBrindes = new EnviadorBrindes();

            pedidoService.AdicionarObserver(geradorNF);
            pedidoService.AdicionarObserver(separadorEstoque);
            pedidoService.AdicionarObserver(enviadorBrindes);

            var meuPedido = new Observer.Pedido(123);
            pedidoService.RealizarPedido(meuPedido);
        }
    }
}
