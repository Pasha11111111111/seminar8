//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

Console.Write("Количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество страниц: ");
int pages = Convert.ToInt32(Console.ReadLine());


int[,,] numbers = new int[lines, columns, pages];

FillArray3D(numbers);
PrintArray3D(numbers);


void FillArray3D(int[,,] array)
{
    Random rand = new Random();
    int val = 10;
    int index = rand.Next(1, 3);
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
           for (int k = 0; k < array.GetLength(2); k++, val+=index)
           array[i, j, k] = val;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++)
           for (int k = 0; k < array.GetLength(0); k++)
              Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
            Console.WriteLine();
    }
}