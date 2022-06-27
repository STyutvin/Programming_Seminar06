internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        Console.WriteLine("Даны две прямые a и b. Прямую a опишем формулой y = k1 * x + b1. Прямую b опишем формулой y = k2 * x + b2. Найдем точку их пересечения.");
        Console.Write("Введите k1: ");
        var k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b1: ");
        var b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        var k2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        var b2 = Convert.ToDouble(Console.ReadLine());
        if (k1 != k2)
        {
            var x = (b2 - b1) / (k1 - k2);
            var y = k1 * x + b1;
            x = Math.Round(x, 3);
            y = Math.Round(y, 3);
            Console.WriteLine($"Прямые a и b пересекаются в точке: ({x}; {y})");
        }
        else Console.WriteLine("Прямые a и b параллельны.");
    }
}