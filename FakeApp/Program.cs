using System;
using FakeApp.API;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/message", (Message message) =>
{
    Console.WriteLine(message.Content);
    Console.WriteLine($"{message.Metadata.AuthorName} - {message.Metadata.CreationTime}");
    return Results.Ok();
});

app.Run("http://localhost:5000");
