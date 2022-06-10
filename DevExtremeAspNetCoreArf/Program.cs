using DevExtremeAspNetCoreArf.Models;
using DevExtremeAspNetCoreArf.Services;
using Microsoft.AspNetCore.Http.Features;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddAntiforgery(options => options.HeaderName = "XSRF-TOKEN"); // Cлужба защиты от подделки для поиска X-CSRF-TOKEN заголовка

builder.Services.AddSingleton<IRepository<Arf>, MockArfRepository>(); // Подружить интерфейс бибилиотеки с проектом

builder.Services.Configure<RouteOptions>( // Конфигурировать Url
    options =>
    {
        options.LowercaseUrls = true;
        options.LowercaseQueryStrings = true;
        options.AppendTrailingSlash = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Use(async (context, next) => // Промежуточная функция, чтобы включить синхронные вызовы на стороне сервера.
{
    if (context.Request.Path.StartsWithSegments("/some-endpoint-that-needs-sync-io"))
    {
        var syncIoFeature = context.Features.Get<IHttpBodyControlFeature>();
        if (syncIoFeature != null)
        {
            syncIoFeature.AllowSynchronousIO = true;
        }
    }

    await next();
});

app.Run();
