using System;

namespace My_ATM_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PIN Code
            int pin = 1234;

            Console.Write("Enter PIN: ");

            if (!int.TryParse(Console.ReadLine(), out int enteredPin))
            {
                Console.WriteLine("Invalid PIN.");
                return;
            }

            if (enteredPin != pin)
            {
                Console.WriteLine("Wrong PIN.");
                return;
            }

            // Initial Balance
            int balance = 1000;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("* ATM Menu *");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Please Choose: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Current Balance: " + balance);
                        break;

                    case 2:
                        Console.Write("Input Deposit Amount: ");

                        if (int.TryParse(Console.ReadLine(), out int deposit))
                        {
                            balance += deposit;
                            Console.WriteLine("Funds Added Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Amount To Withdraw: ");

                        if (int.TryParse(Console.ReadLine(), out int withdraw))
                        {
                            if (withdraw > balance)
                            {
                                Console.WriteLine("Insufficient Funds.");
                            }
                            else
                            {
                                balance -= withdraw;
                                Console.WriteLine("Amount Withdrawn Successfully.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Amount.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank You For Choosing Our Service.");
                        return;

                    default:
                        Console.WriteLine("Invalid Selection.");
                        break;
                }
            }
        }
    }
}