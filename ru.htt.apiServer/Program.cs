using ru.htt.apiServer.Core.Abstractions.Repositories;
using ru.htt.apiServer.Core.Domain;
using ru.htt.apiServer.DataAccess;
using ru.htt.apiServer.DataAccess.Data;
using ru.htt.apiServer.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddMvcOptions(x=>x.SuppressAsyncSuffixInActionNames=false);
builder.Services.AddScoped(typeof(IRepository<>), typeof(InMemoryRepository<>));
builder.Services.AddScoped(typeof(IRepository<Product>),
    (x) => new InMemoryRepository<Product>(FakeDataFactory.Products));
builder.Services.AddScoped(typeof(IRepository<JoinRequest>),
    (x) => new InMemoryRepository<JoinRequest>(FakeDataFactory.JoinRequest));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();