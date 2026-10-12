do
{
    Console.WriteLine("Enter the first number:");
    int firstNumber = ReadNumberFromConsole();

    Console.WriteLine("Enter the second number:");
    int secondNumber = ReadNumberFromConsole();

    Console.WriteLine("Enter the operation (+, -, *, /):");
    char operation = ReadOperationFromConsole();

    Calculate(firstNumber, secondNumber, operation);
}
while (AskToContinue());

static int ReadNumberFromConsole()
{
    int number;
    while (true)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

static char ReadOperationFromConsole()
{
    char operation;
    while (true)
    {
        string input = Console.ReadLine();
        if (input.Length == 1 && "+-*/".Contains(input))
        {
            operation = input[0];
            return operation;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter one of the following operations: +, -, *, /");
        }
    }
}

static void Calculate(int firstNumber, int secondNumber, char operation)
{
    switch (operation)
    {
        case '+':
            Console.WriteLine($"Result: {firstNumber + secondNumber}");
            break;
        case '-':
            Console.WriteLine($"Result: {firstNumber - secondNumber}");
            break;
        case '*':
            Console.WriteLine($"Result: {firstNumber * secondNumber}");
            break;
        case '/':
            if (secondNumber != 0)
            {
                Console.WriteLine($"Result: {firstNumber / secondNumber}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            break;
        default:
            Console.WriteLine("Invalid operation. Please enter one of the following: +, -, *, /");
            break;
    }
}

static bool AskToContinue()
{
    while (true)
    {
        Console.Write("Do you want to perform another calculation? (y/n): ");
        string input = Console.ReadLine();
        switch (input.ToLower())
        {
            case "y":
                return true;
            case "n":
                Console.WriteLine("Have a nice day!");
                return false;
            default:
                Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
                continue;
        }
    }
}
