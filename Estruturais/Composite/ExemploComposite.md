# Padrão Composite

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/composite)

Este código implementa o padrão de projeto **Composite** (Compósito) em C#, que é um padrão estrutural que permite compor objetos em estruturas de árvore e trabalhar com essas estruturas como se fossem objetos individuais.

## Estrutura Principal:

O código apresenta três componentes principais:

1. **IDepartmentComponent**: Interface base que define operações comuns para ambos os elementos simples (folhas) e complexos (compostos).

   - `CalculateTotalSalary()`: Calcula o salário total
   - `GetName()`: Obtém o nome do componente

2. **IDepartmentGroup**: Interface estendida para componentes compostos que podem ter filhos.

   - `Add()`: Adiciona um componente filho
   - `Remove()`: Remove um componente filho

3. **Employee (Folha)**: Implementa IDepartmentComponent, representando os objetos finais que não têm filhos.

   - Armazena nome e salário individual

4. **Department (Composite)**: Implementa IDepartmentGroup, representando os componentes que podem ter filhos.
   - Mantém uma lista de componentes filhos
   - Implementa operações para adicionar/remover filhos
   - Calcula o salário total somando os salários de todos os filhos

## Exemplo de Uso:

No arquivo `ExemploCompositeRunner.cs`, vemos como o padrão é utilizado:

1. Cria-se equipes individuais (Development e QA) com seus funcionários
2. Combina-se essas equipes em um departamento maior (Tech Department)
3. Adiciona-se tanto equipes quanto funcionários individuais ao departamento
4. Calcula-se o salário total de toda a estrutura hierárquica com uma única chamada

## Saídas do runner.cs

A saída esperada do programa seria:

```
Total salary for Tech Department: $360000
```

(Calculado como: Alice 80000 + Bob 90000 + Charlie 70000 + Dave 120000 = 360000)

## Benefícios desta Implementação:

1. **Tratamento uniforme**: Tanto objetos individuais quanto composições são tratados da mesma forma
2. **Hierarquias recursivas**: Permite construir estruturas de objetos complexas de forma simples
3. **Operações simplificadas**: Cálculos como o salário total são feitos recursivamente sem expor a estrutura interna
4. **Extensibilidade**: Fácil adição de novos tipos de componentes

## Possíveis Extensões:

1. Adicionar novos tipos de operações (como listar todos os funcionários)
2. Implementar diferentes tipos de folhas (como funcionários temporários com cálculo diferente)
3. Adicionar hierarquias mais profundas (sub-departamentos)
4. Implementar padrão Visitor para operações mais complexas
5. Adicionar métodos para buscar componentes específicos

Esta implementação segue corretamente o padrão Composite, permitindo tratar objetos individuais e composições de objetos de maneira uniforme. O exemplo demonstra claramente como calcular valores agregados em estruturas hierárquicas complexas com uma interface simples e consistente.
