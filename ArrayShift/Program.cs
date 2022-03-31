using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            int[] array = new int[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine($"исходный массив: {string.Join(", ", array)}");

            Console.Write($"Введите число для смещения массива: ");
            int step = Convert.ToInt32(Console.ReadLine());

            if (step >= count || step <= -count)
            {
                int temporary = step % count;
                step = temporary;
            }

            if (step < 0)
            {
                step = count + step;
            }

            for (int j = 0; j < step; j++)
            {
                int lastValue = array[0];

                for (int i = 0; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[count - 1] = lastValue;
            }

            Console.WriteLine($"массив со смещением: {string.Join(", ", array)}");
        }
    }
}
