# 🏍️ OndeTáMoto - API REST em .NET

Este projeto é uma Web API desenvolvida em **ASP.NET Core**, que permite o controle de motos registradas em uma garagem, com operações básicas de CRUD (Create, Read, Update, Delete). A aplicação segue uma arquitetura em camadas, com separação de responsabilidades entre **Model**, **Business**, **Data** e **API**.

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

## Como Rodar 

1. Git clone https://github.com/NicolasGCADS/OndeTaMotoProject.git
2. Selecione a pasta OndeTaMoto e selecione OndeTaMoto.sln para compilar o projeto completo
3. Ao rodar o Crud, rode com HTTPS 
4. Ao rodar o Crud com Swagger, rode com esse link http://localhost:5294/swagger/index.html

---

## 🔧 Configuração do Banco de Dados

1. No arquivo `appsettings.json` da pasta `OndeTaMotoApi`, configure sua string de conexão:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=OndeTaMotoDb;Trusted_Connection=True;TrustServerCertificate=True"
}

--- 

## 🧑‍💻 Integrantes do Grupo
Guilherme Romanholi Santos - RM557462
Murilo Capristo - RM556794
Nicolas Guinante Cavalcanti - RM557844





