/* Написать метод/функцию, который/которая на вход принимает число (int),
а на выходе выдает слово “компьютер” в падеже, соответствующем указанному количеству.

Например, «25 компьютеров», «41 компьютер», «1048 компьютеров». */

class Program
{
    static void Main(string[] args)
    {
        int inputNumber = GetUserInput();
        string getNounDeclension = GetNounDeclension(inputNumber);

        Console.WriteLine(getNounDeclension);
    }

    static int GetUserInput()
    {
        Console.Write("Введите целое неотрицательное число: ");
        while (true)
        {
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out int number))
            {
                return number;
            }

            Console.WriteLine("Некорректный ввод! Введите целое неотрицательное число:");
        }
    }

         static string GetNounDeclension(int number)
        {
            string[] endings = new string[] { "ов", "", "а" };
            int lastDigit = number % 10;

            return number + " компьютер" + (number >= 5 && number < 20 || lastDigit >= 5
                                                                       || lastDigit == 0 ? endings[0] :
                                                                          lastDigit == 1 ? endings[1] : endings[2]);
        }
}