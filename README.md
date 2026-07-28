# BlazorApp1 — Learning GitHub Actions CI/CD

A basic **Blazor Web App (.NET 10, Interactive Server)** used to learn CI/CD
workflows on GitHub.

## Projects

| Project | Purpose |
| --- | --- |
| `BlazorApp1` | The Blazor Server web app |
| `BlazorApp1.Tests` | xUnit unit tests (e.g., `CounterService`) |

The `Counter` page uses an injectable `CounterService` so its logic can be
unit tested by the pipeline.

## Run locally

```powershell
dotnet run --project BlazorApp1
```

## Run tests

```powershell
dotnet test
```

## CI/CD workflows

Workflows live in `.github/workflows/`:

| File | What it does | Trigger |
| --- | --- | --- |
| `ci.yml` | Restore → build → test, uploads test results, writes a summary | push / PR to `master`, or manual (with a Release/Debug + run-tests form) |
| `deploy.yml` | Build → test → publish → deploy to Azure App Service | manual only (template) |

### Watch a run

Actions tab: https://github.com/vatiwari-fadv/learning-git-action/actions

### Enabling deployment (optional)

1. Create an Azure App Service (Linux, .NET 10).
2. Download its **Publish Profile**.
3. Add a repo secret `AZURE_WEBAPP_PUBLISH_PROFILE` with the profile contents.
4. Set `AZURE_WEBAPP_NAME` in `deploy.yml`.
5. Optionally uncomment the `push` trigger to auto-deploy.
