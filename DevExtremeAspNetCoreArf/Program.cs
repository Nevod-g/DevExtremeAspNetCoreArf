using DevExtremeAspNetCoreArf.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddAntiforgery(options => options.HeaderName = "XSRF-TOKEN"); // Cлужба защиты от подделки для поиска X-CSRF-TOKEN заголовка

builder.Services.AddSingleton<IArfRepository, MockArfRepository>(); // Подружить интерфейс бибилиотеки с проектом

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

app.Run();
