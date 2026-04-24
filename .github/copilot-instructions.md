# Copilot instructions for Agora

## Build, test, and lint commands

This repository is a .NET 8 multi-project solution.

```powershell
# Build the API (same target used by CI deploy workflow)
dotnet build .\Backend\Backend.csproj --configuration Release

# Build the Blazor WASM app (same target used by CI deploy workflow)
dotnet build .\WebBlazor\WebBlazor.csproj --configuration Release

# Build everything in the solution
dotnet build .\Agora.sln

# Run tests (TestAgora)
dotnet test .\TestAgora\TestAgora.csproj

# Run a single test (xUnit filter)
dotnet test .\TestAgora\TestAgora.csproj --filter "FullyQualifiedName~TestAgora.UnitTestGenericService.TestGetAllInscripciones"
```

Notes about tests:
- `TestAgora` tests call HTTP endpoints through `Service.GenericService<T>` and are integration-style tests (not isolated unit tests).
- Base URL comes from `Service\Properties\Resources.resx` (`UrlApiLocal` by default in `GenericService<T>`). Ensure the target API is reachable before running tests.

Linting:
- No dedicated lint command/tooling is configured in the repository or CI workflows.

## High-level architecture

Agora is split into one backend API, one shared domain/service library, and multiple clients:

1. `Backend` (ASP.NET Core Web API, EF Core + MySQL)
   - Owns persistence and REST endpoints under `api/[controller]`.
   - `AgoraContext` defines entities, soft-delete query filters, and seed data.
2. `Service` (shared class library)
   - Contains shared domain models (`Capacitacion`, `Inscripcion`, `Usuario`, etc.).
   - Contains reusable HTTP client services (`GenericService<T>`, `CapacitacionService`, `InscripcionService`) consumed by all clients/tests.
   - Endpoint resolution is centralized in `Service\Utils\ApiEndpoints.cs`.
3. Client apps:
   - `WebBlazor` (Blazor WebAssembly, uses `Service` via DI).
   - `Desktop` (WinForms, consumes `Service` directly).
   - `MovilApp` (.NET MAUI, consumes `Service` from ViewModels).
4. `TestAgora`
   - xUnit project referencing `Service`; tests exercise real HTTP calls through service classes.

Domain context (from README): the system manages training courses (`capacitaciones`), registrations (`inscripciones`), attendance/accreditation, payments, and certificate/report workflows.

## Key conventions in this codebase

### 1) Shared model + shared HTTP service pattern
- `Service` is the contract layer between backend and all clients.
- When adding/changing backend fields or endpoints, update shared models/services first so WebBlazor, Desktop, MAUI, and tests remain aligned.

### 2) Soft-delete contract is standardized
- Entities have `IsDeleted`.
- Global filters are configured in `AgoraContext` via `HasQueryFilter(p => !p.IsDeleted)`.
- Controllers expose:
  - `GET .../deleteds` (using `IgnoreQueryFilters()`)
  - `PUT .../restore/{id}`
  - `DELETE {id}` performs soft delete (sets `IsDeleted = true`)
- Preserve this API shape for new entities.

### 3) Endpoint naming is tied to model type names
- `GenericService<T>` builds endpoint URLs using:
  - `ApiEndpoints.GetEndpoint(typeof(T).Name)`
- If you add a new shared model intended for API CRUD, add its mapping in `ApiEndpoints` or service calls will fail.

### 4) Capacitaciones update flow has explicit relationship handling
- `CapacitacionesController.PutCapacitacion` manually:
  - attaches related entities (`TryAttach`),
  - diffs collections to remove/add join rows,
  - nulls navigation properties before insert/remove in some paths.
- Follow this pattern when changing many-to-many/collection update behavior to avoid EF Core tracking/duplicate insert issues.

### 5) CI currently deploys only API and Blazor projects
- GitHub Actions workflows build/publish:
  - `Backend\Backend.csproj`
  - `WebBlazor\WebBlazor.csproj`
- Desktop and MAUI are part of the solution but not part of current CI deploy workflows.
