using System;
using System.Net.Http;
using System.Threading.Tasks;
using FakeApp.API;

namespace FakeDemo
{
    /// <summary>
    /// Handles console-based user interface interactions and delegates business logic to services.
    /// Follows the Single Responsibility Principle by separating UI concerns from business logic.
    /// </summary>
    public class ConsoleUI
    {
        private readonly IMessageService _messageService;
        private string _userName;

        /// <summary>
        /// Initializes a new instance of the ConsoleUI class.
        /// </summary>
        /// <param name="messageService">The service responsible for sending messages.</param>
        public ConsoleUI(IMessageService messageService)
        {
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
        }

        /// <summary>
        /// Starts the interactive console application.
        /// </summary>
        public async Task RunAsync()
        {
            Console.WriteLine("Enter your name:");
            _userName = Console.ReadLine();

            string task = "CONTINUE";

            while (task == "CONTINUE")
            {
                DisplayMenu();
                task = Console.ReadLine()?.ToUpper() ?? "INVALID";

                switch (task)
                {
                    case "MESSAGE":
                        await HandleSendMessage();
                        task = "CONTINUE";
                        break;
                    case "NAME":
                        HandleChangeName();
                        task = "CONTINUE";
                        break;
                    case "EXIT":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        task = "CONTINUE";
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the main menu options to the user.
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("MESSAGE: Send a message");
            Console.WriteLine("NAME: Change your name");
            Console.WriteLine("EXIT: Exit the program");
        }

        /// <summary>
        /// Handles sending a message to the remote service.
        /// </summary>
        private async Task HandleSendMessage()
        {
            Console.WriteLine("Enter your message:");
            string content = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(content))
            {
                Console.WriteLine("Message cannot be empty.");
                return;
            }

            try
            {
                var metadata = new Metadata(_userName);
                var message = new Message(content, metadata);
                await _messageService.SendMessageAsync(message);
                Console.WriteLine("Message sent successfully!");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error sending message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Handles changing the user's name.
        /// </summary>
        private void HandleChangeName()
        {
            Console.WriteLine("Enter your new name:");
            string newName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            _userName = newName;
            Console.WriteLine($"Your name has been changed to: {_userName}");
        }
    }
}
