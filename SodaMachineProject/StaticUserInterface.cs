namespace SodaMachineProject
{
    using System;

    internal static class StaticUserInterface
    {
        
        public static string DisplaySodaOptions()
        {
            Console.WriteLine("\nWhich one would you like to buy?");
            Console.WriteLine("1 = Root Beer, 2 = Pepsi, 3 = Fanta");
            string userChoice = Console.ReadLine();
            return userChoice;
        }


        // displays welcome screen
        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Soda Machine. Would you like to buy Soda?");
        }

        // this method displays what the soda machine has!
        public static void DisplayProducts()
        {
            Console.WriteLine($"\nI have:\nRoot Beer   $0.60  \nPepsi   $0.35\nFanta   $0.06");
        }

        // this method displays if user wants to add money and returns input
        public static string DisplayAskAddMoreMoney()
        {
            Console.WriteLine($"\nWould you like to add more money? Type Yes or No!");
            string userInput = Console.ReadLine().ToLower();
            return userInput;
        }

        public static string InsertACoin()
        {
            Console.WriteLine("\nInsert a coin!");
            Console.WriteLine("1: Quarter \n2: Dime \n3: Nickel \n4: Penny");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void DisplayRegisterHasNoChange()
        {
            Console.WriteLine("Register doesn't have enough change! Get your deposit back!");
        }
    }
}
