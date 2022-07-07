using System;

namespace Home1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д..
            Результат напишите в новом массиве.
            [1 2 3 4 5] -> 5 8 3
            [6 7 3 6] -> 36 21
            */
            //.gitignore не работал до тех пор, пока я не изменил названия стандартных папок, почему так не знаешь?
            System.Console.WriteLine("Введите размер массива");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1, 10);
                System.Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int index2 = size - 1;

            int size2;

            if(size % 2 == 0)
            {
                size2 = size / 2;
            }
            else
            {
                size2 = size / 2 + 1;
            }
            
            Console.WriteLine(size2 + " это счетчик");

            int[] resultArray = new int[size2];

            for(int index = 0; index < size2; index++)
            {
                if(index == size2 - 1 && size % 2 != 0)
                {
                    resultArray[index] += array[index];
                }
                else
                {
                    resultArray[index] += array[index] * array[index2];
                    index2 -= 1;
                }
            }
            Console.WriteLine($"[{String.Join(" ", resultArray)}]-таков результат");
        }
    }
}
