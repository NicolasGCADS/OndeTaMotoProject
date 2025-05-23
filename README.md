# 🏍️ OndeTáMoto - API REST em .NET

Este projeto é uma Web API desenvolvida em **ASP.NET Core**, que permite o controle de motos registradas em uma garagem, com operações básicas de CRUD (Create, Read, Update, Delete). A aplicação segue uma arquitetura em camadas, com separação de responsabilidades entre **Model**, **Business**, **Data** e **API**.

---

## 📦 Estrutura do Projeto

OndeTaMotoSolution/
│
├── OndeTaMotoModel/ # Entidades (Modelos de dados)
├── OndeTaMotoBusiness/ # Lógica de negócio (Serviços)
├── OndeTaMotoData/ # Acesso ao banco de dados com EF Core
├── OndeTaMotoApi/ # Projeto principal da API
└── README.md # Documentação do projeto

---

## 🚀 Tecnologias Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle)
- Visual Studio 2022+
- REST Client (ou Postman)

---

## 🔧 Configuração do Banco de Dados

1. No arquivo `appsettings.json` da pasta `OndeTaMotoApi`, configure sua string de conexão:

```json
 "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=MinhaBase;Trusted_Connection=True;"
    }
