# Padrão Memento

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/memento)

Este código implementa o padrão de projeto **Memento** () em C#, que é um padrão comportamental que permite capturar e externalizar o estado interno de um objeto sem violar o encapsulamento, para que o objeto possa ser restaurado para este estado mais tarde.

## Estrutura Principal:

O código apresenta três componentes principais do padrão Memento:

1. **Originator (EditorTexto)**:

   - Classe cujo estado precisa ser salvo/restaurado
   - Possui métodos para criar (`SalvarEstado`) e restaurar (`RestaurarEstado`) mementos

2. **Memento (TextoMemento)**:

   - Armazena o estado do Originator
   - Nesta implementação, é imutável (propriedade apenas com getter)

3. **Caretaker**:
   - Responsável por guardar os mementos
   - Gerencia quando salvar estados (`Salvar`) e quando restaurar (`Desfazer`)
   - Mantém uma lista de todos os estados salvos

## Exemplo de Uso:

No runner.cs vemos um exemplo prático:

1. Cria-se um editor de texto e seu caretaker
2. Adiciona-se conteúdo e salva-se o estado duas vezes
3. Adiciona-se mais conteúdo sem salvar
4. Restaura-se para um estado anterior (índice 1)

## Saídas do runner.cs

A execução produzirá:

```
Estado Atual:
Primeira linha do texto
Segunda linha do texto
Terceira linha do texto

Estado após desfazer:
Primeira linha do texto
Segunda linha do texto
```

## Benefícios desta Implementação:

1. **Preserva encapsulamento**: O EditorTexto controla como seus estados são salvos/restaurados
2. **Histórico de estados**: Permite voltar a qualquer ponto salvo anteriormente
3. **Responsabilidade única**: A gestão dos backups fica com o Caretaker
4. **Flexibilidade**: Pode-se implementar diferentes políticas de undo/redo

## Possíveis Extensões:

1. Adicionar limite máximo de mementos armazenados
2. Implementar desfazer/refazer como pilha em vez de acesso por índice
3. Adicionar metadados aos mementos (data/hora, nome do snapshot)
4. Implementar serialização para persistência em disco
5. Adicionar compressão dos estados para economizar memória

Esta implementação segue corretamente o padrão Memento, proporcionando um mecanismo eficiente para salvar e restaurar estados de um objeto sem expor seus detalhes internos. O exemplo demonstra claramente a utilidade do padrão em cenários como editores de texto onde operações de undo/redo são essenciais.
