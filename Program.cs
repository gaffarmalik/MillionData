using Bogus_MVC_.Data;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using NuGet.Protocol;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddControllers(options =>
//{
//    options.OutputFormatters.RemoveType<StringOutputFormatter>();
//});


builder.Services.AddControllers()
     //.AddJsonOptions(options => {
     //    // handle loops correctly
     //    options.SerializerSettings.ReferenceLoopHandling =
     //        Newtonsoft.Json.ReferenceLoopHandling.Ignore;

     //    // use standard name conversion of properties
     //    options.SerializerSettings.ContractResolver =
     //        new CamelCasePropertyNamesContractResolver();

     //    // include $id property in the output
     //    options.SerializerSettings.PreserveReferencesHandling =
     //        PreserveReferencesHandling.Objects;
     //});
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.IncludeFields = true;
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        //options.JsonSerializerOptions.ContractResolver = new CamelCasePropertyNamesContractResolver();
       // options.JsonSerializerOptions.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        //options.JsonSerializerOptions.ToJson = true;
    });


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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Create}/{id?}");

app.Run();
