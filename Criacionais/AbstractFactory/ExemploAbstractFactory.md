# Padrão Abstract Factory

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/abstract-factory)

Este código implementa o padrão de projeto **Abstract Factory** (Fábrica Abstrata) em C#, que é um padrão criacional que permite produzir famílias de objetos relacionados sem especificar suas classes concretas.

## Estrutura Principal:

### 1. Interfaces de Produtos Abstratos

- `IBotao`: Define o método `Pintar()` para botões
- `ICaixaTexto`: Define o método `Renderizar()` para caixas de texto

### 2. Produtos Concretos

- **Tema Claro**:
  - `BotaoClaro`: Implementação concreta de botão no estilo claro
  - `CaixaTextoClara`: Implementação concreta de caixa de texto no estilo claro
- **Tema Escuro**:
  - `BotaoEscuro`: Implementação concreta de botão no estilo escuro
  - `CaixaTextoEscura`: Implementação concreta de caixa de texto no estilo escuro

### 3. Fábrica Abstrata

- `IFabricaInterfaceGrafica`: Interface que define métodos para criar famílias de objetos relacionados (botões e caixas de texto)

### 4. Fábricas Concretas

- `FabricaTemaClaro`: Cria produtos do tema claro
- `FabricaTemaEscuro`: Cria produtos do tema escuro

### 5. Cliente (`Aplicacao`)

- Recebe uma fábrica concreta no construtor
- Usa a fábrica para criar objetos da família (botão e caixa de texto)
- Possui método `Desenhar()` que utiliza os objetos criados

## Benefícios desta Implementação:

1. **Consistência**: Garante que todos os componentes criados pertencem ao mesmo tema (claro ou escuro)
2. **Flexibilidade**: Facilita a adição de novos temas sem modificar o código cliente
3. **Baixo acoplamento**: O cliente trabalha apenas com interfaces, não com implementações concretas

## Exemplo de Uso:

```csharp
// Criando aplicação com tema claro
var appClaro = new Aplicacao(new FabricaTemaClaro());
appClaro.Desenhar();
// Output:
// Renderizando um botão no estilo Claro.
// Renderizando uma caixa de texto no estilo Claro.

// Criando aplicação com tema escuro
var appEscuro = new Aplicacao(new FabricaTemaEscuro());
appEscuro.Desenhar();
// Output:
// Renderizando um botão no estilo Escuro.
// Renderizando uma caixa de texto no estilo Escuro.
```

## Possíveis Extensões:

1. Adicionar novos tipos de componentes (checkboxes, menus, etc.)
2. Adicionar novos temas (azul, high-contrast, etc.)
3. Implementar métodos mais complexos nos produtos concretos

Esta implementação segue corretamente o padrão Abstract Factory e demonstra bem seu propósito principal: criar famílias de objetos relacionados mantendo a consistência entre eles.
