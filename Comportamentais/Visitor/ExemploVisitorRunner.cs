using Comportamentais.Visitor;

namespace Comportamentais
{
    public static class ExemploVisitorRunner
    {
        public static void Run(string[] args)
        {
            // Visitor
            List<IEmpregado> empregados = new List<IEmpregado>
            {
                new Engenheiro("Alice", 70000),
                new Gerente("Bob", 90000)
            };

            var visitor = new AumentoSalario();

            foreach (var empregado in empregados)
            {
                empregado.Accept(visitor);
            }
        }
    }
}