using System;
using System.Threading;


namespace Only_practica
{
    class Program


    {
        static void Main(string[] args)
        {
        Start:
            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Вас приветствует калькулятор!");
                Thread.Sleep(300);
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Вас приветствует калькулятор!");
                Thread.Sleep(300);
                Console.ResetColor();
                Console.Clear();
            }
            

            double value1;
            value1 = FirstOperand();

            double value2;
            value2 = SecondOperand();

            Console.WriteLine("Выберите операцию: '+', '-', '*', '/'");
            string operation = Console.ReadLine();
            Console.Clear();

            switch (operation)
            {
                case "+":
                    Console.ForegroundColor = ConsoleColor.Green;
                    double result1 = Sum(value1, value2);
                    Console.WriteLine($"Ответ: {value1} + {value2} = {result1}");
                    Console.ResetColor();
                    Console.Write("Чтобы продолжить нажмите любую кнопку:");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                case "-":
                    Console.ForegroundColor = ConsoleColor.Green;
                    double result2 = Difference(value1, value2);
                    Console.WriteLine($"Ответ: {value1} - {value2} = {result2}");
                    Console.ResetColor();
                    Console.Write("Чтобы продолжить нажмите любую кнопку:");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                case "*":
                    Console.ForegroundColor = ConsoleColor.Green;
                    double result3 = Multiplication(value1, value2);
                    Console.WriteLine($"Ответ: {value1} * {value2} = {result3}");
                    Console.ResetColor();
                    Console.Write("Чтобы продолжить нажмите любую кнопку:");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                case "/":
                    Console.ForegroundColor = ConsoleColor.Green;
                    double result4 = Division(value1, value2);
                    Console.WriteLine($"Ответ: {value1} / {value2} = {result4}");
                    Console.ResetColor();
                    Console.Write("Чтобы продолжить нажмите любую кнопку:");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ты тупой чтоле?)");
                    Console.ResetColor();
                    Console.Write("Чтобы продолжить нажмите любую кнопку:");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;

            }
        }
        static double FirstOperand()
        {
            while (true)
            {
                Console.Write("Введите первое значение - ");
                

                if (double.TryParse(Console.ReadLine(), out var operand))
                {
                    Console.Clear();
                    return operand;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
        static double SecondOperand()
        {
            while (true)
            {
                Console.Write("Введите второе значение - ");


                if (double.TryParse(Console.ReadLine(), out var operand))
                {
                    Console.Clear();
                    return operand;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        //Сложение
        static double Sum(double x, double y)
        {
            return x + y;
        }
        //Вычитание
        static double Difference(double x, double y)
        {
            return x + y;
        }
        //Умножение
        static double Multiplication(double x, double y)
        {
            return x * y;
        }
        //Деление
        static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
