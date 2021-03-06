using BlazorKursevi.Server;
using BlazorKursevi.Server.Servisi;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();
builder.Services.AddTransient<PredavaciServis>();

builder.Services.AddDbContext<Db>(opcije =>
    opcije.UseSqlServer(builder.Configuration.GetConnectionString("LokalnaBaza")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapHub<PredavacHub>("predavacHub");
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();