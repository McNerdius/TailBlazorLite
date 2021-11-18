
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TailBlazorProject.Shared;

public partial class MainLayout : LayoutComponentBase
{

    [Inject]
    IJSRuntime JSRuntime
    { get; set; }

    private Task<IJSObjectReference> _module;
    private Task<IJSObjectReference> Module => _module ??= JSRuntime.InvokeAsync<IJSObjectReference>( "import", "./Shared/MainLayout.razor.js" ).AsTask();

    private string currentTheme = "light";
    private bool isLightMode => currentTheme == "light";
    private bool collapseNavMenu = true;

    private async Task switchTheme()
    {
        var module = await Module;

        currentTheme = currentTheme switch
        {
            "light" => "dark",
            _ => "light"
        };

        await module.InvokeAsync<string>( "switchTheme", currentTheme );
    }

    private string NavMenuCssClass => collapseNavMenu ? "hidden sm:block" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}
