﻿namespace Criacionais.AbstractFactory
{
    public class ExemploAbstractFactory
    {
        // https://refactoring.guru/pt-br/design-patterns/abstract-factory

        // Interfaces dos produtos abstratos
        public interface IBotao
        {
            void Pintar();
        }

        public interface ICaixaTexto
        {
            void Renderizar();
        }

        // Produtos concretos para tema Claro
        class BotaoClaro : IBotao
        {
            public void Pintar()
            {
                Console.WriteLine("Renderizando um botão no estilo Claro.");
            }
        }

        class CaixaTextoClara : ICaixaTexto
        {
            public void Renderizar()
            {
                Console.WriteLine("Renderizando uma caixa de texto no estilo Claro.");
            }
        }

        // Produtos concretos para tema Escuro
        class BotaoEscuro : IBotao
        {
            public void Pintar()
            {
                Console.WriteLine("Renderizando um botão no estilo Escuro.");
            }
        }

        class CaixaTextoEscura : ICaixaTexto
        {
            public void Renderizar()
            {
                Console.WriteLine("Renderizando uma caixa de texto no estilo Escuro.");
            }
        }

        // Interface da fábrica abstrata
        public interface IFabricaInterfaceGrafica
        {
            IBotao CriarBotao();
            ICaixaTexto CriarCaixaTexto();
        }

        // Fábrica concreta para tema Claro
        public class FabricaTemaClaro : IFabricaInterfaceGrafica
        {
            public IBotao CriarBotao()
            {
                return new BotaoClaro();
            }

            public ICaixaTexto CriarCaixaTexto()
            {
                return new CaixaTextoClara();
            }
        }

        // Fábrica concreta para tema Escuro
        public class FabricaTemaEscuro : IFabricaInterfaceGrafica
        {
            public IBotao CriarBotao()
            {
                return new BotaoEscuro();
            }

            public ICaixaTexto CriarCaixaTexto()
            {
                return new CaixaTextoEscura();
            }
        }

        public class Aplicacao
        {
            private IBotao _botao;
            private ICaixaTexto _caixaTexto;

            public Aplicacao(IFabricaInterfaceGrafica fabrica)
            {
                _botao = fabrica.CriarBotao();
                _caixaTexto = fabrica.CriarCaixaTexto();
            }

            public void Desenhar()
            {
                _botao.Pintar();
                _caixaTexto.Renderizar();
            }
        }

        internal static void Run()
        {
            throw new NotImplementedException();
        }
    }

}
