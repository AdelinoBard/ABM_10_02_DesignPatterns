# Padrão Proxy

[refactoring.guru](https://refactoring.guru/pt-br/design-patterns/proxy)

Este código implementa o padrão de projeto **Proxy** () em C#, que é um padrão estrutural que permite criar um substituto ou representante de outro objeto para controlar o acesso a ele.

## Estrutura Principal:

1. **IDocumento**: Interface comum que define a operação `MostrarDocumento()` que tanto o objeto real quanto o proxy implementam.
2. **DocumentoReal**: A classe concreta que contém a funcionalidade real e que pode ser custosa para ser criada/operada diretamente.
3. **ProxyDocumento**: A classe proxy que controla o acesso ao DocumentoReal, implementando verificações de permissão e criação sob demanda.
4. **PermissaoUsuario**: Classe auxiliar que verifica se um usuário tem permissão para acessar o documento.

## Exemplo de Uso:

No arquivo runner.cs, o exemplo mostra:

1. Criação de um ProxyDocumento com conteúdo sensível
2. Tentativa de acesso pelo usuário "admin" (que tem permissão)
3. Tentativa de acesso pelo usuário "guest" (que não tem permissão)

## Saídas do runner.cs

```
Carregando documento...
Documento para admin: Conteúdo Sensível
Acesso negado para o usuário guest.
```

## Benefícios desta Implementação:

1. **Controle de acesso**: O proxy verifica as permissões antes de permitir o acesso ao objeto real.
2. **Inicialização sob demanda**: O objeto real só é criado quando realmente necessário (lazy initialization).
3. **Interface consistente**: O cliente interage com a mesma interface, não sabendo se está lidando com o proxy ou com o objeto real.
4. **Separação de preocupações**: A lógica de controle de acesso fica separada da lógica do objeto real.

## Possíveis Extensões:

1. Adicionar logging de acesso aos documentos
2. Implementar cache de documentos já carregados
3. Adicionar diferentes níveis de permissão
4. Implementar timeout para documentos abertos
5. Adicionar criptografia para o conteúdo sensível

Esta implementação segue corretamente o padrão Proxy, fornecendo um substituto controlado para o objeto DocumentoReal que adiciona funcionalidades de controle de acesso sem modificar a interface original ou a implementação do objeto real. O padrão é particularmente útil para operações custosas ou sensíveis que requerem controle adicional.
