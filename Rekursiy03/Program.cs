//Напишите программу вычисления функции Аккермана с помощью рекурсии.
int FunAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m > 0) && (n == 0))
        return FunAkkerman(m - 1, 1);
    else
        return FunAkkerman(m - 1, FunAkkerman(m, n - 1));
}
 
Console.WriteLine(FunAkkerman(3, 2)); 
Console.WriteLine(FunAkkerman(2, 3)); 
 
Console.WriteLine();