using Comportamentais.Command;

namespace Comportamentais
{
public static class ExemploCommandRunner
{
    public static void Run(string[] args)
    {
        Pedido pedido = new Pedido();
        Garcom garcom = new Garcom();

        // Adicionando itens ao pedido
        garcom.SetCommand(new AdicionarItemCommand(pedido, "Hambúrguer"));
        garcom.Submit();
        garcom.SetCommand(new AdicionarItemCommand(pedido, "Batatas fritas"));
        garcom.Submit();

        // Finalizando o pedido
        garcom.SetCommand(new FinalizarPedidoCommand(pedido));
        garcom.Submit();

        Console.ReadKey();
    }
}
}