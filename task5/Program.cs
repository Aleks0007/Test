/* Написать метод, который определяет, какие элементы присутствуют в двух экземплярах в каждом из массивов
(= в двух и более, причем в каждом). На вход подаются два массива. 
На выходе массив с необходимыми совпадениями. */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы первого массива через пробел: ");
        int[] arr1 = GetArrayFromUser();

        Console.Write("Введите элементы второго массива через пробел: ");
        int[] arr2 = GetArrayFromUser();

        int[] commonElements = GetCommonElements(arr1, arr2);
        if (commonElements.Length == 0) Console.WriteLine("Совпадающие элементы отсутствуют");
        else PrintArray(commonElements);       
    }

    static int[] GetArrayFromUser()
    {
        string input = Console.ReadLine()!;
        string[] elements = input.Split(' ');
        int[] array = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            if(!int.TryParse(elements[i], out int element))
            {
                Console.WriteLine("Введены некорректные данные, попробуйте снова");
                Environment.Exit(0);
            }
            else
            {
                array[i] = element;
            }
        }
        return array;
    }

    static int[] GetCommonElements(int[] arr1, int[] arr2)
    {
        int[] result = new int[Math.Min(arr1.Length, arr2.Length)];
        int index = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr2.Length; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    result[index++] = arr1[i];
                    break;
                }
            }
        }
        Array.Resize(ref result, index);
        return result;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("Совпадающие элементы двух массивов: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}