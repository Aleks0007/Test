/* Написать метод, который в консоль выводит таблицу умножения.
На вход метод получает число, до которого выводит таблицу умножения. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()!);
        PrintMultiplicationTable(number);
    }

    static void PrintMultiplicationTable(int number)
    {
        Console.Write("   ");
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i.ToString().PadLeft(2) + " ");
        }
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            Console.Write(i.ToString().PadLeft(2) + " ");
            for (int j = 1; j <= number; j++)
            {
                Console.Write((i * j).ToString().PadLeft(2) + " ");
            }
            Console.WriteLine();
        }
    }
}

