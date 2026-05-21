using System;
using System.Collections.Generic;

class ATM
{
    static double balance = 5000;
    static string correctPin = "1234";
    static List<string> history = new List<string>();

    static void Main()
    {
        Console.Write("Enter PIN: ");
        string pin = Console.ReadLine();

        if (pin != correctPin)
        {
            Console.WriteLine("Incorrect PIN. Exiting...");
            return;
        }

        Console.WriteLine("Login successful!\n");

        bool running = true;
        while (running)
        {
            Console.WriteLine("=== ATM MENU ===");
            Console.WriteLine("[1] Check Balance");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Deposit");
            Console.WriteLine("[4] Transaction History");
            Console.WriteLine("[5] Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"\nBalance: ₱{balance:N2}\n");
                    break;
                case "2":
                    Withdraw();
                    break;
                case "3":
                    Deposit();
                    break;
                case "4":
                    ShowHistory();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Thank you! Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.\n");
                    break;
            }
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ₱");
        if (double.TryParse(Console.ReadLine(), out double amount))
        {
            if (amount <= 0)
                Console.WriteLine("Invalid amount.\n");
            else if (amount > balance)
                Console.WriteLine("Insufficient balance.\n");
            else if (amount % 100 != 0)
                Console.WriteLine("Amount must be a multiple of ₱100.\n");
            else
            {
                balance -= amount;
                history.Add($"Withdraw: -₱{amount:N2} | Balance: ₱{balance:N2}");
                Console.WriteLine($"₱{amount:N2} withdrawn successfully.\n");
            }
        }
        else Console.WriteLine("Invalid input.\n");
    }

    static void Deposit()
    {
        Console.Write("Enter amount to deposit: ₱");
        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
        {
            balance += amount;
            history.Add($"Deposit: +₱{amount:N2} | Balance: ₱{balance:N2}");
            Console.WriteLine($"₱{amount:N2} deposited successfully.\n");
        }
        else Console.WriteLine("Invalid amount.\n");
    }

    static void ShowHistory()
    {
        if (history.Count == 0)
            Console.WriteLine("No transactions yet.\n");
        else
        {
            Console.WriteLine("\n=== TRANSACTION HISTORY ===");
            foreach (var item in history)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}
