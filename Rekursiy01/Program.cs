//Задайте значение N. Напишите программу, которая выведет
 //все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
void NaturalNumber(int N)
{    
       if (N == 0) return ; 
       Console.Write(N+" ");
       NaturalNumber(N-1);
        
}
int N = GetNumber("Введите число:");
NaturalNumber(N);
Console.WriteLine();