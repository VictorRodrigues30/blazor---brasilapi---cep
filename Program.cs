using BlazorWasmBrasilApiCep;
using BlazorWasmBrasilApiCep.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient para a BrasilAPI
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://brasilapi.com.br/")
    });

// Registro do serviço de CEP
builder.Services.AddScoped<CepService>();

await builder.Build().RunAsync();