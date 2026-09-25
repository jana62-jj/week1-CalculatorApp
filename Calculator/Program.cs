Console.WriteLine("type the first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("type the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} gives us {2}", firstNumber ,secondNumber, result);


//pauses the program waits until the user presses a key
Console.ReadKey();
