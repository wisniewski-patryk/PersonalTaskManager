using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PersonalTaskManager.Blazor.ClientApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddTransient<ITasksCrudService, TasksCrudService>();

builder.Services.AddScoped(sp => 
	new HttpClient
	{
		BaseAddress = new Uri("https://localhost:5250/") 
	});

await builder.Build().RunAsync();
