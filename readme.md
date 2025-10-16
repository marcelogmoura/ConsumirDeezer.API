# ConsumirDeezer.API (.NET Core)

API RESTful desenvolvida em **ASP.NET Core 8** para atuar como um *proxy* entre o frontend e a API oficial do Deezer. Ela centraliza a l�gica de integra��o, tratando as chamadas HTTP e o mapeamento de dados (DTOs).

## ?? Tecnologias Utilizadas

| Categoria | Tecnologia | Vers�o |
| :--- | :--- | :--- |
| Framework | ASP.NET Core | 8.0 |
| Linguagem | C# | (Implicitamente moderna) |
| Arquitetura | Domain/Infrastructure/API | Clean Separation |
| API Externa | Deezer API | Integra��o via HttpClient |
| DI/Config | Dependency Injection, CORS | Configura��o em Program.cs |

## ?? Estrutura do Projeto

O projeto segue uma estrutura modular com foco em responsabilidade:

* **ConsumirDeezer.API:** Camada de Apresenta��o (Controllers, Program.cs, CORS).
* **ConsumirDeezer.Domain:** Contratos (Interfaces como `IDeezerService` e DTOs).
* **ConsumirDeezer.Infra:** Implementa��o de Servi�os (L�gica de chamada HTTP e reposit�rios, como `DeezerService.cs`).

## ?? Configura��o e Execu��o

### Pr�-requisitos

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Visual Studio 2022 ou VS Code

### Passos

1.  **Clone o reposit�rio:**
    ```bash
    git clone [SEU_LINK_DO_REPOSIT�RIO]
    cd ConsumirDeezer.API
    ```

2.  **Restaure as depend�ncias:**
    ```bash
    dotnet restore
    ```

3.  **Execute o projeto:**
    O projeto est� configurado para iniciar na porta `5215`, essencial para o Frontend em Angular (`http://localhost:4200`) se conectar (CORS configurado para `http://localhost:4200`).

    ```bash
    dotnet run --project ConsumirDeezer.API/ConsumirDeezer.API.csproj
    ```
    A API ser� iniciada em `http://localhost:5215`. O Swagger estar� dispon�vel em `http://localhost:5215/swagger`.

## ?? Endpoints Principais

A API exp�e dois endpoints principais atrav�s do `ArtistsController.cs`:

| M�todo | Rota | Descri��o |
| :--- | :--- | :--- |
| `GET` | `/api/artists/search/{artistName}` | Busca artistas por nome. |
| `GET` | `/api/artists/{artistId}/top-tracks` | Retorna as Top 5 m�sicas de um artista (limit=3 configurado na infraestrutura). |