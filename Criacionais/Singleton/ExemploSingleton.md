# Padr�o Singleton

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/singleton)

Este c�digo implementa o padr�o de projeto **Singleton** em C#, um padr�o criacional que garante que uma classe tenha apenas uma inst�ncia e fornece um ponto global de acesso a ela.

## Estrutura Principal:

### 1. Classe Singleton

- `Singleton`: Classe que possui um campo est�tico privado para armazenar a inst�ncia �nica
- Construtor privado para evitar instancia��o externa
- M�todo est�tico `Instancia` para obter a inst�ncia �nica

### 2. Cliente

- Utiliza o m�todo est�tico para acessar a inst�ncia �nica do Singleton

## Benef�cios desta Implementa��o:

1. **Inst�ncia �nica**: Garante que apenas uma inst�ncia da classe exista durante toda a aplica��o
2. **Acesso global**: Fornece um ponto de acesso global � inst�ncia
3. **Controle de recursos**: �til para gerenciar recursos compartilhados, como conex�es de banco de dados ou arquivos de configura��o

## Exemplo de Uso:
