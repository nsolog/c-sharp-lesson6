// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через пробел:");
string strNumbers = Console.ReadLine();

string[] numbers = strNumbers.Split(' ');

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    string convertedChar = Convert.ToString(numbers[i]);
    if (Convert.ToDouble(convertedChar) > 0)
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше нуля => {count}");