/* Написать метод/функцию, который/которая на вход принимает число (float), 
а на выходе получает число, округленное до пятерок.
Пример:
27 => 25, 27.8 => 30, 41.7 => 40. */

using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        float inputNumber = GetUserInput();
        float outputNumber = GetRound(inputNumber);
        WriteLine($"Округлённое число: {outputNumber}");
    }

    static float GetUserInput()
    {
        Write("Введите число: ");
        while (true)
        {
            string input = ReadLine()!;

            if (float.TryParse(input, out float inputNumber))
            {
                return inputNumber;
            }

            WriteLine("Некорректный ввод. Пожалуйста, введите действительное число с плавающей запятой");
        }
    }

    public static int GetRound(float number)
    {
        return (int)(MathF.Round(number / 5) * 5);
    }
}