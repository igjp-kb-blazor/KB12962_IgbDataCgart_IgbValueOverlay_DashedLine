using IgniteUI.Blazor.Controls;
using KB12962_IgbDataCgart_IgbValueOverlay_DashedLine;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor(
        typeof(IgbLegendModule),
    typeof(IgbDataChartCoreModule),
    typeof(IgbDataChartCategoryModule),
    typeof(IgbDataChartInteractivityModule),
    typeof(IgbDataChartAnnotationModule),
    typeof(IgbDataChartCategoryCoreModule),
    typeof(IgbAnnotationLayerProxyModule),
    typeof(IgbCalloutLayerModule),
    typeof(IgbValueOverlayModule)
    );

await builder.Build().RunAsync();
