//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

//Заполняем массив с рандомными числами от 1 до 999
int[] Recursion(int[] array, int i){
    if(i<array.GetLength(0)){
        Random rnd = new Random();
        array[i] = rnd.Next(1, 11);
        return Recursion(array, i+=1);
    }
    else{
        return array;
    }
}
//Если BACK==FALSE, то функция просто выводит массив, иначе выводит элементы начиная с конца
int[] Back(int[] array, int i, bool back){
    if(i>0 && back){
        Console.Write($"{array[i-1]} ");
        return Back(array, i-=1, back);
    }
    else if(!back && i<array.GetLength(0)){
        Console.Write($"{array[i]} ");
        return Back(array, i+=1, back);
    }
    else{
        return array;
    }
}


int[] CreateMatrix(int Count) // Функция создания массива
{
    int[] matrix = new int[Count];
    Recursion(matrix, 0);
    return matrix;
}

void ShowMatrix(int[] matrix, int i, bool back) // Функция вывода массива на экран
{
    
    Back(matrix, i, back);
}

int[] matrix = CreateMatrix(5); // Задание размера массива
ShowMatrix(matrix, 0, false);
Console.WriteLine("");
ShowMatrix(matrix, matrix.GetLength(0), true);