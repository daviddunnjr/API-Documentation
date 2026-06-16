using System;
using System.Net.Http;
using FakeApp.API;
using FakeDemo;

// Configuration
var baseUrl = "http://localhost:5000";

// Dependency Injection
var httpClient = new HttpClient();
var messageService = new MessageService(httpClient, baseUrl);
var consoleUI = new ConsoleUI(messageService);

// Run the application
await consoleUI.RunAsync();