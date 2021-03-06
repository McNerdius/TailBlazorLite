# 0.3

- Move to .NET 6 RC1 and adjust template to match as appropriate.

# 0.2.6

- Prevent redundant builds when using `watch.ps1`, VS Code `F5`, or `dotnet [watch] run -property TailwindBuild=false` which blocks the `tailwind build` msbuild target. Visual Studio `F5` still relies on it but `watch.ps1` is still the way to go in VS. (I still haven't looked at VS 2022 to see if there is an equivalent of `launch.json` for `F5` behavior there.)

# 0.2.5

- Change html title tag to TailBlazorProject so it will get swapped out for user's project name.
- Specify Preview 6 for deployment as Preview 7 borks build

# 0.2.4

- Don't run `tailwind build` if launched via `watch.ps1` or from VS Code.
- Add Static Web Apps deployment.

# 0.2.3

- include `watch.ps1` to start Blazor/Tailwind watch in one go

# 7/16/2021

- Use [Incrmental Builds](https://docs.microsoft.com/en-us/visualstudio/msbuild/incremental-builds?view=vs-2019) and [Touch Task](https://docs.microsoft.com/en-us/visualstudio/msbuild/touch-task?view=vs-2019) to prevent redundant npm Target runs.

# 7/15/2021

- Fix, or at least improve, "F5" experience for VS Code. Was having an issue where post-clone, `dotnet watch run` wasn't building all of the things, in that it was throwing errors that didn't happen if i'd done `dotnet build && dotnet watch run`.
- Sync with .NET 6 preview 6 `blazorwasm` Template:
  - bump `PackageReference`s to `6.0.0-preview.6.21355.2`
  - apply the [accessibility](https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-6-preview-6/#improved-blazor-accessibility) changes.
  - use `main` and `article` in `MainLayout.razor`
  - add `FocusOnNavigate` to `App.razor` and special handling for `tabindex="-1"`
    - `FocusOnNavigate` works by setting `tabindex="-1"` which Bootstrap 4 special-cases with `outline: 0 !important;` (Side note: As far as i can tell this special casing doesn't happen in Bootstrap 5, and this isn't the only example of Blazor/Bootstrap coupling. ๐ค๐คจ๐๐ etc)
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
