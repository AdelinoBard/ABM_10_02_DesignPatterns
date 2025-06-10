# Padrão Prototype

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/prototype)

Este código implementa o padrão de projeto **Prototype** em C#, um padrão criacional que permite copiar objetos existentes sem depender de suas classes concretas.

## Estrutura Principal:

### 1. Interface Prototype

- `ICloneable`: Interface que define o método `Clone()`

### 2. Protótipos Concretos

- `Circulo`: Implementação concreta que pode ser clonada
- `Retangulo`: Outra implementação concreta que pode ser clonada

### 3. Cliente

- Utiliza o método `Clone()` para criar cópias de objetos sem conhecer suas classes exatas

## Benefícios desta Implementação:

1. **Cópia flexível**: Permite criar cópias de objetos complexos de forma eficiente
2. **Desacoplamento**: O cliente não precisa conhecer a classe concreta do objeto a ser copiado
3. **Facilidade de extensão**: Novos tipos de protótipos podem ser adicionados facilmente

## Exemplo de Uso:
