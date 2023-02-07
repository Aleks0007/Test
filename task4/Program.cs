/* Написать метод/функцию, который/которая на вход принимает целое число, 
а на выходе возвращает то, является ли число простым (не имеет делителей кроме 1 и самого себя). */

// Задание решено ~ за 15 минут

class Program
{
    static void Main(string[] args)
    {
        int inputNumber = GetUserInput();
        Console.WriteLine(SimpleNumber(inputNumber) ? "Число является простым"
                                                    : "Число не является простым");
    }

    static int GetUserInput()
    {
        Console.Write("Введите целое число: ");
        while (true)
        {
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("Некорректный ввод! Введите целое число:");
        }
    }

    public static bool SimpleNumber(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}