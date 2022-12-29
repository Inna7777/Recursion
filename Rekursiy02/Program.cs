//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
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
int SumNumbers(int M, int N)
 {
    if (M == 0) return (N * (N + 1)) / 2;            // Если первое число равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если если второе равно нулю
    else if (M == N) return M;                       // Если первое чмсло равно второму
    else if (M < N) return N + SumNumbers(M, N - 1); // Если первое число меньше второго
    else return N + SumNumbers(M, N + 1);
 }

    int M = GetNumber("Введите число:");
    int N = GetNumber("Введите число:");
    Console.WriteLine($"Cумма от {M} до {N}= {SumNumbers(M,N)}");

Console.WriteLine();
