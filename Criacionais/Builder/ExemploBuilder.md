# Padrão Builder

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/builder)

Este código implementa o padrão de projeto **Builder** (Construtor) em C#, que é um padrão criacional que separa a construção de um objeto complexo de sua representação, permitindo que o mesmo processo de construção possa criar diferentes representações.

## Estrutura Principal:

### 1. Produto (`InterfaceUsuario`)

- Representa o objeto complexo a ser construído
- Contém uma lista de telas (`Telas`)
- Métodos para adicionar telas (`AdicionarTela`) e mostrar a interface (`MostrarInterface`)

### 2. Builder Abstrato (`InterfaceBuilder`)

- Define a interface para criar partes do produto
- Métodos principais:
  - `CriarNovaInterface`: Inicia a construção de um novo produto
  - `PegarInterface`: Retorna o produto construído
  - `ConstruirTelasIniciais`: Método abstrato para construir telas comuns
  - `ConstruirTelasEspeciais`: Método abstrato para construir telas específicas

### 3. Builders Concretos

- `ClientePadraoBuilder`: Constrói interface para clientes padrão (apenas tela inicial)
- `ClienteVIPBuilder`: Constrói interface para VIPs (tela inicial + benefícios)
- `ClienteConsultorBuilder`: Constrói interface para consultores (tela inicial + benefícios + parceiros)

### 4. Diretor (`DiretorInterface`)

- Controla o processo de construção
- Fornece um método `MontarInterface` que segue uma sequência específica de construção

## Benefícios desta Implementação:

1. **Separação de responsabilidades**: Isola o código de construção da representação do objeto
2. **Controle sobre o processo de construção**: O diretor define a ordem dos passos
3. **Flexibilidade**: Diferentes builders podem criar variações do mesmo produto
4. **Reutilização**: O mesmo processo de construção pode criar diferentes representações

## Fluxo de Construção:

1. O diretor recebe um builder concreto
2. Executa os passos na ordem definida:
   - Cria nova interface
   - Constrói telas iniciais
   - Constrói telas especiais
3. Retorna o produto final

## Exemplo de Uso:

```csharp
var diretor = new DiretorInterface();

// Construindo para cliente padrão
var builderPadrao = new ClientePadraoBuilder();
var interfacePadrao = diretor.MontarInterface(builderPadrao);
interfacePadrao.MostrarInterface();
// Output:
// Telas disponíveis:
// Inicial

// Construindo para cliente VIP
var builderVIP = new ClienteVIPBuilder();
var interfaceVIP = diretor.MontarInterface(builderVIP);
interfaceVIP.MostrarInterface();
// Output:
// Telas disponíveis:
// Inicial
// Benefícios

// Construindo para consultor
var builderConsultor = new ClienteConsultorBuilder();
var interfaceConsultor = diretor.MontarInterface(builderConsultor);
interfaceConsultor.MostrarInterface();
// Output:
// Telas disponíveis:
// Inicial
// Benefícios
// Parceiros
```

## Possíveis Melhorias:

1. Adicionar mais tipos de telas ou componentes
2. Implementar builders para outros tipos de usuários
3. Adicionar métodos para remover telas
4. Implementar validações no processo de construção

Esta implementação segue corretamente o padrão Builder, demonstrando como criar diferentes variações de um objeto complexo (a interface do usuário) usando o mesmo processo de construção. O padrão é particularmente útil quando o objeto precisa ser criado com diferentes configurações ou quando o processo de construção envolve muitos passos.
