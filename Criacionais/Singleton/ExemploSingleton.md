# Padrão Singleton

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/singleton)

Este código implementa o padrão de projeto **Singleton** em C#, que é um padrão criacional que garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a essa instância.

## Estrutura Principal:

1. **Construtor privado**: Impede a instanciação direta da classe por outras classes.

   ```csharp
   private MeubancoDados()
   ```

2. **Campo estático privado**: Armazena a única instância da classe.

   ```csharp
   private static MeubancoDados? instancia;
   ```

3. **Objeto de lock**: Usado para garantir thread-safety na criação da instância.

   ```csharp
   private static readonly object lockObj = new object();
   ```

4. **Método estático de acesso**: Fornece o ponto de acesso global à instância única.
   ```csharp
   public static MeubancoDados ObterInstancia()
   ```

## Exemplo de Uso:

O código demonstra como obter a instância única e verificar que múltiplas chamadas retornam o mesmo objeto:

```csharp
var instancia1 = MeubancoDados.ObterInstancia();
var instancia2 = MeubancoDados.ObterInstancia();
Console.WriteLine($"As instâncias são iguais? {ReferenceEquals(instancia1, instancia2)}");
```

## Saídas do runner.cs

A execução do código produzirá:

```
Instância do banco de dados criada.
Conectando ao banco de dados...
Conectando ao banco de dados...
As instâncias são iguais? True
```

## Benefícios desta Implementação:

1. **Thread-safe**: Uso de double-check locking garante segurança em ambientes multi-thread.
2. **Lazy initialization**: A instância só é criada quando necessária.
3. **Acesso global controlado**: Fornece um ponto único de acesso à instância.
4. **Verificação de instância única**: O código demonstra que realmente obtemos a mesma instância.

## Possíveis Extensões:

1. Implementar `IDisposable` para gerenciamento adequado de recursos.
2. Adicionar mais métodos de operação no banco de dados.
3. Implementar inicialização com parâmetros de configuração.
4. Criar versões para diferentes cenários (como Singleton por thread).

Esta implementação segue corretamente o padrão Singleton e demonstra seus principais conceitos, incluindo a garantia de uma única instância, lazy initialization e thread-safety. A versão no arquivo `ExemploSingleton.cs` é uma implementação básica, enquanto `ExemploSingletonRunner.cs` apresenta uma versão mais completa com thread-safety e demonstração de uso.
