using System;

namespace Home2
{
    class Program
    {
        static void Main(string[] args)
        {
           /* *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
           Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
            */
            
            int[] array = new int[10];

            int count = 0;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(100, 1000);
                System.Console.Write(array[i] + " ");

                if(array[i] % 2 == 0)
                {
                    count++;
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine(count);
        }
    }
}
