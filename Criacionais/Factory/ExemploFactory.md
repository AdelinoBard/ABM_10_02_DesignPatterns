# Padr�o Factory Method

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/factory-method)

Este c�digo implementa o padr�o de projeto **Factory Method** em C#, um padr�o criacional que define uma interface para criar um objeto, mas permite que as subclasses decidam qual classe instanciar.

## Estrutura Principal:

### 1. Produto

- `ITransporte`: Interface que define o m�todo `Entregar()`

### 2. Produtos Concretos

- `Caminhao`: Implementa��o concreta de transporte por caminh�o
- `Navio`: Implementa��o concreta de transporte por navio

### 3. Criador (Creator)

- `TransporteCreator`: Classe abstrata que define o m�todo f�brica `CriarTransporte()`
- Possui m�todo `PlanejarEntrega()` que utiliza o produto criado

### 4. Criadores Concretos

- `CaminhaoCreator`: Cria inst�ncias de `Caminhao`
- `NavioCreator`: Cria inst�ncias de `Navio`

## Benef�cios desta Implementa��o:

1. **Desacoplamento**: O c�digo cliente depende apenas da interface do produto, n�o das implementa��es concretas
2. **Extensibilidade**: Novos tipos de transporte podem ser adicionados sem alterar o c�digo cliente
3. **Responsabilidade �nica**: A l�gica de cria��o de objetos fica centralizada nas subclasses criadoras

## Exemplo de Uso:
