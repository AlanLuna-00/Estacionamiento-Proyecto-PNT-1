var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//using (var scope = app.Services.CreateScope())
//{
    //var dbContext = scope.ServiceProvider.GetRequiredService<TuContexto>();

    // Migrar la base de datos
    //dbContext.Database.Migrate();

    // Inicializar cocheras
  //  CocheraInitializer.InitializeCocheras(dbContext);
//}

app.Run();
