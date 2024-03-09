using dgnyldrm.com.Data.Abstract;
using dgnyldrm.com.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


/*

builder.Services.AddDbContext<DataBaseContext>( options => 
{
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("database");
    options.UseSqlite(connectionString);
    //var serverVersion = new MySqlServerVersion(new Version(8, 2, 12));

    //options.UseMySql(connectionString, serverVersion);
    
} );
*/

builder.Services.AddDbContext<DataBaseContext>(options =>
{
    var datas = builder.Configuration.GetConnectionString("database");
    options.UseSqlite(datas);

});

//Repository Pattern
builder.Services.AddScoped<IPostRepository, EfcorePostRepository>();
builder.Services.AddScoped<ICategoriesRepository, EfcoreCategoriesRepository>();
builder.Services.AddScoped<ICommendRepository, EfcoreCommendRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


//Yazýlarýn linklerini düzenleyelim.
app.MapControllerRoute(
    name: "ForNews",
    pattern: "post/{Slug}",
    defaults: new { controller = "Post", action = "Details" }
);


//Kategoriler linklerini düzenleyelim.
app.MapControllerRoute(
    name: "ForCategories",
    pattern: "/kategoriler/{Slug}",
    defaults: new { controller = "Post", action = "Index" }
);



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Post}/{action=Index}/{id?}");

app.Run();
