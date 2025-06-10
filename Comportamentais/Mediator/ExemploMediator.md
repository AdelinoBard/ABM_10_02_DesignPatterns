# Padrão Mediator

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/mediator)

Este código implementa o padrão de projeto **Mediator** (Mediador) em C#, que é um padrão comportamental que permite reduzir acoplamentos entre classes ao criar um objeto que encapsula como um conjunto de objetos interage.

## Estrutura Principal:

1. **ITorreDeControle (IMediator)**: Interface que define as operações de comunicação entre os objetos (aviões).
2. **TorreDeControleConcreta (ConcreteMediator)**: Implementação concreta do mediador que coordena a comunicação entre os aviões.
3. **Aviao (Colleague)**: Classe que representa os objetos que se comunicam através do mediador, sem referências diretas entre si.

## Exemplo de Uso:

```csharp
ITorreDeControle torre = new TorreDeControleConcreta();

Aviao aviao1 = new Aviao("Avião 1", torre);
Aviao aviao2 = new Aviao("Avião 2", torre);
Aviao aviao3 = new Aviao("Avião 3", torre);

aviao1.EnviarMensagem("Solicito autorização para decolar.");
aviao2.EnviarMensagem("Solicito autorização para pousar.");
```

## Saídas do runner.cs

```
Avião 1 enviando mensagem: Solicito autorização para decolar.
Avião 2 recebeu mensagem: Solicito autorização para decolar.
Avião 3 recebeu mensagem: Solicito autorização para decolar.
Avião 2 enviando mensagem: Solicito autorização para pousar.
Avião 1 recebeu mensagem: Solicito autorização para pousar.
Avião 3 recebeu mensagem: Solicito autorização para pousar.
```

## Benefícios desta Implementação:

1. **Redução de acoplamento**: Os aviões não precisam conhecer uns aos outros, apenas o mediador.
2. **Centralização do controle**: Toda a comunicação passa pela TorreDeControle, facilitando a manutenção.
3. **Reutilização**: Os componentes (aviões) podem ser reutilizados mais facilmente em outros contextos.
4. **Flexibilidade**: Novos tipos de comunicação podem ser adicionados sem modificar as classes dos aviões.

## Possíveis Extensões:

1. Adicionar prioridade nas mensagens (emergência, rotina, etc.)
2. Implementar filtros de mensagens na torre de controle
3. Adicionar diferentes tipos de aeronaves com comportamentos específicos
4. Implementar registro de log de todas as comunicações
5. Adicionar suporte para grupos de comunicação (apenas certos aviões recebem certas mensagens)

Esta implementação segue corretamente o padrão Mediator, demonstrando como objetos podem se comunicar indiretamente através de um mediador central, promovendo o baixo acoplamento e facilitando a manutenção do sistema. O exemplo da torre de controle e aviões é um cenário clássico para este padrão, mostrando claramente seus benefícios em sistemas com múltiplos componentes interconectados.
