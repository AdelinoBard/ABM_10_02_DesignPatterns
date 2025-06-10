# Padrão Template Method

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/template-method)

Este código implementa o padrão de projeto **Template Method** (Método Modelo) em C#, que é um padrão comportamental que define o esqueleto de um algoritmo em uma classe base, permitindo que subclasses redefinam certos passos do algoritmo sem alterar sua estrutura.

## Estrutura Principal:

1. **ProcessadorDeDocumento (Classe Abstrata)**:

   - Define o método template `ProcessarDocumento()` que estabelece a sequência de operações
   - Implementa métodos concretos (`AbrirDocumento()`, `SalvarDocumento()`) com comportamento comum
   - Declara métodos abstratos (`LerDados()`, `ProcessarDados()`) que devem ser implementados pelas subclasses

2. **ProcessadorPDF e ProcessadorWord (Classes Concretas)**:
   - Implementam os métodos abstratos com comportamentos específicos para cada tipo de documento
   - Herdam e reutilizam a estrutura definida na classe base

## Exemplo de Uso:

```csharp
ProcessadorDeDocumento processadorPDF = new ProcessadorPDF();
processadorPDF.ProcessarDocumento();

ProcessadorDeDocumento processadorWord = new ProcessadorWord();
processadorWord.ProcessarDocumento();
```

## Saídas do runner.cs

```
Documento aberto.
Lendo dados do PDF.
Processando dados do PDF.
Documento salvo.
Documento aberto.
Lendo dados do Word.
Processando dados do Word.
Documento salvo.
```

## Benefícios desta Implementação:

1. **Reúso de código**: Elimina duplicação colocando o código comum na classe base
2. **Controle da estrutura**: A classe base controla o fluxo do algoritmo
3. **Extensibilidade**: Novos tipos de processadores podem ser adicionados criando novas subclasses
4. **Inversão de controle**: Segue o princípio Hollywood ("Don't call us, we'll call you")

## Possíveis Extensões:

1. Adicionar hooks (métodos opcionais) na classe base para pontos de extensão adicionais
2. Implementar novos processadores para outros formatos (Excel, TXT, etc.)
3. Adicionar tratamento de erros no método template
4. Tornar alguns passos do template configuráveis via parâmetros

Esta implementação segue corretamente o padrão Template Method, encapsulando a estrutura do algoritmo na classe base enquanto permite variações específicas nas subclasses. O padrão é particularmente útil para cenários onde múltiplos algoritmos compartilham a mesma estrutura mas diferem em implementações específicas de alguns passos.
