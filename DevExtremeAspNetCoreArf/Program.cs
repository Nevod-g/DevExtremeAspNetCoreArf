using DevExtremeAspNetCoreArf.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddRazorPages()
    .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddAntiforgery(options => options.HeaderName = "XSRF-TOKEN"); // C����� ������ �� �������� ��� ������ X-CSRF-TOKEN ���������

builder.Services.AddSingleton<IArfRepository, MockArfRepository>(); // ��������� ��������� ����������� � ��������

builder.Services.Configure<RouteOptions>( // ��������������� Url
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
