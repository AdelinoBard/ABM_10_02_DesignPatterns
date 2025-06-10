# Padrão Flyweight

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/flyweight)

Este código implementa o padrão de projeto **Flyweight** (Peso-Mosca) em C#, que é um padrão estrutural que permite compartilhar eficientemente objetos similares para economizar memória. Ele é particularmente útil quando se precisa criar um grande número de objetos que consomem muitos recursos.

## Estrutura Principal:

1. **CaractereFlyweight (Interface)**: Define a interface comum para os objetos flyweight.
2. **Caractere (Concrete Flyweight)**: Implementa a interface e armazena o estado intrínseco (compartilhável).
3. **CaractereFactory (Flyweight Factory)**: Cria e gerencia objetos flyweight, garantindo que sejam compartilhados corretamente.
4. **Documento (Cliente)**: Mantém referências aos flyweights e computa ou armazena o estado extrínseco (único para cada objeto).

## Exemplo de Uso:

No runner.cs, vemos como o padrão é aplicado:

```csharp
Documento doc = new Documento("Título padrão", "Conteúdo padrão");
doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 1);
doc.AdicionarCaractere('B', "Arial", 12, ConsoleColor.Red, 2);
doc.AdicionarCaractere('A', "Arial", 12, ConsoleColor.Red, 3);  // Reutilizando o objeto Flyweight
```

## Saídas do runner.cs

A saída demonstrará que o mesmo objeto 'A' com as mesmas propriedades (Arial, 12, Red) é reutilizado, mostrando o mesmo HashCode para ambas as instâncias, enquanto 'B' terá um HashCode diferente.

## Benefícios desta Implementação:

1. **Economia de Memória**: Objetos idênticos são compartilhados em vez de criados repetidamente.
2. **Performance Melhorada**: Reduz a carga de criação de objetos e o uso de memória.
3. **Organização Clara**: Separação clara entre estado intrínseco (compartilhado) e extrínseco (único).
4. **Flexibilidade**: Facilita a adição de novos caracteres sem aumentar significativamente o uso de recursos.

## Possíveis Extensões:

1. Adicionar suporte para mais propriedades de formatação (negrito, itálico).
2. Implementar um sistema de cache LRU para flyweights pouco usados.
3. Adicionar serialização para salvar/recuperar o estado dos flyweights.
4. Implementar um sistema de prioridade para reutilização de flyweights.

Esta implementação segue corretamente o padrão Flyweight, demonstrando como objetos com estado intrínseco idêntico podem ser compartilhados para otimizar o uso de recursos, enquanto o estado extrínseco (ponto, neste caso) é mantido separadamente pelo cliente.
