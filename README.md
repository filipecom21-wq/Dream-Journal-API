# Dream Journal API

API REST desenvolvida em ASP.NET Core para registrar e gerenciar sonhos.

O projeto foi criado com foco em aprendizado progressivo de desenvolvimento backend utilizando C#, ASP.NET Core e arquitetura em camadas.

---

## Objetivo

Permitir o registro, consulta, atualização e remoção de sonhos através de endpoints HTTP.

Cada sonho contém:

- Id
- Título
- Descrição
- Data
- Nível de Lucidez (1 a 10)

---

## Tecnologias Utilizadas

- C#
- ASP.NET Core Web API
- .NET
- Dependency Injection
- Arquitetura em Camadas
- Git e GitHub

---

## Estrutura do Projeto

```txt
Dream Journal API
│
├── Controllers
│   └── DreamController.cs
│
├── Models
│   └── Dream.cs
│
├── Services
│   └── DreamService.cs
│
└── Program.cs
```

---

## Arquitetura

### Models

Responsáveis por representar os dados da aplicação.

Atualmente existe o modelo:

```csharp
Dream
```

Com as propriedades:

- Id
- Title
- Description
- Date
- LucidityLevel

---

### Services

Responsáveis pelas regras de negócio da aplicação.

O `DreamService` implementa:

- AddDream()
- GetAllDreams()
- GetDreamById()
- UpdateDream()
- DeleteDream()
- ValidateDream()

Também é responsável por:

- Gerar IDs automaticamente
- Validar dados recebidos
- Garantir que o nível de lucidez esteja entre 1 e 10
- Centralizar a lógica da aplicação

---

### Controllers

Responsáveis por receber requisições HTTP e retornar respostas apropriadas.

Endpoints disponíveis:

```http
GET     /api/dream
GET     /api/dream/{id}
POST    /api/dream
PUT     /api/dream/{id}
DELETE  /api/dream/{id}
```

O Controller não contém regras de negócio.

Sua função é:

- Receber a requisição
- Chamar o Service adequado
- Retornar respostas HTTP corretas

---

### Program.cs

Responsável por iniciar a aplicação.

Também realiza:

- Registro dos serviços
- Configuração da injeção de dependência
- Mapeamento dos controllers
- Configuração do pipeline HTTP

---

## Conceitos Aplicados

Durante o desenvolvimento deste projeto foram praticados os seguintes conceitos:

- CRUD
- APIs REST
- Controllers
- Services
- Models
- Dependency Injection
- Arquitetura em Camadas
- Serialização JSON
- Tratamento de Exceções
- Validação de Regras de Negócio
- Status Codes HTTP

---

## Funcionalidades Implementadas

### Cadastro de Sonhos

Permite registrar um novo sonho contendo:

- Título
- Descrição
- Data
- Nível de Lucidez

---

### Consulta de Sonhos

Permite:

- Consultar todos os sonhos cadastrados
- Consultar um sonho específico por ID

---

### Atualização de Sonhos

Permite alterar informações de um sonho já existente.

---

### Exclusão de Sonhos

Permite remover sonhos utilizando seu ID.

---

### Validações

A aplicação atualmente valida:

- Título obrigatório
- Descrição obrigatória
- Nível de Lucidez entre 1 e 10

Caso alguma regra seja violada, a API retorna:

```http
400 Bad Request
```

---

## Testes Realizados

Durante a V1 foram testados os seguintes cenários:

### Cenários de Sucesso

- Cadastro de sonho
- Consulta de todos os sonhos
- Consulta por ID
- Atualização de sonho
- Exclusão de sonho

### Cenários de Falha

- Busca de ID inexistente
- Nível de lucidez fora do intervalo permitido
- Dados inválidos enviados para a API

Respostas HTTP verificadas:

- 200 OK
- 201 Created
- 204 No Content
- 400 Bad Request
- 404 Not Found

---

## Status Atual

### V1 - CRUD em Memória ✅

Implementado:

- Estrutura completa da API
- CRUD funcional
- Injeção de Dependência
- Validações de negócio
- Geração automática de IDs
- Testes manuais dos endpoints

Limitação atual:

Os dados são armazenados apenas em memória e são perdidos quando a aplicação é encerrada.

---

## Roadmap

### V2 - Persistência em JSON

Objetivos:

- Salvar sonhos em arquivo JSON
- Carregar dados automaticamente ao iniciar a aplicação
- Manter informações entre execuções

---

### V3 - Swagger / OpenAPI

Objetivos:

- Documentação automática dos endpoints
- Interface gráfica para testes
- Melhor experiência de desenvolvimento

---

### V4 - SQLite

Objetivos:

- Substituir armazenamento em memória
- Persistência em banco de dados relacional

---

### V5 - Entity Framework Core

Objetivos:

- Utilizar ORM
- Migrations
- Contexto de banco de dados
- Consultas mais robustas

---

## Aprendizados Obtidos na V1

Este projeto foi utilizado para praticar:

- Construção de APIs REST com ASP.NET Core
- Separação de responsabilidades
- Injeção de dependência
- Fluxo Controller → Service → Model
- Criação de endpoints HTTP
- Tratamento de erros
- Retorno de respostas apropriadas
- Estruturação de aplicações backend

---

## Autor

Projeto desenvolvido por mim como parte da minha jornada de aprendizado em C# e desenvolvimento backend utilizando ASP.NET Core.