/* Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента */
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int n = ReadInt("введите размерность массива: ");
int[,,] Matrix3d = new int[n, n, n];
FillArray(Matrix3d);
PrintIndex(Matrix3d);


// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i<Matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j<Matrix3d.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k<Matrix3d.GetLength(2); k++)
            {
                Console.Write($"{Matrix3d[i, j, k]}[{i},{j},{k}] ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}