# WebForms

Base reutilizável para construir telas de CRUD em **ASP.NET WebForms** usando o padrão **MVP (Model-View-Presenter)**.

## O que tem aqui

| Arquivo | Papel |
|---|---|
| `BaseEntity.cs`, `BaseFilterEntity.cs` | Entidade base e filtro base para consultas |
| `IBusiness.cs`, `BaseBusiness.cs` | Camada de regras de negócio genérica |
| `IViewBase.cs`, `IViewEdicaoSimple.cs` | Contratos das telas (Views) |
| `IPresenterBase.cs`, `PresenterBase.cs` | Presenter genérico que liga a View à regra de negócio |
| `WebPageBase.cs` | Página base para as telas WebForms |
| `ActionReturn.cs`, `EntityAction.cs`, `Operacao.cs`, `EventParam.cs` | Retorno de operações e eventos entre as camadas |
| `PropertyCopy.cs`, `SaveInViewStateAttribute.cs` | Utilitários: cópia de propriedades e persistência no ViewState |

## Tecnologias

- C# / .NET Framework 4.8
- ASP.NET WebForms
- Entity Framework 6

## Como abrir

Abra `WebFormsCRUD.sln` no Visual Studio e restaure os pacotes NuGet.
