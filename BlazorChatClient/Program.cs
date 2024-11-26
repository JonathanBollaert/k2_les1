using BlazorChatClient;
using BlazorChatClient.Settings;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TalkApi.Sdk;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiSettings = new ApiSettings();
builder.Configuration.GetSection(nameof(ApiSettings)).Bind(apiSettings);

builder.Services.AddHttpClient("TalkApi", options =>
{
    options.BaseAddress = new Uri(apiSettings.BaseUri);
});

builder.Services.AddScoped<ChatChannelService>();
builder.Services.AddScoped<ChatMessageService>();

await builder.Build().RunAsync();
