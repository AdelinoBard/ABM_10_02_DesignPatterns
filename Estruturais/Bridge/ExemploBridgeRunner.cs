using Estruturais.Bridge;

namespace Estruturais
{
    public class ExemploBridgeRunner
    {
        public static void Run(string[] args)
        {
            // Bridge
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SmsSender();

            Message userMessage = new UserMessage(emailSender);
            userMessage.Send("Bem-vindo", "Obrigado por se registrar!");

            Message adminMessage = new AdminMessage(smsSender);
            adminMessage.Send("Alerta", "Ação necessária!");

            Console.ReadKey();
        }
    }
}