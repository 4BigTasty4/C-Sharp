namespace C__DZ
{
     class Program
    {
        static void Main()
        {

            //1.Даны целые положительные числа A и B(A<B). Вывести все целые нечётные числа от A до B включительно; каждое
            //число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное
            //его значению. Например: если А = 3, а В = 8, то программа
            //должна сформировать в консоли следующий вывод:
            //3 3 3
            //5 5 5 5 5
            //7 7 7 7 7 7 7

            if (false)
            {
                Console.Write("Hello User\n\n");

                Console.Write("Input Number A: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Number B: ");
                int number1 = Convert.ToInt32(Console.ReadLine());

                for (int i = number; i <= number1; i++)
                {
                    if (i % 2 != 0)
                    {
                        for (int x = 1; x <= i; x++)
                        {
                            Console.Write(i);

                            if (x == i)
                                Console.WriteLine();
                                
                                
                        }
                    }
                }
            }

            

            

            //2.Пользователь с клавиатуры вводит длину линии, символ заполнитель, направление линии(горизонтальная,
            //вертикальная).Программа отображает линию по заданным параметрам.
            //Параметры линии: направление: горизонтальная линия,длина: 5, символ: +
            //Вывод: +++++

            if (false)
            {
                Console.Write("Hello User\n\n");

                Console.Write("Input Line Length: ");
                int lineLength = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Line Direction (0 - Horizontal, 1 - Vertical): ");
                int lineDirection = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Line Symbol: ");
                char lineSymbol = Convert.ToChar(Console.ReadLine());

                if (lineDirection == 0)
                {
                    for(int i = 0; i < lineLength; i++)
                    {
                        Console.Write(lineSymbol);
                    }
                }
                else if (lineDirection == 1)
                {
                    for (int i = 0; i < lineLength; i++)
                    {
                        Console.WriteLine(lineSymbol);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR 404");
                }
            }
            

            //3.Пользователь вводит сумму денег и выбирает нужную валюту для конвертации.
            //Программа выводит на экран резуальтат конвертации по выбранному курсу. (AZN, RUB, EURO, USD)

            if (false)
            {

                double result;

                double usd = 1.7;
                double euro = 1.86;
                double gbp = 2.11;

                Console.Write("Hello User\n\n");

                Console.Write($"USD = {usd}, EURO = {euro}, GBP = {gbp}\n\n");

                Console.Write("Input Kurs: ");
                string kurs = Console.ReadLine();

                Console.Write("Input Money: ");
                double input = Convert.ToDouble(Console.ReadLine());

                if (kurs == "USD" || kurs == "Usd" || kurs == "usd")
                {

                    result = input * usd;

                    Console.WriteLine($"Your Money at the Rate USD: {result}");

                }
                else if (kurs == "EURO" || kurs == "Euro" || kurs == "euro")
                {
                    result = input * euro;

                    Console.WriteLine($"Your Money at the Rate EURO: {result}");
                }
                else if (kurs == "GBP" || kurs == "Gbp" || kurs == "gbp")
                {
                    result = input * gbp;

                    Console.WriteLine($"Your Money at the Rate GBP: {result}");
                }
                else
                {
                    Console.WriteLine("ERROR 404");
                }

            }

            
        }
    }
}