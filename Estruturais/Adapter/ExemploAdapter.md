# Padrão Adapter

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/adapter)

Este código implementa o padrão de projeto **Adapter** (Adaptador) em C#, que é um padrão estrutural que permite objetos com interfaces incompatíveis colaborarem entre si.

## Estrutura Principal:

O código demonstra o padrão Adapter através de três componentes principais:

1. **ClienteApiExterna**: Representa a classe com interface incompatível que precisa ser adaptada

   - Propriedades separadas para Nome e Sobrenome
   - CPF como string formatada ("000.000.000-00")

2. **Cliente**: Representa a interface alvo que o sistema espera

   - NomeCompleto como propriedade única
   - CPF como long numérico

3. **ClienteAdapter**: A classe adaptadora que faz a conversão
   - Método de extensão `ConverterParaCliente` que transforma um ClienteApiExterna em Cliente
   - Combina nome e sobrenome
   - Remove formatação do CPF e converte para long

## Exemplo de Uso:

No runner.cs vemos o padrão sendo utilizado:

1. Cria-se um objeto ClienteApiExterna com dados no formato original
2. Usa-se o adaptador (método ConverterParaCliente) para converter para o formato Cliente
3. O objeto convertido é passado para o BancoDeDados que só aceita o tipo Cliente

## Saídas do runner.cs

A saída esperada será:

```
Cliente Ada Lovelace salvo com sucesso!
```

## Benefícios desta Implementação:

1. **Desacoplamento**: O BancoDeDados não precisa conhecer a estrutura da API externa
2. **Reusabilidade**: O adaptador pode ser usado em qualquer lugar que precise da conversão
3. **Mantém SRP**: A responsabilidade de conversão fica isolada no adaptador
4. **Extensibilidade**: Fácil adicionar novos formatos de entrada sem modificar o sistema principal

## Possíveis Extensões:

1. Adicionar tratamento de erros para CPFs inválidos
2. Criar um adaptador inverso (Cliente → ClienteApiExterna)
3. Implementar uma interface IClienteAdapter para diferentes tipos de adaptação
4. Adicionar mapeamento de outros campos que possam existir em versões futuras da API

Esta implementação segue corretamente o padrão Adapter, provendo uma solução elegante para integrar sistemas com interfaces incompatíveis. O uso de um método de extensão em C# é particularmente idiomático, permitindo que o código cliente chame a conversão de forma natural (`clienteApiExterna.ConverterParaCliente()`).
