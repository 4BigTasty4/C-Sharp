namespace C__YouTube
{
    class Program
    {
        static void PrintLine(char _symbol, int _diapazon)
        {
            for (int i = 0; i < _diapazon; i++)
            {
                Console.Write(_symbol);
            }
        }

        static int[] GetRandomMassive(uint _lenght,int minimum,int maximum) 
        {
            Random random = new Random();

            int[] lists = new int[_lenght];

            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = random.Next(minimum, maximum);
            }
            return lists;
        }

        static int GetMassiveIndex(int[] _massive, int index)
        {
            for (int i = 0; i < _massive.Length; i++)
            {
                if (_massive[i] == index)
                {
                    return i;
                }
            }

            return 0;
        }

        static void ReSize(ref int[] _massive, int newSize)
        {
            int[] newMassive = new int[newSize];

            for (int i = 0; i < _massive.Length && i < newMassive.Length; i++)
            {
                newMassive[i] = _massive[i];
            }
            _massive = newMassive;
        }

        static void Insert(ref int[] _massive,int vallue, int index)
        
        
        
        {
            int[] NewMassive = new int[_massive.Length + 1];

            NewMassive[index] = vallue;

            for (int i = 0; i < index; i++)
                NewMassive[i] = _massive[i];

            for (int i = index; i < _massive.Length; i++)
                NewMassive[i + 1] = _massive[i];

            _massive = NewMassive;
        }

        static void Main()
        {
            if (false)
            {
                string str;
                int a, b, result;

                Console.WriteLine("Input Number1: ");
                str = Console.ReadLine();
                a = Convert.ToInt32(str);
                Console.WriteLine("Input Number 2: ");
                str = Console.ReadLine();
                b = Convert.ToInt32(str);

                result = a + b;

                Console.WriteLine("Summa: " + result);
            }

            if (false)
            {
                double number, num, result;

                Console.WriteLine("Hello User");
                Console.Write("Input Number 1: ");
                number = double.Parse(Console.ReadLine());
                Console.Write("Input Number 2: ");
                num = double.Parse(Console.ReadLine());
                result = (num + number) / 2;
                Console.WriteLine("Finish: " + result);

                double first, second, thirty, summResult, multResult;

                Console.WriteLine("Hello User");
                Console.Write("Input First Number: ");
                first = double.Parse(Console.ReadLine());
                Console.Write("Input Second Number: ");
                second = double.Parse(Console.ReadLine());
                Console.Write("Input Thirty Number: ");
                thirty = Convert.ToDouble(Console.ReadLine());
                summResult = first + second + thirty;
                multResult = first * second * thirty;
                Console.WriteLine("Summa: " + summResult + " Power: " + multResult);

                //double USD, EURO, number;

                //USD = 1.7;
                //EURO = 1.8;

                //Console.WriteLine("Hello User");
                //Console.Write("Input Your Money In TL: ");
                //number = double.Parse(Console.ReadLine());
                //Console.WriteLine("Your Money In USD: " + number * USD + " In EURO: " + number * EURO);
            }

            if (false)
            {
                int number;

                Console.WriteLine("Hello World");
                Console.Write("Input Number: ");      
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Correct Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is not Even!");
                }
                
            }

            if (false)
            {

                //double firstNumber, secondNumber, result;
                //string arithmeticOperation;

                //Console.WriteLine("Hello User");
                //Console.Write("Input Number 1: ");
                //firstNumber = double.Parse(Console.ReadLine());
                //Console.Write("Input Number 2: ");
                //secondNumber = double.Parse(Console.ReadLine());
                //Console.Write("Input Arithmetic Operation (+,-,/,*): ");
                //arithmeticOperation = Console.ReadLine();

                //if (arithmeticOperation == "+") 
                //{
                //    result = firstNumber + secondNumber;
                //    Console.WriteLine("Summa: " + result);
                //}
                //else if (arithmeticOperation == "-")
                //{
                //    result = firstNumber - secondNumber;
                //    Console.WriteLine("Difference: " + result);
                //}
                //else if (arithmeticOperation == "/")
                //{
                //    result = firstNumber / secondNumber;
                //    Console.WriteLine("Division: " + result);
                //}
                //else if (arithmeticOperation == "*")
                //{
                //    result = firstNumber * secondNumber;
                //    Console.WriteLine("Multiplication: " + result);
                //}
                //else
                //{
                //    Console.WriteLine("Error");
                //}

                while (true)
                {
                    Console.Clear();

                    double firstNumber, secondNumber, result;
                    string arithmeticOperation;

                    Console.WriteLine("Hello User");

                    try
                    {                     
                        Console.Write("Input Number 1: ");
                        firstNumber = double.Parse(Console.ReadLine());
                        Console.Write("Input Number 2: ");
                        secondNumber = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Not Reshaped");
                        Console.ReadLine();
                        continue;
                    }

                    Console.Write("Input Arithmetic Operation (+,-,/,*): ");
                    arithmeticOperation = Console.ReadLine();

                    switch (arithmeticOperation)
                    {

                        case "+":
                            result = firstNumber + secondNumber;
                            Console.WriteLine("Summa: " + result);
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            Console.WriteLine("Difference: " + result);
                            break;
                        case "/":
                            if (firstNumber == 0 && secondNumber == 0)
                            {
                                Console.WriteLine(0);
                            }
                            else
                            {
                                result = firstNumber / secondNumber;
                                Console.WriteLine("Division: " + result);
                            }
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            Console.WriteLine("Multiplication: " + result);
                            break;
                        default:
                            Console.WriteLine("Error!");
                            break;
                    }
                    Console.ReadLine();
                }
            }

            if (false)
            {
                uint oddNumbersCount = 0;
                uint evenNumbersCount = 0;

                int evenNumbersSumm = 0;
                int oddNumberSumm = 0;

                int start,end;

                Console.WriteLine("Hello User");
                Console.Write("Input Start Diapazon: ");
                start = int.Parse(Console.ReadLine());
                Console.Write("Input End Diapazon: ");
                end = int.Parse(Console.ReadLine());

                while (start <= end)
                {
                    if (start % 2 == 0)
                    {
                        evenNumbersCount++;
                        evenNumbersSumm += start;
                    }
                    else
                    {
                        oddNumbersCount++; 
                        oddNumberSumm += start;
                    }
                    start++;
                }
                Console.WriteLine("Even Number: " + evenNumbersCount);
                Console.WriteLine("Odd Number: " + oddNumbersCount);
                Console.WriteLine("Even Summ: " + evenNumbersSumm);
                Console.WriteLine("Odd Summ: " + oddNumberSumm);
            }

            if (false)
            {

                int height;

                //Console.WriteLine("Hello User");
                //Console.Write("Input Height: ");
                //height = int.Parse(Console.ReadLine());
                //Console.Write("Input Weight: ");
                //weight = int.Parse(Console.ReadLine());

                char symbol = '@';

                for (int x = 0; x < 1; x++)
                {
                    for (int y = 1; y <= 5; y++)
                    {
                        
                        Console.WriteLine(symbol);
                    }

                    
                }

            }

            if (false)
            {
                Console.WriteLine("Hello World");
                Console.Write("Input Massive Lenght: ");
                int massibeLenght = int.Parse(Console.ReadLine());
                int[] lists = new int[massibeLenght];
                Console.WriteLine("Input Massive Elements: ");
                for (int i = 0; i < lists.Length; i++)
                {
                    lists[i] = int.Parse(Console.ReadLine());
                } 
            }

            if (false)
            {
                Console.WriteLine("Hello User");
                Console.Write("Input Massive Lenght: ");
                int massiveLenght = int.Parse(Console.ReadLine());
                int[] massive = new int[massiveLenght];

                for (int i = 0; i < massive.Length; i++)
                {
                    massive[i] = int.Parse(Console.ReadLine());
                }

                for (int i = massive.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(massive[i]);
                }
            }

            if (false)
            {
                Console.WriteLine("Hello User");
                Console.Write("Input Massive Lenght: ");

                int massiveLenght = int.Parse(Console.ReadLine());
                int[] nums = new int[massiveLenght];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i]= int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.WriteLine($"Even Numbers: {nums[i]}");
                    }
                }
            }

            if (false)
            {
                Console.WriteLine("Hello World");
                Console.Write("Input Massive Lenght: ");

                int massiveLenght = int.Parse(Console.ReadLine());

                int[] myMassive = new int[massiveLenght]; 

                for (int i = 0; i < myMassive.Length; i++)
                {
                    myMassive[i] = int.Parse(Console.ReadLine());
                }

                int result = myMassive[0];

                for (int i = 0; i < myMassive.Length; i++)
                {
                    if (myMassive[i] <= result)
                    {
                        result = myMassive[i];
                    }
                }
                Console.WriteLine($"Smallest Number: {result}");
            }

            if (false)
            {
                Console.WriteLine("Hello User" + "\n");

                int[,] MyMassive = new int[4, 6];

                Random random = new Random();

                int height = MyMassive.GetLength(0);
                int width = MyMassive.GetLength(1);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        MyMassive[y,x] = random.Next();
                    }
                }

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(MyMassive[y,x] + "\t");
                    }
                    Console.WriteLine();
                }
               
            }

            if (false)
            {
                Console.WriteLine("Hello User" + "\n");

                int[,] massive = new int[3, 4];

                int height = massive.GetLength(0);
                int width = massive.GetLength(1);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.WriteLine($"Y:{y} X:{x}");
                        massive[y,x] = int.Parse(Console.ReadLine());
                    }
                }

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(massive[y,x]);
                    }
                    Console.WriteLine();
                }

            }

            if (false)
            {
                Random random = new Random();

                int[][] massive = new int[4][];

                massive[0] = new int[5];
                massive[1] = new int[2];
                massive[2] = new int[3];
                massive[3] = new int[10];

                for (int i = 0; i < massive.Length; i++)
                {
                    for (int x = 0; x < massive[i].Length; x++)
                    {
                        massive[i][x] = random.Next(100);
                    }
                }

                for (int i = 0; i < massive.Length; i++)
                {
                    for (int x = 0; x < massive[i].Length; x++)
                    {
                        Console.Write(massive[i][x] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            if (false)
            {
                Console.WriteLine("Hello User");
                Console.Write("Input Symbol: ");
                char symbol = char.Parse(Console.ReadLine());
                Console.Write("Input Diapazon: ");
                int diapazon = int.Parse(Console.ReadLine());
                
                PrintLine(symbol, diapazon);
            }

            if (false)
            {
                Console.WriteLine("Hello User");
                Console.Write("Input Index: ");
                int index = int.Parse(Console.ReadLine());
                int[] massive = GetRandomMassive(3, 4, 8);

                int result = GetMassiveIndex(massive, index);

                Console.WriteLine(result);
            }

            if (false)
            {
                Console.WriteLine("Hello User");

                int[] massive = { 1, 2, 3, 4 };
                
                ReSize(ref massive,10);
            }

            if (true)
            {
                Console.WriteLine("Hello User");

                int[] massive = { 1, 2, 3, 4, };
                
                Insert(ref massive, 5, 2);
            }

         }

    }

}