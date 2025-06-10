# Padrão Command

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/command)

Este código implementa o padrão de projeto **Command** (Comando) em C#, que é um padrão comportamental que transforma uma solicitação em um objeto independente contendo toda a informação sobre a solicitação. Essa transformação permite parametrizar métodos com diferentes solicitações, atrasar ou enfileirar a execução de uma solicitação e suportar operações reversíveis.

## Estrutura Principal:

1. **ICommand (Interface Command)**: Define a interface para execução de operações.
2. **Pedido (Receiver)**: Classe que contém a lógica de negócio real que será executada pelos comandos.
3. **AdicionarItemCommand e FinalizarPedidoCommand (Concrete Commands)**: Implementações concretas de ICommand que vinculam ações do Receiver (Pedido) a ações específicas.
4. **Garcom (Invoker)**: Solicita a execução do comando sem conhecer detalhes da operação concreta.

## Exemplo de Uso:

O código demonstra um sistema de pedidos de restaurante onde:

1. Um garçom (Invoker) recebe comandos para adicionar itens ou finalizar pedidos
2. Cada comando é encapsulado como um objeto (AdicionarItemCommand ou FinalizarPedidoCommand)
3. O garçom executa os comandos sem conhecer os detalhes da operação

## Saídas do runner.cs

```
Item adicionado: Hambúrguer
Item adicionado: Batatas fritas
Pedido finalizado com os seguintes itens:
- Hambúrguer
- Batatas fritas
```

## Benefícios desta Implementação:

1. **Separação de responsabilidades**: Separa quem invoca a operação (Garcom) de quem a executa (Pedido).
2. **Extensibilidade**: Novos comandos podem ser adicionados sem modificar o código existente.
3. **Parametrização**: Permite que comandos sejam configurados com parâmetros específicos.
4. **Possibilidade de fila/agendamento**: Os comandos podem ser enfileirados ou programados para execução posterior.

## Possíveis Extensões:

1. **Undo/Redo**: Implementar operações reversíveis adicionando um método Undo() na interface ICommand.
2. **Logging**: Registrar histórico de comandos executados para auditoria.
3. **Macro comandos**: Criar comandos compostos que executam vários comandos em sequência.
4. **Comandos assíncronos**: Modificar a interface para suportar operações assíncronas.

Esta implementação segue corretamente o padrão Command, encapsulando cada ação como um objeto independente e permitindo que o invocador (Garcom) trabalhe com comandos de forma genérica, sem conhecer os detalhes de implementação de cada operação específica.
