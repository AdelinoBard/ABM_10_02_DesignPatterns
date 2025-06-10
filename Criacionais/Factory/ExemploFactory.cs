using System;

namespace Criacionais.Factory
{
    public class ExemploFactory
    {
        internal static void Run()
        {
            throw new NotImplementedException();
        }

        public interface ILog
        {
            void EscreverLog(string mensagem);
        }

        public class SimpleLog : ILog
        {
            public void EscreverLog(string message)
            {
                Console.WriteLine($"SimpleLog: {message}");
            }
        }

        public class DetailedLog : ILog
        {
            public void EscreverLog(string message)
            {
                Console.WriteLine($"DetailedLog [{DateTime.Now}]: {message}");
            }
        }

        public abstract class CriadorDeLog
        {
            public abstract ILog CriarLog();

            public void LogMessage(string mensagem)
            {
                var log = CriarLog();
                log.EscreverLog(mensagem);
            }
        }

        public class CriadorLogSimples : CriadorDeLog
        {
            public override ILog CriarLog()
            {
                return new SimpleLog();
            }
        }

        public class CriadorLogDetalhado : CriadorDeLog
        {
            public override ILog CriarLog()
            {
                return new DetailedLog();
            }
        }
    }
}