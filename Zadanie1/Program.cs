//Задача 37: 

//Найдите произведение пар чисел в одномерном массиве. 

//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

//Результат запишите в новом массиве.

//[1,2,3,4,5] -> 5 3 8
// [ 6,7,3,6] -> 36 21

int[] CreateArr()
{
    int number = Random.Shared.Next(5,10);
    int[] arr = new int[number];
    return arr;
}

void FillArray(int[] array)
{
     for (int i = 1; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(10);
}
}

 string PrintArray(int[] priarray)
{
    string output = String.Empty;
    int size = priarray.Length;

    for (int i = 1; i < size; i++)
    {
        output = output + $"{priarray[i]} ";
    }
    return output;
}

int[] CopyArray(int[] colection)
{
    int[] copyArr = new int [colection.Length];
    for (int i = 0; i < colection.Length; i++)
    {
        copyArr[i] = colection[i];
    }
    return copyArr;
}  

int[] arr = CreateArr();
FillArray(arr);
string Print = PrintArray(arr);
Console.WriteLine(Print);
int[] newArr = CopyArray(arr);
string newPrint = PrintArray(newArr);
Console.WriteLine(newPrint);