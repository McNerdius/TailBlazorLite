
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TailBlazorProject;

var builder = WebAssemblyHostBuilder.CreateDefault( args );
builder.RootComponents.Add<App>( "#app" );

builder.Services.AddScoped( sp => new HttpClient { BaseAddress = new Uri( builder.HostEnvironment.BaseAddress ) } );

await builder.Build().RunAsync();

