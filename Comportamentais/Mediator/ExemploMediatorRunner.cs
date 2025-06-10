using Comportamentais.Mediator;

namespace Comportamentais
{
    public static class ExemploMediatorRunner
    {
        public static void Run(string[] args)
        {
            //Mediator
            ITorreDeControle torre = new TorreDeControleConcreta();

            Aviao aviao1 = new Aviao("Avião 1", torre);
            Aviao aviao2 = new Aviao("Avião 2", torre);
            Aviao aviao3 = new Aviao("Avião 3", torre);

            aviao1.EnviarMensagem("Solicito autorização para decolar.");
            aviao2.EnviarMensagem("Solicito autorização para pousar.");

            Console.ReadKey();
        }
    }
}