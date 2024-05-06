using Feature.DataBase.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Service.DBService.Extension;

Console.WriteLine("This is UseCase DBService!");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDBContext(builder.Configuration);
builder.Services.AddRepository();
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(typeof(ImageHandlerDBContext).Assembly));

var app = builder.Build();

app.Run();