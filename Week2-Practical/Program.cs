
using System;
using System.Reflection.Metadata.Ecma335;

/*
 * Practical: 2
 * Information: Methods demo
 * Version: 1
 * Author: Mr Sam Watson
 * Date: 30/09/2024
 */

Main();

static void Main()
{

    int option;
    bool exitPressed = false;

    PrintMenu();

    do
    {

        option = GetOption();
        Console.WriteLine(GetMessage(option));

    } while (option != 0);



}

static void PrintMenu()
{

    Console.WriteLine("Please enter a vlaid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit Application");

}

static int GetOption()
{

    int selection = 0;
    bool validInput = false;
    
    while (!validInput)
    {

        try
        {

            selection = Convert.ToInt32(Console.ReadLine());

            if (selection < 5 && selection > -1)
            {

                validInput = true;


            }
            else
            {

                Console.WriteLine("\nPlease select 0, 1, 2, 3 or 4:");

            }

        }
        catch (FormatException ex)
        {

            Console.WriteLine("\nInvalid input! Please try again:");

        }

    }

    

    return selection;

}

static String GetMessage(int option)
{

    string result = "";

    switch (option)
    {

        case 0:
            Console.WriteLine("\nExiting... Goodbye!");
            break;
        case 1:
            result = "\nBonjour";
            break;
        case 2:
            result = "\nOla";
            break;
        case 3:
            result = "\nHallo";
            break;
        case 4:
            result = "\nCiao";
            break;

    }

    return result;


}