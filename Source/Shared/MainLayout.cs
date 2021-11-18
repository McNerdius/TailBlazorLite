
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace TailBlazorProject.Shared;

public partial class MainLayout : LayoutComponentBase
{
    private string NavMenuCssClass => collapseNavMenu ? "hidden sm:block" : null;
    private bool collapseNavMenu = true;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
}
