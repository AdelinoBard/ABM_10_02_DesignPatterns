using Comportamentais.State;

namespace Comportamentais
{
    public static class ExemploStateRunner
    {
        public static void Run(string[] args)
        {
            //State
            Semaforo semaforo = new Semaforo(new EstadoVermelho());
            semaforo.MudarEstado();
            semaforo.MudarEstado();
            semaforo.MudarEstado();
            semaforo.MudarEstado();

            Console.ReadKey();
        }
    }
}