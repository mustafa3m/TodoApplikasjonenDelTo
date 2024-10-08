using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TodoApplikasjonenDelTo;
using TodoApplikasjonenDelTo.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddSingleton<TodoService>();  // Singleton pour partager le service entre composants

await builder.Build().RunAsync();

