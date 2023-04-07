using julyoc.github.io;
using julyoc.github.io.StatesContainers;
using Majorsoft.Blazor.Components.Common.JsInterop;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<NavState>();
builder.Services.AddJsInteropExtensions();

await builder.Build().RunAsync();


// extensions to component reference 
//
// https://github.com/majorimi/blazor-components
// https://blazorextensions.z6.web.core.windows.net/