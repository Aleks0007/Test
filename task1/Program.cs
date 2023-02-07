// Написать метод/функцию, который/которая на вход принимает массив городов.
// В качестве результата возвращает строку, где города разделены запятыми, а в конце стоит точка.

//«Москва, Санкт-Петербург, Воронеж.»

// Задание решено ~ за 15 минут

using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] cities = GetCities();
        string result = FormatCities(cities);
        Console.WriteLine(result);
    }

    static string[] GetCities()
    {
        Console.WriteLine("Введите города через пробел: ");
        string input = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ни один город не введён!");
            return new string[0];
        }

        string[] cities = input.Split(' ');
        return cities;
    }

    static string FormatCities(string[] cities)
    {
        if (cities == null || cities.Length == 0)
        {
            return string.Empty;
        }

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < cities.Length - 1; i++)
        {
            sb.Append(cities[i]);
            sb.Append(", ");
        }
        sb.Append(cities[cities.Length - 1]);
        sb.Append(".");
        return sb.ToString();
    }
}
