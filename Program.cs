using Comportamentais.ChainOfResponsability;

namespace ABM_PadroesDeProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n==== PADRÕES CRIACIONAIS ====");
            Criacionais.MainRunner.Run();

            Console.WriteLine("\n==== PADRÕES ESTRUTURAIS ====");
            Estruturais.MainRunner.Run();

            Console.WriteLine("\n==== PADRÕES COMPORTAMENTAIS ====");
            Comportamentais.MainRunner.Run();
        }
    }
}

namespace Criacionais
{
    public static class MainRunner
    {
        public static void Run()
        {
            Console.WriteLine("--- Abstract Factory ---");
            ExemploAbstractFactoryRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Builder ---");
            ExemploBuilderRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Factory ---");
            ExemploFactoryRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Prototype ---");
            ExemploPrototypeRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Singleton ---");
            ExemploSingletonRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("Todos os exemplos dos padrões criacionais foram executados.");
            Console.ReadKey();
        }
    }
}

namespace Estruturais
{
    public static class MainRunner
    {
        public static void Run()
        {
            Console.WriteLine("--- Adapter ---");
            ExemploAdapterRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Bridge ---");
            ExemploBridgeRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Composite ---");
            ExemploCompositeRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Decorator ---");
            ExemploDecoratorRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Facade ---");
            ExemploFacadeRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Flyweight ---");
            ExemploFlyweightRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Proxy ---");
            ExemploProxyRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("Todos os exemplos dos padrões estruturais foram executados.");
            Console.ReadKey();
        }
    }
}

namespace Comportamentais
{
    public static class MainRunner
    {
        public static void Run()
        {
            Console.WriteLine("--- Chain of Responsibility ---");
            ExemploChainOfResponsabilityRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Command ---");
            ExemploCommandRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Iterator ---");
            ExemploIteratorRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Mediator ---");
            ExemploMediatorRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Memento ---");
            // ExemploMementoRunner.Run(); // Implemente se existir
            Console.WriteLine();

            Console.WriteLine("--- Observer ---");
            ExemploObserverRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- State ---");
            ExemploStateRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Strategy ---");
            ExemploStrategyRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Template Method ---");
            ExemploTemplateMethodRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("--- Visitor ---");
            ExemploVisitorRunner.Run(new string[0]);
            Console.WriteLine();

            Console.WriteLine("Todos os exemplos dos padrões comportamentais foram executados.");
            Console.ReadKey();
        }
    }
}
