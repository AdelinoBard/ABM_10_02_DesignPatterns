namespace Criacionais.Prototype
{
    public class ExemploPrototype

    {
        internal static void Run()
        {
            throw new NotImplementedException();
        }

        public interface ICloneable
        {
            ICloneable Clone();
        }

        // Classe concreta Documento
        public class Documento : ICloneable
        {
            public string Titulo { get; set; }
            public string Conteudo { get; set; }

            public Documento(string titulo, string conteudo)
            {
                Titulo = titulo;
                Conteudo = conteudo;
            }

            // Implementando o método Clone
            public ICloneable Clone()
            {
                return new Documento(Titulo, Conteudo);
            }

            public void Print()
            {
                Console.WriteLine($"Titulo: {Titulo}\nConteudo: {Conteudo}");
            }

            internal void AdicionarCaractere(char v1, string v2, int v3, ConsoleColor red, int v4)
            {
                throw new NotImplementedException();
            }
        }
    }
}