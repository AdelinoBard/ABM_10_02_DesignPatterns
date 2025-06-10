# Padrão Factory Method

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/factory-method)

Este código implementa o padrão de projeto **Factory Method** (Método Fábrica em pt-br) em C#, que é um padrão criacional que fornece uma interface para criar objetos em uma superclasse, mas permite que as subclasses alterem o tipo de objetos que serão criados.

## Estrutura Principal:

1. **ILog**: Interface que define a operação comum `EscreverLog()` para todos os logs.
2. **SimpleLog** e **DetailedLog**: Implementações concretas da interface ILog.
3. **CriadorDeLog**: Classe abstrata base que declara o método fábrica `CriarLog()` e implementa a operação `LogMessage()` que usa o produto criado.
4. **CriadorLogSimples** e **CriadorLogDetalhado**: Subclasses concretas que implementam o método fábrica para produzir diferentes tipos de logs.

## Exemplo de Uso:

O código em `ExemploFactoryRunner.cs` demonstra como usar o padrão:

1. Solicita ao usuário que escolha entre log simples ou detalhado
2. Cria o criador de log apropriado com base na entrada
3. Usa o método `LogMessage()` para escrever uma mensagem, sem precisar saber qual tipo concreto de log está sendo criado

## Saídas do runner.cs:

- Se o usuário digitar "simples":

  ```
  SimpleLog: Este é um teste de log!
  ```

- Para qualquer outra entrada:
  ```
  DetailedLog [2023-10-25 14:30:00]: Este é um teste de log!
  ```

## Benefícios desta Implementação:

1. **Baixo acoplamento**: O código cliente (runner) não precisa conhecer as classes concretas de log.
2. **Extensibilidade**: Fácil adição de novos tipos de log sem modificar o código existente.
3. **Princípio de responsabilidade única**: A criação do objeto está separada de seu uso.
4. **Princípio aberto/fechado**: Novos tipos de produtos podem ser introduzidos sem quebrar o código existente.

## Possíveis Extensões:

1. Adicionar novos tipos de log (como FileLog, DatabaseLog) criando novas implementações de ILog e seus criadores correspondentes.
2. Implementar parâmetros adicionais no método fábrica para personalizar a criação dos objetos.
3. Usar um registro de criadores para selecionar dinamicamente o criador com base em configurações.

Esta implementação segue corretamente o padrão Factory Method, encapsulando a criação de objetos e permitindo flexibilidade na escolha de qual classe concreta instanciar, mantendo o código cliente limpo e desacoplado das implementações específicas.
