//Задача 2.1: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Функция Акермана
static int A(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return A(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return A(m - 1, A(m, n - 1));
        }else
        return n + 1;
    }

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = " + A(m, n));