# Padrão Visitor

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/visitor)

Este código implementa o padrão de projeto **Visitor** (Visitante) em C#, que é um padrão comportamental que permite separar algoritmos dos objetos nos quais eles operam. O padrão Visitor permite adicionar novas operações a objetos existentes sem modificá-los, seguindo o princípio Open/Closed.

## Estrutura Principal:

1. **IVisitor (Interface do Visitante)**: Define métodos `Visit` para cada tipo de elemento concreto (no caso, `Engenheiro` e `Gerente`).
2. **Concrete Visitors (Visitantes Concretos)**: Implementam as operações reais a serem executadas nos elementos. No exemplo, `AumentoSalario` implementa aumentos salariais diferentes para cada tipo de empregado.
3. **IEmpregado (Interface do Elemento)**: Define o método `Accept` que recebe um visitante.
4. **Concrete Elements (Elementos Concretos)**: `Engenheiro` e `Gerente` implementam `Accept` e permitem que o visitante opere sobre eles.

## Exemplo de Uso:

O runner demonstra como aplicar o padrão:

1. Cria uma lista de empregados (elementos)
2. Instancia um visitante (`AumentoSalario`)
3. Para cada empregado, chama `Accept` passando o visitante, que aplica a operação específica

## Saídas do runner.cs

A saída esperada seria:

```
Novo salário do engenheiro Alice: R$ 77.000,00
Novo salário do gerente Bob: R$ 108.000,00
```

## Benefícios desta Implementação:

1. **Separação de preocupações**: A lógica de aumento salarial está isolada no visitante, não nas classes dos empregados
2. **Extensibilidade**: Pode-se adicionar novas operações criando novos visitantes sem modificar as classes existentes
3. **Cumpre Open/Closed Principle**: Novos comportamentos podem ser adicionados sem alterar código existente
4. **Visibilidade**: Fica claro que operações diferentes são aplicadas a diferentes tipos de empregados

## Possíveis Extensões:

1. Adicionar novos tipos de visitantes como `CalculoFerias` ou `RelatorioDesempenho`
2. Incluir novos tipos de empregados (como `Diretor`) que também aceitam visitantes
3. Implementar visitantes compostos que aplicam múltiplas operações
4. Adicionar lógica condicional nos métodos Visit baseada em propriedades dos elementos

Esta implementação segue corretamente o padrão Visitor, demonstrando como operações podem ser externalizadas de classes de objetos, permitindo maior flexibilidade e manutenibilidade do código. O padrão é particularmente útil quando se precisa realizar várias operações distintas sobre uma estrutura de objetos complexa.
