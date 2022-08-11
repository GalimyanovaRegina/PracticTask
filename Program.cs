

using System;

//Формируем массив из строк на стадии выполнения алгоритма
string[] array = { "hello", "2", "world", ":-)" };
OutputArray(array);
var newArray = GenerationArray(array);
OutputArray(newArray);

//Метод вывода массива
void OutputArray(string[] array)
{
    foreach (var str in array)
        Console.Write(str + "  ");
    Console.WriteLine();
}

//Формирование массива
string[] GenerationArray(string[] array)
{
    var count = 0;
    foreach (var str in array)
        if (str.Length <= 3)
            count++;
    var generationArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) continue;
        generationArray[j] = array[i];
        j++;
    }
    return generationArray;
}




