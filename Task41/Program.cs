internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        Console.Write("Введите числа (через пробел или запятую, или tab): ");
        char[] delimiterChars = { ' ', ',', '\t' }; //переменная типа char, которая учитывает знаки разделения между вводимыми символами в строке
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(delimiterChars), int.Parse); //преобразование строки из вводимых символов в цифры
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Кол-во элементов > 0: {count}");
    }
}