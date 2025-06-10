# Padrão Facade

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/facade)

Este código implementa o padrão de projeto **Facade** (Fachada) em C#, que é um padrão estrutural que fornece uma interface simplificada para um conjunto complexo de subsistemas, tornando mais fácil a interação com o sistema como um todo.

## Estrutura Principal:

O código demonstra três subsistemas principais:

1. `SistemaDeInventario` - Gerencia o estoque de livros e verifica disponibilidade
2. `SistemaDeUsuarios` - Verifica o status dos usuários
3. `SistemaDeEmprestimos` - Registra os empréstimos de livros

A classe `BibliotecaFacade` atua como a fachada que:

- Esconde a complexidade dos subsistemas
- Fornece um método simples `EmprestarLivro()` que coordena todas as operações necessárias
- Gerencia as dependências com os subsistemas

## Exemplo de Uso:

No `ExemploFacadeRunner.cs`, vemos como a fachada simplifica o processo:

```csharp
BibliotecaFacade biblioteca = new BibliotecaFacade();
biblioteca.EmprestarLivro("João", "1984");
```

## Saídas do runner.cs

A execução produzirá:

```
Processando o empréstimo...
Status do usuário 'João' verificado.
O livro '1984' está disponível.
Empréstimo do livro '1984' registrado para o usuário 'João'.
```

## Benefícios desta Implementação:

1. **Simplificação**: Oculta a complexidade dos subsistemas por trás de uma interface simples
2. **Desacoplamento**: O código cliente não precisa conhecer os detalhes dos subsistemas
3. **Organização**: Centraliza a lógica de empréstimo em um único ponto
4. **Facilidade de manutenção**: Mudanças nos subsistemas podem ser isoladas pela fachada

## Possíveis Extensões:

1. Adicionar notificações por email quando um livro for emprestado
2. Implementar sistema de reservas para livros indisponíveis
3. Adicionar verificação de multas por atraso
4. Implementar log mais detalhado das operações

Esta implementação segue corretamente o padrão Facade, proporcionando uma interface limpa e simples para um conjunto de operações complexas relacionadas ao sistema de biblioteca. O padrão é particularmente útil quando se trabalha com bibliotecas complexas ou sistemas com muitas dependências, onde se deseja fornecer uma API mais simples para os clientes.
