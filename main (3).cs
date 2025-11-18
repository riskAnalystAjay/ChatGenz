using System;
using System.Collections.Generic;

namespace ChatGenz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Welcome to ChatGenz – Mini Chat Simulator =====\n");

            List<string> chatHistory = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Send Message");
                Console.WriteLine("2. View Chat History");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter your username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter your message: ");
                        string message = Console.ReadLine();

                        string formattedMessage = $"{username}: {message}";
                        chatHistory.Add(formattedMessage);

                        Console.WriteLine("\nMessage sent!");
                        break;

                    case "2":
                        Console.WriteLine("\n===== Chat History =====");
                        if (chatHistory.Count == 0)
                        {
                            Console.WriteLine("No messages yet.");
                        }
                        else
                        {
                            foreach (var msg in chatHistory)
                            {
                                Console.WriteLine(msg);
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine("\nExiting ChatGenz. Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}