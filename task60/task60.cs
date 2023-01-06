/* Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента */

int[,,] Matrix3d = new int[2, 2, 2];
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
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}