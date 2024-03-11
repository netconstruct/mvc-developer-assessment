
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("{resource}.axd/{*pathInfo}", (string resource, string pathInfo, HttpContext context) => {
        context.Response.StatusCode = 404;
        return Task.CompletedTask;
    });
}); // todo check this does what the origional file did

app.Run();
