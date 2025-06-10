# Padrão Abstract Factory

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/abstract-factory)

Este código implementa o padrão de projeto **Abstract Factory** (Fábrica Abstrata) em C#, que é um padrão criacional que permite a criação de famílias de objetos relacionados ou dependentes através de uma interface comum, sem especificar suas classes concretas.

## Estrutura Principal:

1. **Produtos Abstratos (Interfaces)**:

   - `IBotao`: Interface para botões
   - `ICaixaTexto`: Interface para caixas de texto

2. **Produtos Concretos**:

   - `BotaoClaro` e `BotaoEscuro`: Implementações concretas de botões
   - `CaixaTextoClara` e `CaixaTextoEscura`: Implementações concretas de caixas de texto

3. **Fábrica Abstrata**:

   - `IFabricaInterfaceGrafica`: Interface que declara métodos para criar famílias de produtos (botões e caixas de texto)

4. **Fábricas Concretas**:

   - `FabricaTemaClaro`: Cria produtos do tema claro
   - `FabricaTemaEscuro`: Cria produtos do tema escuro

5. **Cliente**:
   - `Aplicacao`: Utiliza a fábrica abstrata para criar e usar os produtos sem conhecer suas implementações concretas

## Exemplo de Uso:

O código runner demonstra como usar o padrão:

1. Solicita ao usuário que escolha um tema (claro ou escuro)
2. Cria a fábrica concreta apropriada baseada na escolha
3. Instancia a aplicação com a fábrica selecionada
4. Chama o método `Desenhar()` que usa os produtos criados

## Saídas do runner.cs

Exemplo de saída para tema "claro":

```
Renderizando um botão no estilo Claro.
Renderizando uma caixa de texto no estilo Claro.
```

Exemplo de saída para tema "escuro":

```
Renderizando um botão no estilo Escuro.
Renderizando uma caixa de texto no estilo Escuro.
```

## Benefícios desta Implementação:

1. **Princípio de responsabilidade única**: Separa a criação de produtos do seu uso
2. **Princípio aberto/fechado**: Facilita a extensão para novos temas sem modificar código existente
3. **Consistência**: Garante que todos os produtos criados sejam do mesmo tema
4. **Baixo acoplamento**: O código cliente trabalha apenas com interfaces abstratas

## Possíveis Extensões:

1. Adicionar novos tipos de componentes (checkboxes, menus, etc.)
2. Implementar novos temas (azul, high-contrast, etc.)
3. Adicionar métodos de criação para novos produtos nas fábricas
4. Implementar um sistema de cache para reutilizar instâncias de produtos

Esta implementação segue corretamente o padrão Abstract Factory, proporcionando uma maneira flexível de criar famílias de objetos relacionados enquanto mantém o código cliente independente das classes concretas específicas. O uso de interfaces para todos os produtos e fábricas permite fácil extensibilidade e manutenção do código.
