using Comportamentais.TemplateMethod;

namespace Comportamentais
{
    public static class ExemploTemplateMethodRunner
    {
        public static void Run(string[] args)
        {
            // Template Method
            ProcessadorDeDocumento processadorPDF = new ProcessadorPDF();
            processadorPDF.ProcessarDocumento();

            ProcessadorDeDocumento processadorWord = new ProcessadorWord();
            processadorWord.ProcessarDocumento();

            Console.ReadKey();
        }
    }
}