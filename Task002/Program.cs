// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int GetNumber (string message)
{
    int number = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out number) )
        {
            break;
        }
        else System.Console.WriteLine("Вы ввели не верное число повторите ввод");
    }
    return number;
}
string GetNaturalNumbers(int number1, int number2, int sum)
{
    
    if (number1 == number2+1)
        {
            System.Console.WriteLine($"Сумма двуx чисел: {sum}");
            return " ";
        }
    else sum = sum + number1;
    return GetNaturalNumbers(number1 + 1, number2, sum);


}

int FirstNumber = GetNumber("Введите число: ");
int SecondNumber = GetNumber("Введите число: ");
int sum = 0;
GetNaturalNumbers(FirstNumber,SecondNumber, sum);


// void SumNumber (int FirstNumber, int SecondNumber)
// {
//     int sum = 0;
//     for (; FirstNumber <= SecondNumber; FirstNumber++)
//     {
//         sum = sum + FirstNumber;
//     }
//     System.Console.WriteLine(sum);
    
// }
// int FirstNumber = GetNumber("Введите число: ");
// int SecondNumber = GetNumber("Введите число: ");
// SumNumber(FirstNumber, SecondNumber); 
