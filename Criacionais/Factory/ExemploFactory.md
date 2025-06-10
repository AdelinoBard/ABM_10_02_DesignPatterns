# Padrão Factory Method

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/factory-method)

Este código implementa o padrão de projeto **Factory Method** em C#, um padrão criacional que define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar.

## Estrutura Principal:

### 1. Produto

- `ITransporte`: Interface que define o método `Entregar()`

### 2. Produtos Concretos

- `Caminhao`: Implementação concreta de transporte por caminhão
- `Navio`: Implementação concreta de transporte por navio

### 3. Criador (Creator)

- `TransporteCreator`: Classe abstrata que define o método fábrica `CriarTransporte()`
- Possui método `PlanejarEntrega()` que utiliza o produto criado

### 4. Criadores Concretos

- `CaminhaoCreator`: Cria instâncias de `Caminhao`
- `NavioCreator`: Cria instâncias de `Navio`

## Benefícios desta Implementação:

1. **Desacoplamento**: O código cliente depende apenas da interface do produto, não das implementações concretas
2. **Extensibilidade**: Novos tipos de transporte podem ser adicionados sem alterar o código cliente
3. **Responsabilidade Única**: A lógica de criação de objetos fica centralizada nas subclasses criadoras

## Exemplo de Uso:
