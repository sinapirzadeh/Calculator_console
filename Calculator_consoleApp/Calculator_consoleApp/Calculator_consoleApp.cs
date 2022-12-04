// Written by Sina Pirzadeh
// Write by .Net 7 Version 
// https://github.com/sinapirzadeh/Calculator_console
//I wrote this program for people who are beginners in C# language so that they can learn from this program

#region Questions and inputs

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Wellcome to Console Calculator :)");
Console.WriteLine("--------------------------------");

// Changing the color of the console
Console.ForegroundColor = ConsoleColor.Cyan;

// Getting the first number from the user //
Console.Write("Enter Your First Number : ");
int.TryParse(Console.ReadLine(), out int number_1);


// Getting the Second number from the user //
Console.Write("Enter Your Second Number : ");
int.TryParse(Console.ReadLine(), out int number_2);

// Getting the Second number from the user //
Console.Write("Choose your operation and enter the desired number of each operator : ");
Console.WriteLine("[ + , - , × , ÷ ]");
string userOperator = Console.ReadLine();

#endregion

#region operation

if (userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/")
{
    Console.WriteLine("your operation is not write ...");
}

// We use Switch to make it easy
switch (userOperator)
{
    case "+":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The sum of the numbers is {number_1} + {number_2} : {number_1 + number_2} ");
        break;
    case "-":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The sum of the numbers is {number_1} – {number_2} : {number_1 - number_2} ");
        break;

    case "*":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The sum of the numbers is {number_1} × {number_2} : {number_1 * number_2} ");
        break;

    case "/":
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"The sum of the numbers is {number_1} ÷ {number_2} : {number_1 / number_2} ");
        break;
}

#endregion