using Criacionais.Prototype;
using static Criacionais.Prototype.ExemploPrototype;

namespace Criacionais
{
    class ExemploPrototypeRunner
    {
        public static void Run(string[] args)
        {
            Documento docOriginal = new Documento("Documento Original", "Este é o conteúdo original.");

            // Clonando o documento original para criar uma cópia
            Documento? docCopia = docOriginal.Clone() as Documento;

            // Modificando o conteúdo da cópia
            if (docCopia != null)
            {
                docCopia.Conteudo = "Este conteúdo foi modificado na cópia.";
            }

            // Imprimindo ambos os documentos para verificar o resultado da clonagem
            Console.WriteLine("Documento Original:");
            docOriginal.Print();
            Console.WriteLine("\nDocumento Cópia:");
            if (docCopia != null)
            {
                docCopia.Print();
            }
            else
            {
                Console.WriteLine("A cópia do documento é nula.");
            }
            Console.ReadKey();
        }
    }
}