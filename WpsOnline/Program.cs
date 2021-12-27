using log4net.Config;
using log4net.Repository;
using Microsoft.Extensions.Configuration;
using WpsOnline.Core;



 


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddCors(p =>
{
    p.AddPolicy("wps", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});
builder.Services.AddControllers();

 builder.Services.add

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseAuthorization();

app.UseRouting();
app.UseCors("wps");

app.UseMiddleware<LogMiddlware>();
app.MapControllers();
//app.MapRazorPages();

app.Run();
