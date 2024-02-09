//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

//Функция выводит целые числа между числами X и Y
static int numbers_subtraction(int x, int y)
{
    if(x+1<y-1){
        Console.Write(x+1);
        return numbers_subtraction(x+1, y);
    }
    else{
        return y-1;
    }
}
int a =  int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.Write(numbers_subtraction(a, b));
