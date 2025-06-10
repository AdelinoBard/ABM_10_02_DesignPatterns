# Padrão Decorator

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/decorator)

Este código implementa o padrão de projeto **Decorator** (Decorador) em C#, que é um padrão estrutural que permite adicionar novos comportamentos a objetos dinamicamente, colocando-os dentro de objetos especiais (decoradores) que contêm esses comportamentos.

## Estrutura Principal:

1. **Componente Abstrato (Bebida)**: Define a interface para objetos que podem ter responsabilidades adicionadas dinamicamente.
2. **Componente Concreto (Café)**: Implementa a interface do componente sem nenhum decorador.
3. **Decorador Abstrato (DecoradorDeCondimento)**: Herda do componente abstrato e mantém uma referência a um objeto componente.
4. **Decoradores Concretos (Leite, Chantilly)**: Adicionam responsabilidades ao componente.

## Exemplo de Uso:

O código demonstra como decorar uma bebida básica (Café) com condimentos adicionais (Leite e Chantilly):

```csharp
Bebida bebida = new Cafe();
bebida = new Leite(bebida);
bebida = new Chantilly(bebida);
```

## Saídas do runner.cs

```
Café: $1.99
Café, Leite: $2.49
Café, Leite, Chantilly: $3.19
```

## Benefícios desta Implementação:

1. **Extensibilidade**: Pode-se adicionar novos condimentos sem modificar o código existente.
2. **Flexibilidade**: Combinações de condimentos podem ser criadas dinamicamente em tempo de execução.
3. **Princípio de Responsabilidade Única**: Cada decorador tem uma única responsabilidade.
4. **Princípio Aberto/Fechado**: O sistema está aberto para extensão mas fechado para modificação.

## Possíveis Extensões:

1. Adicionar novos condimentos (ex: Chocolate, Canela)
2. Implementar tamanhos de bebida (Pequeno, Médio, Grande)
3. Adicionar funcionalidade de descrição detalhada
4. Implementar descontos para combinações específicas

Esta implementação segue corretamente o padrão Decorator, permitindo a composição dinâmica de funcionalidades adicionais a um objeto básico, mantendo uma interface consistente e seguindo os princípios SOLID. O padrão é particularmente útil em cenários onde a herança não é prática devido ao grande número de combinações possíveis.
