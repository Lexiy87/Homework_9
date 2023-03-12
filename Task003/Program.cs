// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber (string message)
{
    int number = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out number) && number <=3)
        {
            break;
        }
        else System.Console.WriteLine("Вы ввели не верное число повторите ввод");
    }
    return number;
}
int FindAkerman(int m, int n) 
{
    if (m == 0)
    {
        return n + 1; 
    }
    else if ((m != 0) && (n == 0)) 
    {
        
        return FindAkerman(m - 1, 1);
    }
    else
    {
        return FindAkerman(m - 1, FindAkerman(m, n - 1)); 
    }
}

int number1 = GetNumber ("Введите первое число: ");
int number2 = GetNumber ("Введите второе число: ");

System.Console.WriteLine(FindAkerman(number1,number2));


