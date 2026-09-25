using System.ComponentModel.Design;
using System.Xml.Serialization;

CalculatorApp();
void CalculatorApp() { 


    Console.WriteLine("type the first number followed by the enter key");
    int firstNumber = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("type the second number followed by the enter key");
    int secondNumber = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("choose an option from the followig list");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3- Divide");
    Console.WriteLine("4 - Multiply");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {

        int result = firstNumber + secondNumber;

        Console.WriteLine($"Adding {firstNumber}  and  {secondNumber} equals {result}");


    }

    else if (choice == 2)
    {
        int result = firstNumber - secondNumber;
        Console.WriteLine($"Subtractig {firstNumber} from {secondNumber} equals {result}");
    }

    else if (choice == 3)
    {
        int result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} from {secondNumber} equals {result}");
    }

    else if (choice == 4){
        int result = firstNumber * secondNumber;
        Console.WriteLine($" Multiply {firstNumber} from {secondNumber} equals {result}");

    }

    else
    {
        Console.WriteLine("Invalid choice");
    }




    }




    
