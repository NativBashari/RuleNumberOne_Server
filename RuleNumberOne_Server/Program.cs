using Logic.Contracts;
using Logic.Repository;
using Microsoft.OpenApi.Models;
using Swashbuckle;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
}
    );
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IFundamentalsLogic, FundamentalsLogic>();
builder.Services.AddScoped<IProfileLogic, ProfileLogic>();
builder.Services.AddScoped<IUnitOfWork>(x =>
    ActivatorUtilities.CreateInstance<UnitOfWork>(x, builder.Configuration.GetSection("AppSettings:api_key").Value, builder.Configuration.GetSection("AppSettings:apiEP").Value)
);
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller}/{action}/{id?}");


app.Run();
