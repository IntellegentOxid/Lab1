

using System;



class Program
{

    static void Main()
    {

        int[] arr = new int[100];

        int n, positiveCount = 0, sum = 0;



        Console.Write("Enter the number of elements in the array: ");

        n = int.Parse(Console.ReadLine());



        Console.Write("Enter the elements of the array: ");

        for (int i = 0; i < n; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] > 0)
            {

                positiveCount++;

            }

        }

        int lastZeroIndex = -1;

        for (int i = 0; i < n; i++)
        {

            if (arr[i] == 0)
            {

                lastZeroIndex = i;

            }

        }



        if (lastZeroIndex != -1 && lastZeroIndex < n - 1)
        {

            for (int i = lastZeroIndex + 1; i < n; i++)
            {

                sum += arr[i];

            }

        }



        Console.WriteLine($"Number of positive elements in the array: {positiveCount}");

        Console.WriteLine($"Sum of elements after the last zero: {sum}");

    }

}