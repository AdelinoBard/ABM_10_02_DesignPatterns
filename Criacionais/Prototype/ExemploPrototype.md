# Padr�o Prototype

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/prototype)

Este c�digo implementa o padr�o de projeto **Prototype** em C#, um padr�o criacional que permite copiar objetos existentes sem depender de suas classes concretas.

## Estrutura Principal:

### 1. Interface Prototype

- `ICloneable`: Interface que define o m�todo `Clone()`

### 2. Prot�tipos Concretos

- `Circulo`: Implementa��o concreta que pode ser clonada
- `Retangulo`: Outra implementa��o concreta que pode ser clonada

### 3. Cliente

- Utiliza o m�todo `Clone()` para criar c�pias de objetos sem conhecer suas classes exatas

## Benef�cios desta Implementa��o:

1. **C�pia flex�vel**: Permite criar c�pias de objetos complexos de forma eficiente
2. **Desacoplamento**: O cliente n�o precisa conhecer a classe concreta do objeto a ser copiado
3. **Facilidade de extens�o**: Novos tipos de prot�tipos podem ser adicionados facilmente

## Exemplo de Uso:
