using ContactApp.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Build the configuration
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

// Read the connection string from appsettings.json
var connectionString = configuration.GetConnectionString("MongoDB");

// Configure MongoDB connection
// Add services to the container.
builder.Services.AddControllersWithViews();

// Register MongoDBClient as a service
builder.Services.AddSingleton<MongoDBClient>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "save-contact",
    pattern: "{controller=Contact}/{action=Save}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "get-contact",
    pattern: "{controller=Contact}/{action=GetContact}/{id?}");    

app.Run();

