using System;
using FakeApp.API;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

// Dependency Injection
var messageHandler = new MessageHandler();

// Create and configure the web application
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure endpoints
app.MapPost("/message", (Message message) =>
{
    messageHandler.ProcessMessage(message);
    return Results.Ok(new { success = true, message = "Message received successfully" });
});

// Configure health check endpoint
app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

app.Run("http://localhost:5000");
