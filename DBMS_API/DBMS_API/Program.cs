using DBMS_API.DataAccess;
using DBMS_API.Domain.Models.MarketingDepartment;
using DBMS_API.Domain.Models.Provider;
using DBMS_API.Properties.Common;
using DBMS_API.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient();
builder.Services.AddMvc();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(typeof(MarketingDepartmentContext))
            .AddSingleton(typeof(IRepository<MarketingDepartmentContext>), typeof(MarketingRepository))
            .AddDbContextPool<MarketingDepartmentContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("MarketingConnection")));

builder.Services.AddSingleton(typeof(ServiceDepartmentContext))
           .AddSingleton(typeof(IRepository<ServiceDepartmentContext>), typeof(ServiceRepository))
           .AddDbContextPool<ServiceDepartmentContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ServiceConnection")));

builder.Services.AddSingleton(typeof(ProviderContext))
           .AddSingleton(typeof(IMongoRepository), typeof(MongoRepository));

builder.Services.Configure<ProviderContext>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services
.AddAutoMapper(typeof(BaseAppMappingProfile))
.AddAutoMapper(typeof(StoryAppMappingProfile));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "DealershipCenterAPI", Version = "v1" });
    //var filePath = Path.Combine(AppContext.BaseDirectory, "DBMS_API.xml");
    //c.IncludeXmlComments(filePath);
});

var assm = Assembly.GetExecutingAssembly();
builder.Services.AddMediatR(assm);

var app = builder.Build();

app.UseExceptionHandler("/error");

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("../swagger/v1/swagger.json", "DealershipCenter API");
    c.RoutePrefix = string.Empty;
});

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();



/*var context = new MarketingDepartmentContext();
var repository = new Repository(context);
var list = await repository.GetAllAsync<Car>();
foreach (var item in list)
{
    Console.WriteLine(item.Price);
}*/


/*var repository = new MongoRepository();
var list = await repository.GetAllAsync();

Console.WriteLine("2222222222222222222");
foreach (var item in list)
{
    if(item.CarsObj != null)
    {
        Console.WriteLine(item.CarsObj[0].Body);
    }
}*/

