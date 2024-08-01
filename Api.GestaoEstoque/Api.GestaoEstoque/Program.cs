using Api.GestaoEstoque.Bootstrap;
using Api.GestaoEstoque.Configuration;

var origins = "_origins";

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddJsonFile("appsettings.Development.json", optional: true);
}

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: origins, policy =>
    {
        policy.WithOrigins("http://localhost:4200/")
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddSingleton(ConfigDataBase.ConnectionString(builder.Configuration));
InjectionDependency.Injection(builder.Services);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.UseCors(origins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
