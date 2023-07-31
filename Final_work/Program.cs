//  Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении
//   не рекомендуется пользоваться коллекциями, лучше обойтись 
//   исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string [] FillArray (string matt)
 {
    string[] matrix = new string[matt.Length];
    matrix = matt.Split(new char[]{','});
    return matrix;
 }

void PrintArray (string[] mat)
{
    int count = mat.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{mat[i]}, ");
    }
    System.Console.WriteLine();
}

string[] FillNewMatrix (string[] array)

   { 
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string num = array[i];
        if (num.Length <= 3) 
        {
            count++;
        }

    } 

    string[] newmatrix = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    { 
        string num = array[i];
        if (num.Length <= 3) 
        {
            newmatrix[j] = num;
            j++;
        }  
    }
    return newmatrix;
}

System.Console.WriteLine("Введите массив строк через ,");
string array = Console.ReadLine();
string[] matrix = FillArray (array);
PrintArray(matrix);
System.Console.WriteLine("Новый массив с длинной строки <= 3");
PrintArray (FillNewMatrix(matrix));




