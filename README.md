# Projeto para o curso de SOLID com CSharp

## Antes do SOLID

![image](https://user-images.githubusercontent.com/73663282/206586715-f08e07f5-3701-44a4-86d1-228b2fda8b2c.png)

Dívida tecnica
Code smeells (pistas de problemas): 
    Repetição de códigos

Experiência de outros devs:
    Patterns
    Princípios
    S.O.L.I.D
    
 

## Single responsibility principle
   Metodos e classes devem ter uma unica responabilidade (coesos)

   ```
   Ao escrever um módulo de software você precisa garantir que quando as mudanças forem solicitadas, elas só originem de uma pessoa ou grupo de pessoas representando uma função de negócio específica.
   ```



## Dependency inversion principle

![image](https://user-images.githubusercontent.com/73663282/207467654-699bd250-7cac-499a-8d42-1bba71a10f4d.png)

Como analiso as dependências de uma classe? Vendo quais metodos e propriedades ela usa de outras classes

Qual a diferença entre acoplamento bom e ruim? bom dificilmente vai ser alterado

O que são classes instáveis? classes que dependem de classes que podem ser alteradas e dependem de classes que dependem de outras classes

Que estratégias utilizo para minimizar os acoplamentos ruins?

De que maneira o AspNet Core ajuda a minimizar o acoplamento de nossos controladores e tipos em geral?


```

Crie abstrações e dependa delas para melhorar a qualidade do acoplamento. Esse hábito é formalizado através do Princípio da Inversão das Dependências (DIP), a letra D na sigla S.O.L.I.D.

Explicite as dependências de uma classe. Uma das maneiras de fazer isso é usando parâmetros do construtor. Desse jeito aplicamos um conceito chamado Injeção de Dependência (DI). AspNet Core ajuda a injetar as dependências que foram vinculadas no método ConfigureServices() da classe Startup e assim dizemos que o AspNet Core tem como uma de suas principais funcionalidades ser um container de injeção de dependências.

Quando a classe dependente deixa de resolver as dependências diretamente e cede esse controle para outrém temos o uso do conceito Inversão de Controle (IoC)

```



## Open/closed principle

![image](https://user-images.githubusercontent.com/73663282/209338087-95596b2e-e091-4b7e-8d73-98e958b8e90a.png)

Mantenha sua aplicação fechada para mudanças, mas aberta para extensões

Sempre manter o habito de criar novas classes quando quiser alterar algo

*Service Layer* uma camada arquitetural que separa as regras de negócio das camadas mais externas

Decorator - Uma classe nova chama a antiga com exceção das novas funcionalidades - https://en.wikipedia.org/wiki/Decorator_pattern

 
 
## Liskov Substitution Principle && Interface Segregation Principle

![image](https://user-images.githubusercontent.com/73663282/209551560-0ea2714b-3e2d-46ad-96ad-f008cc990dae.png)

 Manter a coesão entre interfaces

 Sempre cumprir as promessas das implementações (LSP)

 Não implemente funcionalidades que ainda não foram solicitadas! Essa idéia foi cunhada no acrônimo Y.A.G.N.I., You Aint Gonna Need It.

 Sempre que possível busque separar as operações das interfaces em grupos menores. Essa idéia é o Princípio da Segregação das Interfaces (ISP)

 CQRS (em português)

```
SRP. classes e métodos devem ter alta coesão

OCP. mantenha seu projeto aberto a mudanças mas fechado a alterações

LSP. cumpra as promessas definidas nas abstrações

ISP. preocupe-se com coesão e acoplamento em suas interfaces

DIP. dependa de abstrações ao invés de classes concretas

```

![image](https://user-images.githubusercontent.com/73663282/209551542-87ef8283-c33d-4496-8a46-7c533b1af6f7.png)


