# Padrão Chain of Responsibility

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility)

Este código implementa o padrão de projeto **Chain of Responsibility** (Cadeia de Responsabilidade) em C#, que é um padrão comportamental que permite passar solicitações ao longo de uma cadeia de handlers. Cada handler decide se processa a solicitação ou a passa adiante para o próximo handler na cadeia.

## Estrutura Principal:

1. **IAprovador (Handler Interface)**

   - Define a interface comum para todos os handlers concretos
   - Contém a propriedade `ProximoAprovador` (próximo handler na cadeia)
   - Declara o método `ProcessarPedido` para processar solicitações

2. **Gerente (Concrete Handler)**

   - Implementa a interface IAprovador
   - Possui um limite de aprovação específico
   - Decide se aprova a compra ou passa para o próximo aprovador

3. **Compra (Request)**
   - Representa os dados da solicitação que será processada
   - Contém número, valor e finalidade da compra

## Exemplo de Uso:

No runner.cs vemos como a cadeia é montada e utilizada:

1. Cria-se três aprovadores com limites diferentes:

   - Gerente "Marcos" (até R$10.000)
   - Gerente Sênior "Mariana" (até R$25.000)
   - Diretor "Cecília" (até R$100.000)

2. Estabelece-se a cadeia: gerente → gerente sênior → diretor

3. Três pedidos de compra são criados com valores diferentes e processados pelo primeiro handler da cadeia

## Saídas do runner.cs

A saída esperada seria:

```
Marcos aprovou o pedido nº 1 no valor de R$4.500,00
Mariana aprovou o pedido nº 2 no valor de R$17.500,00
Cecília aprovou o pedido nº 3 no valor de R$75.000,00
```

(Se um pedido excedesse R$100.000, a saída seria: "O pedido nº X no valor de R$Y requer uma reunião executiva!")

## Benefícios desta Implementação:

1. **Desacoplamento**: O remetente de uma solicitação não precisa conhecer qual handler específico irá processá-la.

2. **Flexibilidade**: Pode-se adicionar ou alterar a ordem dos handlers sem modificar o código cliente.

3. **Responsabilidade única**: Cada handler tem uma responsabilidade clara baseada em seu limite de aprovação.

4. **Extensibilidade**: Fácil adição de novos tipos de aprovadores sem modificar a lógica existente.

## Possíveis Extensões:

1. Adicionar novos tipos de aprovadores (como CEO, Comitê Executivo) com limites diferentes.

2. Implementar lógica de aprovação mais complexa (considerar a finalidade da compra, departamento, etc.).

3. Adicionar registro de log para auditoria de todas as aprovações.

4. Implementar rollback ou compensação se algum handler posterior rejeitar a solicitação.

5. Adicionar timeout para aprovações que requerem reunião executiva.

Esta implementação segue corretamente o padrão Chain of Responsibility, demonstrando como delegar solicitações sequencialmente através de uma cadeia de objetos até que um deles possa tratar a solicitação. A abordagem é clara, mantém o princípio de responsabilidade única e permite fácil extensão do fluxo de aprovação.
