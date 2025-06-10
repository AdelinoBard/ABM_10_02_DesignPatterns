# Padrão State

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/state)

Este código implementa o padrão de projeto **State** (Estado) em C#, que é um padrão comportamental que permite a um objeto alterar seu comportamento quando seu estado interno muda. O objeto parecerá ter mudado sua classe.

## Estrutura Principal:

1. **IEstadoSemaforo (Interface State)**: Define a interface comum para todos os estados concretos.
2. **EstadoVermelho, EstadoVerde, EstadoAmarelo (Concrete States)**: Implementam comportamentos específicos associados a diferentes estados do semáforo.
3. **Semaforo (Context)**: Mantém uma referência para o estado atual e delega as requisições específicas de estado para o objeto estado atual.

## Exemplo de Uso:

No runner.cs, o semáforo é inicializado no estado vermelho (`EstadoVermelho`). A cada chamada de `MudarEstado()`, o semáforo:

1. Começa no vermelho
2. Muda para verde
3. Muda para amarelo
4. Volta para vermelho

## Saídas do runner.cs:

```
Semaforo em Vermelho - Pare
Semaforo em Verde - Siga
Semaforo em Amarelo - Atenção
Semaforo em Vermelho - Pare
```

## Benefícios desta Implementação:

1. **Organização clara**: Cada estado tem sua própria classe com comportamento bem definido.
2. **Extensibilidade**: Fácil adição de novos estados sem modificar o contexto existente.
3. **Eliminação de condicionais**: Substitui grandes blocos if/switch por polimorfismo.
4. **Princípio Open/Closed**: Novos estados podem ser adicionados sem alterar o código existente.

## Possíveis Extensões:

1. Adicionar novos estados como "Piscando" ou "Desligado".
2. Implementar tempos diferentes para cada estado.
3. Adicionar eventos ou callbacks quando o estado muda.
4. Implementar transições condicionais entre estados.
5. Adicionar persistência do estado atual.

Esta implementação segue corretamente o padrão State, encapsulando cada comportamento de estado em classes separadas e permitindo que o objeto Semaforo altere seu comportamento dinamicamente mudando o objeto estado atual. O padrão é particularmente útil para objetos que precisam alterar seu comportamento em tempo de execução dependendo do seu estado.
