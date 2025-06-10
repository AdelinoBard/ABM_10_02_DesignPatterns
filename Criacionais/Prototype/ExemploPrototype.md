# Padrão Prototype

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/prototype)

Este código implementa o padrão de projeto **Prototype** (Protótipo em pt-br) em C#, que é um padrão criacional que permite a criação de novos objetos através da clonagem de instâncias existentes, em vez de criar novos objetos usando construtores.

## Estrutura Principal:

1. **Interface `ICloneable`**: Define o contrato para clonagem de objetos com o método `Clone()`.
2. **Classe `Documento`**: Implementa `ICloneable` e representa o objeto que será clonado. Contém:
   - Propriedades `Titulo` e `Conteudo`
   - Método `Clone()` que cria uma nova instância com os mesmos valores
   - Método `Print()` para exibir o conteúdo

## Exemplo de Uso:

No `ExemploPrototypeRunner.cs`:

1. Cria-se um documento original (`docOriginal`)
2. Clona-se este documento (`docCopia`)
3. Modifica-se o conteúdo da cópia
4. Exibe-se ambos os documentos para demonstrar que são instâncias independentes

## Saídas do runner.cs

```
Documento Original:
Titulo: Documento Original
Conteudo: Este é o conteúdo original.

Documento Cópia:
Titulo: Documento Original
Conteudo: Este conteúdo foi modificado na cópia.
```

## Benefícios desta Implementação:

1. **Evita repetição de código**: Não precisa reconstruir objetos complexos do zero
2. **Flexibilidade**: Permite criar objetos sem conhecer seus tipos concretos
3. **Performance**: Clonar pode ser mais eficiente que criar novos objetos
4. **Independência**: Cópias são independentes do original

## Possíveis Extensões:

1. Implementar clonagem profunda para objetos com referências complexas
2. Adicionar um registro de protótipos para gerenciar clones comuns
3. Implementar versões diferentes de documentos como subclasses
4. Adicionar métodos para comparação entre clones

Esta implementação segue corretamente o padrão Prototype, demonstrando como criar cópias independentes de objetos existentes sem acoplamento às suas classes concretas. O uso da interface `ICloneable` fornece uma abordagem limpa e extensível para implementar o padrão.
