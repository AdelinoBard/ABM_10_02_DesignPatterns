# Padrão Strategy

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/strategy)

Este código implementa o padrão de projeto **Strategy** (Estratégia) em C#, que é um padrão comportamental que permite definir uma família de algoritmos, encapsular cada um deles e torná-los intercambiáveis. O Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam.

## Estrutura Principal:

1. **IRotaStrategy (Interface de Estratégia)**: Define a interface comum para todas as estratégias concretas (`CalcularRota`).
2. **Estratégias Concretas**:
   - `RotaMaisRapida`: Implementa o algoritmo para calcular a rota mais rápida.
   - `RotaMaisCurta`: Implementa o algoritmo para calcular a rota mais curta.
   - `RotaMaisBarata`: Implementa o algoritmo para calcular a rota mais barata.
3. **Contexto (CalculadorDeRota)**:
   - Mantém uma referência para uma estratégia (`IRotaStrategy`).
   - Fornece métodos para definir a estratégia (`DefinirEstrategia`) e executar o cálculo (`CalcularRota`).

## Exemplo de Uso:

No `ExemploStrategyRunner.cs`, o padrão Strategy é utilizado da seguinte forma:

1. Cria-se um `CalculadorDeRota` com a estratégia inicial `RotaMaisRapida`.
2. Calcula-se uma rota, que usa a estratégia definida.
3. Muda-se a estratégia para `RotaMaisCurta` e calcula-se novamente.
4. Muda-se a estratégia para `RotaMaisBarata` e calcula-se mais uma vez.

## Saídas do runner.cs

```
Calculando a rota mais rápida entre Ponto A e Ponto B
Calculando a rota mais curta entre Ponto A e Ponto B
Calculando a rota mais barata entre Ponto A e Ponto B
```

## Benefícios desta Implementação:

1. **Flexibilidade**: Permite trocar algoritmos em tempo de execução simplesmente definindo uma nova estratégia.
2. **Extensibilidade**: Novas estratégias podem ser adicionadas sem modificar o código existente (princípio Open/Closed).
3. **Separação de Responsabilidades**: Isola o código do algoritmo do código do contexto/cliente.
4. **Eliminação de Condicionais**: Substitui estruturas condicionais complexas por polimorfismo.

## Possíveis Extensões:

1. Adicionar novas estratégias como `RotaMaisCenica` ou `RotaComMenosTransito`.
2. Implementar uma fábrica de estratégias para criar instâncias baseadas em parâmetros.
3. Adicionar propriedades adicionais às rotas (como distância, tempo estimado, custo) e retornar um objeto com essas informações.
4. Implementar estratégias compostas que combinam múltiplos critérios (ex: rota rápida e barata).

Esta implementação segue corretamente o padrão Strategy, demonstrando como encapsular diferentes algoritmos em classes separadas e torná-los intercambiáveis. O contexto (`CalculadorDeRota`) delega o trabalho para o objeto estratégia atual, permitindo que o comportamento mude dinamicamente conforme a estratégia é alterada.
