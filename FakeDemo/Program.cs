using System;
using System.Net.Http;
using System.Net.Http.Json;
using FakeApp.API;

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
string task = "CONTINUE";
var client = new HttpClient();

while (task == "CONTINUE")
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("MESSAGE: Send a message");
    Console.WriteLine("NAME: Change your name");
    Console.WriteLine("EXIT: Exit the program");
    task = Console.ReadLine().ToUpper();
    if (task == "MESSAGE")
    {
        Console.WriteLine("Enter your message:");
        string content = Console.ReadLine();
        var metadata = new Metadata
        {
            authorName = name,
            creationTime = DateTime.Now
        };
        var message = new Message(content, metadata);
        var response = await client.PostAsJsonAsync("http://localhost:5000/message", message);
        Console.WriteLine($"Message sent!");
        task = "CONTINUE";
    }
    else if (task == "NAME")
    {
        Console.WriteLine("Enter your new name:");
        name = Console.ReadLine();
        Console.WriteLine($"Your name has been changed to: {name}");
        task = "CONTINUE";
    }
    else if (task == "EXIT")
    {
        Console.WriteLine("Exiting the program. Goodbye!");
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
        task = "CONTINUE";
    }
}