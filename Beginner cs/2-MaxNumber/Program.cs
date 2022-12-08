Console.WriteLine("Enter 2 numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

var result = (number1 == number2) ? "Both numbers are equal" 
    : ((number1 > number2) ? $"{number1} is greater" : $"{number2} is greater");
Console.WriteLine(result);