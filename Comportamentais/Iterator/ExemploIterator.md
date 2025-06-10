# Padrão Iterator

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/iterator)

Este código implementa o padrão de projeto **Iterator** (Iterador) em C#, que é um padrão comportamental que fornece uma maneira de acessar sequencialmente os elementos de um objeto agregado sem expor sua representação subjacente.

## Estrutura Principal:

1. **IIterator<T>**: Interface que define as operações básicas do iterador (`HasNext()` e `Next()`)
2. **IAggregate<T>**: Interface que declara o método para criar um iterador (`CreateIterator()`)
3. **Biblioteca**: Classe concreta que implementa IAggregate<Livro> e contém a coleção de livros
4. **BibliotecaIterator**: Implementação concreta do IIterator<Livro> que itera sobre a coleção de livros
5. **Livro**: Classe que representa os itens sendo iterados

## Exemplo de Uso:

No arquivo `ExemploIteratorRunner.cs`, vemos como usar o padrão:

1. Cria-se uma instância de `Biblioteca`
2. Adicionam-se livros à biblioteca
3. Obtém-se um iterador através de `CreateIterator()`
4. Percorre-se os elementos usando `HasNext()` e `Next()`

## Saídas do runner.cs

A execução do código produzirá:

```
Livro: 1984, Autor: George Orwell
Livro: A Revolução dos Bichos, Autor: George Orwell
Livro: Cem Anos de Solidão, Autor: Gabriel Garcia Marquez
```

## Benefícios desta Implementação:

1. **Princípio de responsabilidade única**: Separa a lógica de iteração da coleção em si
2. **Princípio aberto/fechado**: Pode-se introduzir novos tipos de iteradores sem mudar a coleção
3. **Flexibilidade**: Permite múltiplas formas de percorrer a mesma coleção
4. **Encapsulamento**: Esconde os detalhes de implementação da coleção

## Possíveis Extensões:

1. Implementar iteradores reversos
2. Adicionar filtros para iterar apenas sobre livros de um autor específico
3. Criar um iterador que salte elementos (p. ex., a cada 2 livros)
4. Implementar operações como `Previous()` ou `Reset()`

Esta implementação segue corretamente o padrão Iterator, fornecendo uma maneira limpa e eficiente de percorrer coleções sem expor sua estrutura interna. O padrão é particularmente útil quando se precisa de diferentes formas de percorrer uma mesma coleção ou quando a estrutura da coleção pode mudar no futuro.
