using Comportamentais.Memento;

namespace Comportamentais
{
    public static class ExemploMementoRunner
    {
        public static void Run(string[] args)
        {
            // Memento
            EditorTexto editor = new EditorTexto();
            Caretaker caretaker = new Caretaker(editor);

            editor.Conteudo = "Primeira linha do texto\n";
            caretaker.Salvar();
            editor.Conteudo += "Segunda linha do texto\n";
            caretaker.Salvar();
            editor.Conteudo += "Terceira linha do texto\n";

            Console.WriteLine("Estado Atual:");
            Console.WriteLine(editor.Conteudo);

            caretaker.Desfazer(1); // Desfazendo para o estado após a segunda linha

            Console.WriteLine("Estado após desfazer:");
            Console.WriteLine(editor.Conteudo);
        }
    }
}