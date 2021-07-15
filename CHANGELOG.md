# 7/15/2021

- Fix, or at least improve, "F5" experience for VS Code. Was having an issue where post-clone, `dotnet watch run` wasn't building all of the things, in that it was throwing errors that didn't happen if i'd done `dotnet build && dotnet watch run`.
- Sync with .NET 6 preview 6 `blazorwasm` Template:
  - bump `PackageReference`s to `6.0.0-preview.6.21355.2`
  - apply the [accessibility](https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-6-preview-6/#improved-blazor-accessibility) changes.
  - use `main` and `article` in `MainLayout.razor`
  - add `FocusOnNavigate` to `App.razor` and special handling for `tabindex="-1"`
    - `FocusOnNavigate` works by setting `tabindex="-1"` which Bootstrap 4 special-cases with `outline: 0 !important;` (Side note: As far as i can tell this special casing doesn't happen in Bootstrap 5, and this isn't the only example of Blazor/Bootstrap coupling. 🤔🤨😒🙁 etc)
  - add `title=` to NavMenu buttons
  - add `[EditorRequired]` to `IconLink` and `SurveyPrompt`. Works for [ChildContent parameters](Assets/[EditorRequired].png), too !
- Set up GH Action to package the template. Manual download/PackTemplate/install as described below is required to use `dotnet new tailblazor`; It seems using GH Packages anonymously isn't a thing. Pushing to NuGet will come sooner rather than later, it seems.

# 7/13/2021

- Restructure the folders in a template-friendly manner
- Add files for `dotnet new tailblazor` template:
  - `.template.config/*` describes the template
  - `TailBlazorLite.nuspec` describes the `nupkg` file to be distributed
  - `PackTemplate.ps1` creates the `nupkg`

Once `PackTemplate` has been run, `dotnet new --install McNerdius.TailBlazor.Lite.***` will install the `tailblazor` template, allowing `dotnet new tailblazor`.
