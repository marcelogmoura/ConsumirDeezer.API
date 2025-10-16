[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/pt-br/dotnet/csharp/)
[![.NET Core 9.0](https://img.shields.io/badge/.NET_9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://dotnet.microsoft.com/pt-br/apps/aspnet)
[![Entity Framework Core](https://img.shields.io/badge/EF_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)](https://docs.microsoft.com/pt-br/ef/core/)
[![Swagger](https://img.shields.io/badge/Swagger/OpenAPI-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# ConsumirDeezer.API (.NET Core)

API RESTful desenvolvida em **ASP.NET Core 8** para atuar como um *proxy* entre o frontend e a API oficial do Deezer. Ela centraliza a lógica de integração, tratando as chamadas HTTP e o mapeamento de dados (DTOs).

## 🚀 Tecnologias Utilizadas

| Categoria | Tecnologia | Versão |
| :--- | :--- | :--- |
| Framework | ASP.NET Core | 8.0 |
| Linguagem | C# | (Implicitamente moderna) |
| Arquitetura | Domain/Infrastructure/API | Clean Separation |
| API Externa | Deezer API | Integração via HttpClient |
| DI/Config | Dependency Injection, CORS | Configuração em Program.cs |

## 📁 Estrutura do Projeto

O projeto segue uma estrutura modular com foco em responsabilidade:

* **ConsumirDeezer.API:** Camada de Apresentação (Controllers, Program.cs, CORS).
* **ConsumirDeezer.Domain:** Contratos (Interfaces como `IDeezerService` e DTOs).
* **ConsumirDeezer.Infra:** Implementação de Serviços (Lógica de chamada HTTP e repositórios, como `DeezerService.cs`).

## ⚙️ Configuração e Execução

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Visual Studio 2022 ou VS Code

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/marcelogmoura/ConsumirDeezer.API]
    cd ConsumirDeezer.API
    ```

2.  **Restaure as dependências:**
    ```bash
    dotnet restore
    ```

3.  **Execute o projeto:**
    O projeto está configurado para iniciar na porta `5215`, essencial para o Frontend em Angular (`http://localhost:4200`) se conectar (CORS configurado para `http://localhost:4200`).

    ```bash
    dotnet run --project ConsumirDeezer.API/ConsumirDeezer.API.csproj
    ```
    A API será iniciada em `http://localhost:5215`. O Swagger estará disponível em `http://localhost:5215/swagger`.

## 🧭 Endpoints Principais

A API expõe dois endpoints principais através do `ArtistsController.cs`:

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| `GET` | `/api/artists/search/{artistName}` | Busca artistas por nome. |
| `GET` | `/api/artists/{artistId}/top-tracks` | Retorna as Top 5 músicas de um artista (limit=3 configurado na infraestrutura). |

---

## 🧑‍💻 Autor

| Autor | GitHub | LinkedIn | Email |
| :---: | :---: | :---: | :---: |
| **Marcelo Moura** | [![GitHub Badge](https://img.shields.io/badge/-GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/marcelogmoura) | [![LinkedIn Badge](https://img.shields.io/badge/-LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://linkedin.com/in/marcelogmoura) | `mgmoura@gmail.com` |

---

Desenvolvido por Marcelo Moura © 2025



