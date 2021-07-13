# 7/13/2021

 * Restructure the folders in a template-friendly manner
 * Add files for `dotnet new tailblazor` template:
   *  `.template.config/*` describes the template
   *  `TailBlazorLite.nuspec` describes the `nupkg` file to be distributed
   *  `PackTemplate.ps1` creates the `nupkg`

Once `PackTemplates` has been run, `dotnet new --install McNerdius.TailBlazor.Lite.***` will install the `tailblazor` template.
