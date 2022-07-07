using System;

namespace Home4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            [3 7 22 2 78] -> 76
            */
             int[] array = new int[10];

            int iMin = 0;
            int iMax = 0;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 101);
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
            
            for(int index = 0; index < array.Length; index++)
            {
                if(array[index] < array[iMin])
                {
                    iMin = index;
                }
                if(array[index] > array[iMax])
                {
                    iMax = index;
                }
            }
            System.Console.WriteLine(array[iMax] + "-это максимальный элемент массива");
            System.Console.WriteLine(array[iMin] + "-это минимальный элемент массива");
            System.Console.WriteLine(array[iMax] - array[iMin]);
        }
    }
}
