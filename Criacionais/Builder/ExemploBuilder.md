# Padrão Builder

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/builder)

Este código implementa o padrão de projeto **Builder** (Construtor em pt-br) em C#, que é um padrão criacional que permite a construção de objetos complexos passo a passo. O padrão separa a construção de um objeto de sua representação, permitindo que o mesmo processo de construção possa criar diferentes representações.

## Estrutura Principal:

1. **InterfaceUsuario**: A classe complexa que está sendo construída, neste caso representando uma interface de usuário com várias telas.
2. **InterfaceBuilder**: A classe abstrata Builder que define a interface para criação das partes do objeto.
3. **ClientePadraoBuilder, ClienteVIPBuilder, ClienteConsultorBuilder**: Implementações concretas do Builder que criam e montam diferentes versões da InterfaceUsuario.
4. **DiretorInterface**: A classe que direciona o processo de construção, definindo a ordem em que os passos de construção devem ser executados.

## Exemplo de Uso:

O código runner demonstra como usar o padrão Builder na prática:

1. O usuário informa o tipo de cliente ('padrao', 'vip' ou 'consultor')
2. O diretor (DiretorInterface) é instanciado
3. O Builder apropriado é selecionado com base no tipo de cliente
4. O diretor monta a interface usando o Builder
5. A interface construída é exibida

## Saídas do runner.cs

Exemplos de saída para diferentes entradas:

1. Para "padrao":

   ```
   Telas disponíveis:
   Inicial
   ```

2. Para "vip":

   ```
   Telas disponíveis:
   Inicial
   Benefícios
   ```

3. Para "consultor":
   ```
   Telas disponíveis:
   Inicial
   Benefícios
   Parceiros
   ```

## Benefícios desta Implementação:

1. **Separação de preocupações**: A lógica de construção está separada da representação da interface.
2. **Controle sobre o processo de construção**: O diretor define a ordem de construção, enquanto os Builders implementam os detalhes.
3. **Flexibilidade**: Pode-se facilmente adicionar novos tipos de Builders (como para novos tipos de clientes) sem modificar o código existente.
4. **Reutilização**: O mesmo processo de construção pode criar diferentes representações do objeto.

## Possíveis Extensões:

1. Adicionar mais tipos de Builders para outros perfis de usuário.
2. Implementar validação para garantir que a interface construída seja consistente.
3. Adicionar métodos para remoção de telas nos Builders.
4. Implementar um Builder fluente para construção mais legível.
5. Adicionar configurações adicionais para cada tela (como permissões, estilos, etc.).

Esta implementação segue corretamente o padrão Builder, demonstrando como criar diferentes variações de um objeto complexo (InterfaceUsuario) usando o mesmo processo de construção. O padrão é particularmente útil quando o objeto precisa ser criado com diferentes configurações ou quando o processo de construção envolve múltiplos passos.
