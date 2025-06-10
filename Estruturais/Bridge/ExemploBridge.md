# Padrão Bridge

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/bridge)

Este código implementa o padrão de projeto **Bridge** (Ponte) em C#, que é um padrão estrutural que permite separar uma abstração de sua implementação, de modo que ambas possam variar independentemente.

## Estrutura Principal:

1. **IMessageSender (Implementador)**: Interface que define a operação de envio de mensagem que todas as implementações concretas devem seguir.
2. **EmailSender e SmsSender (Implementadores Concretos)**: Classes que implementam a interface IMessageSender com comportamentos específicos para email e SMS.
3. **Message (Abstração)**: Classe abstrata que mantém uma referência a um objeto IMessageSender e declara o método abstrato Send.
4. **UserMessage e AdminMessage (Abstrações Refinadas)**: Extensões da abstração Message que implementam comportamentos específicos para diferentes tipos de mensagens.

## Exemplo de Uso:

No arquivo `ExemploBridgeRunner.cs`, vemos como o padrão Bridge é utilizado:

- Criamos instâncias dos implementadores concretos (EmailSender e SmsSender)
- Criamos mensagens específicas (UserMessage e AdminMessage) injetando diferentes implementadores
- Chamamos o método Send que delega a operação para o implementador específico

## Saídas do runner.cs

A execução do código produzirá a seguinte saída:

```
Enviando mensagem do usuário...
Email enviado: Assunto: Bem-vindo, Corpo: Obrigado por se registrar!
Enviando mensagem de administração...
SMS enviado: Assunto: Alerta, Mensagem: Ação necessária!
```

## Benefícios desta Implementação:

1. **Separação de preocupações**: A abstração (tipos de mensagem) está separada da implementação (formas de envio)
2. **Extensibilidade**: Podemos adicionar novos tipos de mensagem ou novos meios de envio sem modificar o código existente
3. **Troca em tempo de execução**: Podemos mudar a implementação (de email para SMS, por exemplo) dinamicamente
4. **Princípio Open/Closed**: O código está aberto para extensão mas fechado para modificação

## Possíveis Extensões:

1. Adicionar novos implementadores como:
   - `PushNotificationSender` para notificações push
   - `WhatsAppSender` para envio via WhatsApp
2. Criar novas abstrações refinadas como:
   - `SystemMessage` para mensagens do sistema
   - `PriorityMessage` para mensagens prioritárias com tratamento especial
3. Adicionar métodos adicionais na interface IMessageSender como:
   - `LogMessage` para registrar os envios
   - `ValidateMessage` para validação pré-envio

Esta implementação segue corretamente o padrão Bridge, demonstrando como separar a abstração (tipos de mensagem) de sua implementação (mecanismos de envio), permitindo que ambas evoluam independentemente e facilitando a manutenção e extensão do código.
