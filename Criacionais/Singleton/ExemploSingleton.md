# Padrão Singleton

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/singleton)

Este código implementa o padrão de projeto **Singleton** em C#, um padrão criacional que garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.

## Estrutura Principal:

### 1. Classe Singleton

- `Singleton`: Classe que possui um campo estático privado para armazenar a instância única
- Construtor privado para evitar instanciação externa
- Método estático `Instancia` para obter a instância única

### 2. Cliente

- Utiliza o método estático para acessar a instância única do Singleton

## Benefícios desta Implementação:

1. **Instância única**: Garante que apenas uma instância da classe exista durante toda a aplicação
2. **Acesso global**: Fornece um ponto de acesso global à instância
3. **Controle de recursos**: Útil para gerenciar recursos compartilhados, como conexões de banco de dados ou arquivos de configuração

## Exemplo de Uso:
