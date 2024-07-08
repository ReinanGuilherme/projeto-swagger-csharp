using SwaggerCSharp.Api.Filters;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
	// adicionando o cabecalho do swagger
	options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
	{
		Title = "SwaggerCSharp API",
		Version = "v1",
		Description = "Documentação da API do projeto SwaggerSharp. Este projeto facilita a documentação de APIs desenvolvidas em C# utilizando o Swagger."
	});
	
	options.EnableAnnotations();
	options.ExampleFilters();
	options.ParameterFilter<CustomParameterFilter>();
});
// importante adicionar para os exemplos funcionarem
builder.Services.AddSwaggerExamplesFromAssemblyOf<Program>();

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
