# ConsumirDeezer.API (.NET Core)

API RESTful desenvolvida em **ASP.NET Core 8** para atuar como um *proxy* entre o frontend e a API oficial do Deezer. Ela centraliza a lógica de integração, tratando as chamadas HTTP e o mapeamento de dados (DTOs).

## ?? Tecnologias Utilizadas

| Categoria | Tecnologia | Versão |
| :--- | :--- | :--- |
| Framework | ASP.NET Core | 8.0 |
| Linguagem | C# | (Implicitamente moderna) |
| Arquitetura | Domain/Infrastructure/API | Clean Separation |
| API Externa | Deezer API | Integração via HttpClient |
| DI/Config | Dependency Injection, CORS | Configuração em Program.cs |

## ?? Estrutura do Projeto

O projeto segue uma estrutura modular com foco em responsabilidade:

* **ConsumirDeezer.API:** Camada de Apresentação (Controllers, Program.cs, CORS).
* **ConsumirDeezer.Domain:** Contratos (Interfaces como `IDeezerService` e DTOs).
* **ConsumirDeezer.Infra:** Implementação de Serviços (Lógica de chamada HTTP e repositórios, como `DeezerService.cs`).

## ?? Configuração e Execução

### Pré-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Visual Studio 2022 ou VS Code

### Passos

1.  **Clone o repositório:**
    ```bash
    git clone [SEU_LINK_DO_REPOSITÓRIO]
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

## ?? Endpoints Principais

A API expõe dois endpoints principais através do `ArtistsController.cs`:

| Método | Rota | Descrição |
| :--- | :--- | :--- |
| `GET` | `/api/artists/search/{artistName}` | Busca artistas por nome. |
| `GET` | `/api/artists/{artistId}/top-tracks` | Retorna as Top 5 músicas de um artista (limit=3 configurado na infraestrutura). |