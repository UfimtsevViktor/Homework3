using System;

namespace Homework3
{
    class array
    {
        static void Main(string[] args)
        {
            // Задание 1

            /*
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 4);
                if (arr[i] == 0)
                {
                    arr[i] = 2;
                }
                Console.WriteLine(arr[i]);
            */

            // Задание 2

            /*
            int[] arr = { 4, 10, 27, 33, 59 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            */

            // Задание 3

            /*
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-7, 10);
            }
            int maxMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < maxMin)
                {
                    maxMin = array[i];
                }
            }
            if (maxMin == 0)
            {
                Console.WriteLine("нет элемента");
            }
            else
            {
                Console.WriteLine($"элемент {maxMin}");
            }
            */

            // Задание 4

            /*
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-7, 10);
            }
            int summa = 0;
            int multi = 0;

            for (int i = 0; i < 10; i++)
                summa += array[i];

            for (int i = 0; i < 10; i++)
                multi *= array[i];

            Console.WriteLine(summa);
            Console.WriteLine(multi);
            */

            // Задание 5

            int[] array = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 39);

            int lastNum = Convert.ToInt32(Console.ReadLine());
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos >= 0 && pos < array.Length)

                for (int i = array.Length - 1; i > pos; i--)
                    array[i] = array[i - 1];

            else pos = array.Length - 1;
            array[pos] = lastNum;

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
        }
    }
}
