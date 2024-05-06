using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Service.DBService.Extension;

Console.WriteLine("This is UseCase DBService!");

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDBContext(builder.Configuration);

var app = builder.Build();

app.Run();