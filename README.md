# TailBlazorLite
Tailwind JIT adaptation of default Blazor WASM template

I started [TailBlazor](https://github.com/McNerdius/TailBlazor/) as a reference project, hooking up Tailwind JIT, an Azure Static Web App (Blazor WASM + Azure Functions), along with a Blazor Server and shared Razor Class Library project.  The idea there is to demonstrate some basics of each technology and how to wire them together for seamless "F5" debug/watch experience.  It's not a big project, but it's too "heavy" to call a template.  So i figured i'd do a minimal variety: just a `dotnet new blazorwasm`, swap the Bootstrap for Tailwind CSS, and hook up "F5" for VS Code.
