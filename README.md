# Dream Journal API

API REST desenvolvida em ASP.NET Core para registrar, consultar, atualizar e excluir sonhos.

Este projeto está sendo desenvolvido como parte do meu processo de aprendizagem em desenvolvimento Backend com C# e .NET. A proposta é evoluir uma API simples até uma arquitetura próxima à encontrada em aplicações profissionais, implementando novos conceitos de forma incremental e compreendendo o motivo da existência de cada um deles.

---

# Objetivo

Construir uma API REST seguindo boas práticas de arquitetura, utilizando ASP.NET Core e evoluindo progressivamente para tecnologias e padrões utilizados no mercado.

---

# Tecnologias Utilizadas

- C#
- .NET
- ASP.NET Core Web API
- JSON
- Dependency Injection
- Git
- GitHub

---

# Estrutura Atual

```text
Dream Journal API
│
├── Controllers
│
├── Data
│   └── JsonDatabase.cs
│
├── Models
│
├── Services
│
└── Program.cs
```

---

# Arquitetura

## Models

Representam as entidades da aplicação.

Atualmente:

- Dream

---

## Services

Responsáveis pelas regras de negócio.

O DreamService realiza:

- Cadastro
- Consulta
- Atualização
- Exclusão
- Validação dos dados
- Controle do próximo ID
- Comunicação com a camada de persistência

---

## Data

A camada Data é responsável exclusivamente pela persistência dos dados.

Atualmente contém:

- JsonDatabase

Essa classe:

- Salva listas em arquivos JSON
- Carrega listas de arquivos JSON
- Não conhece regras de negócio
- Não conhece a entidade Dream
- Pode ser reutilizada para qualquer lista através de Generics

---

## Controllers

Recebem as requisições HTTP e retornam as respostas da API.

Endpoints disponíveis:

```http
GET     /api/dream
GET     /api/dream/{id}
POST    /api/dream
PUT     /api/dream/{id}
DELETE  /api/dream/{id}
```

---

## Program.cs

Responsável pela configuração da aplicação.

Atualmente realiza:

- Registro do JsonDatabase
- Registro do DreamService
- Injeção de Dependência
- Configuração dos Controllers
- Inicialização da API

---

# Conceitos Aplicados

Até o momento este projeto utiliza:

- CRUD
- ASP.NET Core Web API
- REST
- Controllers
- Services
- Models
- Dependency Injection
- Separação de Responsabilidades
- Persistência em JSON
- Generics
- Serialização JSON
- Validação de Regras de Negócio
- Status Codes HTTP

---

# Funcionalidades

## Cadastro

Permite registrar novos sonhos.

Cada sonho possui:

- Id
- Title
- Description
- Date
- LucidityLevel

---

## Consulta

Permite:

- Listar todos os sonhos
- Buscar um sonho por ID

---

## Atualização

Permite alterar todas as informações de um sonho existente.

---

## Exclusão

Permite remover um sonho através do seu ID.

---

## Validação

A aplicação valida:

- Título obrigatório
- Descrição obrigatória
- Nível de lucidez entre 1 e 10

---

# Evolução do Projeto

## ✅ V1 — CRUD em Memória

Implementado:

- Estrutura inicial da API
- CRUD completo
- Controllers
- Services
- Validações
- Injeção de Dependência
- IDs automáticos

Limitação:

Os dados existiam apenas durante a execução da aplicação.

---

## ✅ V2 — Persistência em JSON

Implementado:

- Camada Data
- JsonDatabase genérico
- Persistência em arquivo JSON
- Carregamento automático dos sonhos ao iniciar a aplicação
- Recuperação automática do próximo ID
- Separação entre regras de negócio e persistência
- Injeção de Dependência do JsonDatabase

Agora os sonhos permanecem salvos mesmo após reiniciar a aplicação.

---

# Próximas Versões

## 🔄 V3

Swagger / OpenAPI

- Documentação automática
- Interface gráfica para testes da API

---

## 🔄 V4

SQLite + Entity Framework Core

- Persistência em banco de dados
- Migrations
- DbContext

---

## 🔄 V5

Refatoração Arquitetural

- Repository Pattern
- IDreamRepository
- DreamRepository
- DTOs
- Logging
- Tratamento Global de Exceções

---

## 🔄 V6

Testes Unitários

- xUnit
- Mocking
- Testes da camada de negócio

---

## 🔄 V7

Autenticação

- JWT
- Authorization
- Proteção dos endpoints

---

## 🔄 V8

Deploy

- Publicação da API
- Docker (opcional)
- Introdução a CI/CD

---

# Objetivo de Aprendizado

Mais do que desenvolver uma API funcional, este projeto busca compreender profundamente os conceitos utilizados em aplicações profissionais .NET.

Cada versão introduz novos recursos apenas quando existe uma necessidade arquitetural real, permitindo que a evolução da aplicação aconteça de forma semelhante ao ciclo de desenvolvimento encontrado em projetos reais.

---

## Autor

Projeto desenvolvido por **Filipe** como parte da jornada de estudos em C# e Desenvolvimento Backend com ASP.NET Core.