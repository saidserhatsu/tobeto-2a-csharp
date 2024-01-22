using Business.DependencyResolvers;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<IBrandDal, InMemoryBrandDal>();
//public static readonly IBrandDal BrandDal = new InMemoryBrandDal(); 
//builder.Services.AddSingleton<BrandBusinessRules>();
//addscoped
//builder.Services.AddScoped<Random>();new Random();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Add services to the container.
builder.Services.AddBusinessServices();

//builder.Services.AddSingleton<IFuelService, FuelManager>();
//builder.Services.AddSingleton<IFuelDal, InMemoryFuelDal>();
//builder.Services.AddSingleton<BrandBusinessRules>();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
