using ContosoUniversity.Persistencia.Data;
using ContosoUniversity.Persistencia.Repositorios;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<IRepositorioCliente, RepositorioCliente>();
 
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SchoolContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolContext")));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
// agregado opcional para los errores de la base de datos
//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// agregado opcional para las migraciones
/*else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
// este crea una base de datos y elimina una base de datos existente
/*using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<SchoolContext>();
    context.Database.EnsureCreated();
    //DbInitializer.Initialize(context);
}
*/
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
