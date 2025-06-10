# ABM_PadroesDeProjeto

Este projeto é um guia prático para quem quer dominar os **Padrões de Projeto (Design Patterns)** em **C#** usando o **.NET 9**. Ele organiza os padrões em três categorias principais: criacionais, estruturais e comportamentais. Para cada padrão, você encontrará exemplos práticos e executáveis que facilitam o aprendizado e a compreensão de suas aplicações no desenvolvimento de software.

Base de conhecimento:

- Inspirado no projeto [gof-patterns-examples](https://github.com/vmussak/gof-patterns-examples) do curso SOLID e Design Patterns da ADAtech
- Complementado com conteúdo do [Refactoring Guru](https://refactoring.guru/pt-br)

---

## Por que este Projeto?

O objetivo é ser um material de apoio valioso para estudantes e desenvolvedores que buscam aprender ou revisar os padrões de projeto mais utilizados na engenharia de software moderna.

---

## Como o Projeto Está Organizado

O projeto está estruturado de forma intuitiva, facilitando a navegação e o estudo:

- **Padrões Criacionais**: Focados na criação de objetos de forma flexível.
- **Padrões Estruturais**: Lidam com a composição de classes e objetos para formar estruturas maiores.
- **Padrões Comportamentais**: Concentram-se na comunicação e interação entre objetos.

Dentro de cada categoria, você encontrará pastas dedicadas a cada padrão, contendo:

- Um arquivo `.cs` com o código de demonstração do padrão.
- Um "runner" para executar o código no console e visualizar a saída.
- Um arquivo `.md` com orientações detalhadas e explicações sobre o padrão.

---

### **Padrões Criacionais**

| Padrão           | Descrição Resumida                |
| ---------------- | --------------------------------- |
| Abstract Factory | Famílias de objetos relacionados  |
| Builder          | Construção complexa passo a passo |
| Factory Method   | Delega criação para subclasses    |
| Prototype        | Clonagem de objetos existentes    |
| Singleton        | Única instância global            |

---

### **Padrões Estruturais**

| Padrão    | Descrição Resumida                                  |
| --------- | --------------------------------------------------- |
| Adapter   | Adapta interfaces incompatíveis                     |
| Bridge    | Separa abstração da implementação                   |
| Composite | Trata objetos individuais e compostos uniformemente |
| Decorator | Adiciona responsabilidades dinamicamente            |
| Facade    | Interface simplificada para um subsistema           |
| Flyweight | Compartilha objetos para reduzir o uso de memória   |
| Proxy     | Representa outro objeto para controle de acesso     |

---

### **Padrões Comportamentais**

| Padrão                  | Descrição Resumida                                 |
| ----------------------- | -------------------------------------------------- |
| Chain of Responsibility | Encadeia manipuladores de requisição               |
| Command                 | Encapsula solicitações como objetos                |
| Interpreter             | Interpreta linguagens específicas                  |
| Iterator                | Acesso sequencial a elementos de uma coleção       |
| Mediator                | Coordena comunicação entre objetos                 |
| Memento                 | Salva e restaura estados internos                  |
| Observer                | Notificação de mudanças de estado                  |
| State                   | Altera comportamento conforme o estado             |
| Strategy                | Algoritmos intercambiáveis                         |
| Template Method         | Define esqueleto de algoritmo com etapas flexíveis |
| Visitor                 | Opera sobre elementos de uma estrutura             |

---

## Como Executar os Exemplos

É super simples colocar os exemplos para rodar:

1.  Certifique-se de ter o **[.NET 9 SDK](https://dotnet.microsoft.com/)** instalado em sua máquina.
2.  Clone este repositório para o seu ambiente local.
3.  Abra o terminal, navegue até a pasta raiz do projeto (`ABM_PadroesDeProjeto`) e execute o comando:

    ```bash
    dotnet run
    ```

Ao fazer isso, o programa executará demonstrações de todos os padrões implementados, exibindo as saídas diretamente no console. Para tirar o máximo proveito, **leia o arquivo `.md` de cada tópico** antes de executar o código. Isso vai te ajudar a entender a saída e como o padrão funciona na prática.

---

## Licença

Este projeto é de código aberto e está licenciado sob a **Licença MIT**. Para mais detalhes, consulte o arquivo `LICENSE.txt`.

---
