# WebForms

Reusable base for building CRUD screens in **ASP.NET WebForms** using the **MVP (Model-View-Presenter)** pattern.

## What's inside

| File | Role |
|---|---|
| `BaseEntity.cs`, `BaseFilterEntity.cs` | Base entity and base filter for queries |
| `IBusiness.cs`, `BaseBusiness.cs` | Generic business-rules layer |
| `IViewBase.cs`, `IViewEdicaoSimple.cs` | Screen (View) contracts |
| `IPresenterBase.cs`, `PresenterBase.cs` | Generic Presenter that connects the View to the business layer |
| `WebPageBase.cs` | Base page for WebForms screens |
| `ActionReturn.cs`, `EntityAction.cs`, `Operacao.cs`, `EventParam.cs` | Operation results and events passed between layers |
| `PropertyCopy.cs`, `SaveInViewStateAttribute.cs` | Utilities: property copying and ViewState persistence |

## Tech stack

- C# / .NET Framework 4.8
- ASP.NET WebForms
- Entity Framework 6

## Getting started

Open `WebFormsCRUD.sln` in Visual Studio and restore the NuGet packages.
