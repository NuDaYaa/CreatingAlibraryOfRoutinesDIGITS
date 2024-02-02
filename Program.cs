using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (Math.Abs(num1) > Math.Abs(num2))
        {
            num1 = SubprogramA.ReduceByHalf(num1);
            Console.WriteLine("Первое число уменьшено в два раза: " + num1);
        }

        if (Math.Sqrt(num2) < num1)
        {
            num2 = SubprogramB.IncreaseByFiveTimes(num2);
            Console.WriteLine("Второе число увеличено в пять раз: " + num2);
        }
    }
}
