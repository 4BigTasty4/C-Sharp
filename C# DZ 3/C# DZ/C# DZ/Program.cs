using System;
using System.Data;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;


// N1

//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без 
//остатка) нужно вывести слово Fizz. Если число кратно 5
//нужно вывести слово Buzz. Если число кратно 3 и 5 нужно 
//вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно 
//вывести само число.
//Если пользователь ввел значение не в диапазоне от 1
//до 100 требуется вывести сообщение об ошибке.



if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Input Number To Diapazon (1 - 100): ");
    double number = double.Parse(Console.ReadLine());

    if (number >= 1 && number <= 100)
    {
        if (number % 3 == 0 && number % 5 == 0)
            Console.WriteLine("Fizz Buzz");
        else if (number % 5 == 0)
            Console.WriteLine("Buzz");
        else if (number % 3 == 0)
            Console.WriteLine("Fizz");
        else if (number % 3 != 0 && number % 5 != 0)
            Console.WriteLine(number);
    }
    else
        Console.WriteLine("Error");
}

// N2

    //Пользователь вводит с клавиатуры два числа. Первое 
    //число — это значение, второе число процент, который 
    //необходимо посчитать. Например, мы ввели с клавиатуры 
    //90 и 10. Требуется вывести на экран 10 процентов от 90. 
    //Результат: 9.

if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Input Number: ");
    double number = double.Parse(Console.ReadLine());
    Console.Write("Enter Percentage: ");
    double percent = double.Parse(Console.ReadLine());

    double result = (percent * number) / 100;

    Console.WriteLine($"Result: {result}");
}

// N3

    //Пользователь вводит с клавиатуры четыре цифры. 
    //Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно 
    //сформировать число 1578.

if (false) 
{
    Console.WriteLine("Hello User");
    Console.Write("Input Number 1: ");
    string firstNumber = Console.ReadLine();
    Console.Write("Input Number 2: ");
    string secondNumber = Console.ReadLine();
    Console.Write("Input Number 3: ");
    string thirdNumber = Console.ReadLine();
    Console.Write("Input Number 4: ");
    string fourthNumber = Console.ReadLine();

    string result = (firstNumber + secondNumber + thirdNumber + fourthNumber);

    Console.WriteLine($"Result: {result}");
}

// N4

    //Пользователь вводит шестизначное число. После чего 
    //пользователь вводит номера разрядов для обмена цифр. 
    //Например, если пользователь ввёл один и шесть — это 
    //значит, что надо обменять местами первую и шестую 
    //цифры.
    //Число 723895 должно превратиться в 523897.
    //Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке
    
if (false)
{
    
}

// N5

    //Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели. 
    //Например, если введено 22.12.2021, приложение должно 
    //отобразить Winter Wednesday

if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Input Date: ");
    string dateInput = Console.ReadLine();

    if (DateTime.TryParse(dateInput,out DateTime date))
    {
        string dateName = date.ToString("");
        string seasonName = GetSeasonName(date.Month);
        Console.WriteLine($"{seasonName} {dateName}");
    }
    else
    {
        Console.WriteLine("Invalid date format");
    }

    static string GetSeasonName(int month) 
    {
        if (month >= 3 && month <= 5)
            return "Spring";
        if (month >= 6 && month <= 8)
            return "Summer";
        if (month >= 9 && month <= 11)
            return "Autumn";

        return "Winter"; 
    }
    
}

// 6 

    //Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора 
    //пользователя программа переводит температуру
    //из Фаренгейта в Цельсий или наоборот.

if (false)
{

    Console.WriteLine("Hello User");
    Console.WriteLine("From Fahrenheit to Celsius ");
    Console.WriteLine("From Celsius to Fahrenheit");
    Console.Write("Input 1 or 2: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fTemp = double.Parse(Console.ReadLine());
        double cTemp = FahrenheitToCelsius(fTemp);
        Console.WriteLine($"Temperature in Celsius: {cTemp}");
    }
    else if (choice == 2) 
    {
        Console.Write("Enter temperature in Celsius: ");
        double cTemp = double.Parse(Console.ReadLine());
        double fTemp = CelsiusToFahrenheit(cTemp);
        Console.WriteLine($"Temperature in Fahrenheit: {fTemp}");
    }
    static double FahrenheitToCelsius(double _fTemp)
    {
        double result = ((_fTemp - 32) * 5 / 9);
        return result;
    }

    static double CelsiusToFahrenheit(double _cTemp)
    {
        double result = ((_cTemp * 9 / 5) + 32);
        return result;
    }
}

// N7

        //Пользователь вводит с клавиатуры два числа. Нужно 
        //показать все четные числа в указанном диапазоне. Если 
        //границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь 
        //ввел 20 и 11, требуется нормализация, после которой 
        //начало диапазона станет равно 11, а конец 20

if (false)
{

    Console.WriteLine("Hello USer");
    Console.Write("Input Start Diapazon: ");
    int start = int.Parse(Console.ReadLine());
    Console.Write("Input End Diapazon: ");
    int end = int.Parse(Console.ReadLine());

    if(start > end)
    {
        int num = start;
        start = end;
        end = num;
    }

    for (int i = start; i < end; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(i);
    }

}

//N1

    //Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.
    //Заполнить одномерный массив 
    //А числами, введенными с клавиатуры пользователем, а 
    //двумерный массив В случайными числами с помощью 
    //циклов. Вывести на экран значения массивов: массива
    //А в одну строку, массива В — в виде матрицы. Найти в 
    //данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее 
    //произведение всех элементов, сумму четных элементов 
    //массива А, сумму нечетных столбцов массива В.

if (false)
{
    Random random = new Random();

    Console.WriteLine("Hello User");

    int[] A = new int[5];
    double[,] B = new double[3,4];

    int height = B.GetLength(0);
    int width = B.GetLength(1);

    Console.WriteLine("Input 5 Elements: ");
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine();

    for (int x = 0; x < height; x++)
    {
        for (int y = 0; y < width; y++)
        {
            B[x, y] = (random.NextDouble() * 10);
        }
    }

    int maxA = A.Max();
    double maxB = B.Cast<double>().Max();

    int minA = A.Min();
    double minB = B.Cast<double>().Min();

    int summA = A.Sum();

    int summEvenA = 0;

    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] % 2 == 0)
        {
            summEvenA += A[i];
        }
    }

    double sumOddB = 0;

    for (int j = 0; j < width; j++)
    {
        if (j % 2 != 0)
        {
            for (int i = 0; i < height; i++)
            {
                sumOddB += B[i, j];
            }
        }
    }

    double summB = 0;
    double prodB = 1;

    for (int x = 0; x < height; x++)
    {
        for (int y = 0; y < width; y++)
        {
            summB += B[x, y];
            prodB *= B[x, y];
        }
    }

    int prodA = 1;

    for (int i = 0; i < A.Length; i++)
    {
        prodA *= A[i];

        Console.WriteLine(A[i]);
    }

    Console.WriteLine();

    for (int x = 0; x < height; x++)
    {
        for (int y = 0; y < width; y++)
        {
            Console.WriteLine(B[x,y] + "\t");
        }
    }

    Console.WriteLine();

    Console.WriteLine($"Massive A Max and Min Elemnet: {maxA} {minA}");
    Console.WriteLine($"Massive Max and Min Elemnet: {maxB} {minB}");
    Console.WriteLine($"Massive A General Production and Summa: {prodA} {summA}");
    Console.WriteLine($"Massive B General Production and Summa: {prodB} {summB}");
    Console.WriteLine($"Massive A Sum of Even numbers: {summEvenA}");
    Console.WriteLine($"Massive B Sum of Odd Columns: {sumOddB}");
}

// N2

//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных 
//между минимальным и максимальным элементами.

if (false)
{
    Console.WriteLine("Hello User" + "\n");

    Random random = new Random();

    int summ = 0;

    int[,] massive = new int[5, 5];

    int massiveHeight = massive.GetLength(0);
    int massiveWidth = massive.GetLength(1);

    for (int x = 0; x < massiveHeight; x++)
    {
        for (int y = 0; y < massiveWidth; y++)
        {
            massive[x, y] = random.Next(-100, 100);
        }
    }

    int minVallue = massive[0, 0];
    int maxVallue = massive[0, 0];

    for (int x = 0; x < massiveHeight; x++)
    {
        for (int y = 0; y < massiveWidth; y++)
        {
            if (massive[x, y] < minVallue)
                minVallue = massive[x, y];
            if (massive[x, y] > maxVallue)
                maxVallue = massive[x, y];
        }
    }

    for (int i = minVallue; i < maxVallue; i++)
    {
        summ += i;
    }

    Console.WriteLine($"Result: {summ}");
}

// N4

    //Создайте приложение, которое производит операции 
    //над матрицами:
    //■ Умножение матрицы на число;
    //■ Сложение матриц;
    //■ Произведение матриц.

if (false)
{
    Random random = new();

    Console.WriteLine("Hello User");
    Console.Write("Enter the Number to Multiply: ");
    int multi = int.Parse(Console.ReadLine());

    int firstListResult = multi;
    int secodListResult = multi;

    int[,] firstList = new int[3,3];
    int[,] secondList = new int[3,3];

    int firstHeight = firstList.GetLength(0);
    int firstWidth = firstList.GetLength(1);

    int secondHeight = secondList.GetLength(0);
    int secondWidth = secondList.GetLength(1);

    for (int x = 0; x < firstHeight; x++)
    {
        for (int y = 0; y < firstWidth; y++)
        {
            firstList[x,y] = random.Next(1,5);
        }
    }

    for (int x = 0; x < secondHeight; x++)
    {
        for (int y = 0; y < secondWidth; y++)
        {
            secondList[x, y] = random.Next(1, 5);
        }
    }

    for (int x = 0; x < firstHeight; x++)
    {
        for (int y = 0; y < firstWidth; y++)
        {
            firstListResult *= firstList[x, y];
        }
    }

    for (int x = 0; x < secondHeight; x++)
    {
        for (int y = 0; y < secondWidth; y++)
        {
            secodListResult *= secondList[x, y];
        }
    }

    for (int x = 0; x < firstHeight; x++)
    {
        for (int y = 0; y < firstWidth; y++)
        {
            Console.WriteLine($"Matrix Addition: {firstList[x, y] + secondList[x, y]}");
        }
    }

    for (int x = 0; x < firstHeight; x++)
    {
        for (int y = 0; y < firstWidth; y++)
        {
            Console.WriteLine($"Matrix Multiplication: {firstList[x, y] * secondList[x, y]}");
        }
    }

    Console.WriteLine($"Addition of Matrices by Number: {firstListResult} {secodListResult}");

}

// N5

//Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
//его результат. Необходимо поддерживать только две 
//операции: + и –.

if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Enter an Arithmetic Expression: ");
    string num = Console.ReadLine();

    string[] result = num.Split('+', '-');

    if (result.Length != 2)
        Console.WriteLine("Error");

    double firstOperand = double.Parse(result[0]);
    double secondOperand = double.Parse(result[1]);

    if (num.Contains("+"))
        Console.WriteLine($"Result: {firstOperand + secondOperand}");
    else if (num.Contains("-"))
        Console.WriteLine($"Result: {firstOperand - secondOperand}");
    else
        Console.WriteLine("Error");
}

// N6

    //Пользователь с клавиатуры вводит некоторый текст. 
    //Приложение должно изменять регистр первой буквы 
    //каждого предложения на букву в верхнем регистре

if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Input Text: ");
    string inputText = Console.ReadLine();

    //string convertedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputText);
    //Console.Write("Result:\n" + convertedText);

    //TextInfo text = CultureInfo.CurrentCulture.TextInfo;
    //Console.WriteLine("Result: " + text.ToTitleCase(inputText));

    TextInfo text = new CultureInfo(1,false).TextInfo;
    Console.WriteLine("Result: " + text.ToTitleCase(inputText));
}

// N1

//Напишите метод, который отображает квадрат из 
//некоторого символа. Метод принимает в качестве параметра: длину стороны квадрата, символ.


if (false)
{
    Console.WriteLine("Hello User");
    Console.Write("Input Square Length: ");
    int squareLenght = int.Parse(Console.ReadLine());
    Console.Write("Input Square Symbol: ");
    char squareSymbol = char.Parse(Console.ReadLine());

    SquareDrow(squareSymbol, squareLenght);

    static void SquareDrow(char symbol, int lenght)
    {
        for (int x = 0; x < lenght; x++)
        {
            for (int y = 0; y < lenght; y++)
            {
                Console.Write(symbol); 
            }
            Console.WriteLine();

        }
    }
};

// N2

    //Напишите метод, который проверяет является ли 
    //переданное число «палиндромом». Число передаётся в 
    //качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
    //Палиндром — число, которое читается одинаково как 
    //справа налево, так и слева направо. Например:
    //1221 — палиндром;
    //3443 — палиндром;
    //7854 — не палиндром

if (false)
{

    Console.WriteLine("Hello User");
    Console.Write("Input number: ");

    string number = Console.ReadLine();

    int lenght = number.Length;

    if (number.Length != 4)
    {
        Console.WriteLine("Error");
    }
    else
    {
        char[] polidList = new char[lenght];

        Polindrom(number, lenght, polidList);
    }

    static void Polindrom(string _number, int _lenght , char[] _polidList) 
    {
        for (int i = 0; i < _lenght; i++)
        {
            _polidList[i] = _number[i];
        }

        if (_polidList[0] != _polidList[3] || _polidList[1] != _polidList[2])
            Console.WriteLine("Error");
        else
        {
            Console.WriteLine("Correct: ");
            foreach (var item in _number)
            {
                Console.WriteLine(item);
            }
        }

    }
}

// N3

    //Напишите метод, фильтрующий массив на основании 
    //переданных параметров. Метод принимает параметры: 
    //оригинальный_массив, массив_с_данными_для_фильтрации.
    //ДОМАШНЕЕ ЗАДАНИЕ
    //1
    //Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
    //Например:
    //1 2 6 - 1 88 7 6 — оригинальный массив;
    //6 88 7 — массив для фильтрации;
    //1 2 - 1 — результат работы метода.

if (false)
{
    int[] firstList = { 1, 2, 3, 4};
    int[] secondList = { 3, 4 };

    int[] filteredArray = FilterArray(firstList, secondList);

    for (int i = 0; i < secondList.Length; i++)
    {
        Console.WriteLine(secondList[i]);
    }

    static int[] FilterArray(int[] _firstList, int[] _secondList)
    {
        int[] resultList = new int[_firstList.Length];
        int resultIndex = 0;

        foreach (int item in _firstList)
        {
            bool foundInFilterArray = false;

            foreach (int filterItem in _secondList)
            {
                if (item == filterItem)
                {
                    foundInFilterArray = true;
                    break;
                }
            }

            if (!foundInFilterArray)
            {
                resultList[resultIndex] = item;
                resultIndex++;
            }
        }

        // Создаем новый массив с размером resultIndex для учета только реальных элементов
        int[] finalResult = new int[resultIndex];
        Array.Copy(resultList, finalResult, resultIndex);

        return finalResult;
    }
}

// N4

//Создайте класс «Веб-сайт». Необходимо хранить в 
//полях класса: название сайта, путь к сайту, описание 
//сайта, ip адрес сайта. Реализуйте методы класса для ввода 
//данных, вывода данных, реализуйте доступ к отдельным 
//полям через методы класса.

if (false)
{
    WebSite web = new();
     
    web.InputInfo();
    web.ShowSite();
}

//N5
    
    //Создайте класс «Журнал». Необходимо хранить в 
    //полях класса: название журнала, год основания, описание журнала, контактный телефон, контактный e-mail. 
    //Реализуйте методы класса для ввода данных, вывода 
    //данных, реализуйте доступ к отдельным полям через 
    //методы класса

    //Ранее в одном из практических заданий вы создавали
    //класс «Журнал». Добавьте к уже созданному классу информацию о количестве сотрудников. Выполните перегрузку
    //+ (для увеличения количества сотрудников на указанную
    //величину), — (для уменьшения количества сотрудников
    //на указанную величину), == (проверка на равенство количества сотрудников), < и > (проверка на меньше или
    //больше количества сотрудников), != и Equals.Используйте
    //механизм свойств для полей класса.

if (false)
{
    Jurnal jurnal = new();

    jurnal.InfoInput();
    jurnal.Show();
}

//N6

    //Создайте класс «Магазин». Необходимо хранить в 
    //полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail. 
    //Реализуйте методы класса для ввода данных, вывода 
    //данных, реализуйте доступ к отдельным полям через 
    //методы класса.

if (false)
{
    string name;
    Magazine magaz = new();
    magaz.MagazInfoInput();
    magaz.Show();
}

//N2

    //Пользователь вводит словами цифру от 0 до 9. Приложение должно перевести слово в цифру. Например, если
    //пользователь ввёл five, приложение должно вывести на
    //экран 5.

if (false)
{
    ConvertTonumber num = new();
    num.Show();
}


//N3

    //Создайте класс «Заграничный паспорт». Вам необходимо 
    //хранить информацию о номере паспорта, ФИО владельца,
    //дате выдачи и т.д. Предусмотреть механизмы для инициализации полей класса. Если значение для инициализации 
    //неверное, генерируйте исключение.


if (false)
{
    Pasport pasport = new();
    Console.WriteLine("Hello User");
    Console.Write("Input Paport Number: ");
    string name = Console.ReadLine();
    Console.Write("Input Owner Full Name: ");
    string OwnerFullName = Console.ReadLine();
    Console.Write("Input Date Of Issue: ");
    DateTime dateTime = new();
    dateTime.ToString(Console.ReadLine());

    pasport.PasportInfo(name, OwnerFullName, dateTime);
    pasport.InfoError(name, OwnerFullName, dateTime);
    
}

//N4

    //Пользователь вводит в строку с клавиатуры логическое
    //выражение. Например, 3>2 или 7<3. Программа должна
    //посчитать результат введенного выражения и дать результат true или false. В строке могут быть только целые числа
    //и операторы: <, >, <=, >=, ==, !=.Для обработки ошибок
    //ввода используйте механизм исключений.

if (false)
{
    LogicOperation number = new();
    number.Show();
    
    

}


//N1 

    //Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
    //В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле
    //для хранения копеек (центы, евроценты, копейки и т.д.).
    //Реализовать методы для вывода суммы на экран, задания значений для частей.
    //На базе класса Money создать класс Product для работы
    //с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
    //Для каждого из классов реализовать необходимые
    //методы и поля.

if (false)
{
    Money money = new Money(13,45);
    Product product = new Product("Bambuk", money);
    money.Show();
    product.ReducePrice(7, 35);
    money.Show();
}

//N2

    //Создать базовый класс «Устройство» и производные
    //классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого
    //устройства и его характеристики.
    //Реализуйте для каждого из классов методы:
    //■ Sound — издает звук устройства (пишем текстом в
    //консоль);
    //■ Show — отображает название устройства;
    //■ Desc — отображает описание устройства.

if (true)
{
    Device device = new Device("Общее устройство");
    Kettle kettle = new Kettle("Чайник", "Объем: 1.5 литра, мощность: 1500 Вт");
    Microwave microwave = new Microwave("Микроволновка", "Мощность: 1000 Вт, объем: 20 литров");
    Auto auto = new Auto("Автомобиль", "Скорость: 200 км/ч, марка: Toyota");
    Steamship steamship = new Steamship("Пароход", "Вместимость: 200 пассажиров, мощность: 3000 л.с.");

    device.Show();
    device.Sound();
    device.Description();

    kettle.Show();
    kettle.Sound();
    kettle.Description();

    microwave.Show();
    microwave.Sound();
    microwave.Description();

    auto.Show();
    auto.Sound();
    auto.Description();

    steamship.Show();
    steamship.Sound();
    steamship.Description();
}

class Device
{
    private string name;

    public Device(string name)
    {
        this.name = name;
    }

    public void Show()
    {
        Console.WriteLine($"Device Name: {name}");
    }

    public void Sound()
    {
        Console.WriteLine($"Device {name} makes a sound");
    }

    public virtual void Description()
    {
        Console.WriteLine($"Device Description: {name}");
    }
}

class Kettle : Device
{

    public string description {get; set;}

    public Kettle(string name, string _description) : base(name)
    {
        description = _description;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"This kettle has the following characteristics: {description}");
    }
}

class Microwave : Device
{

    public string description { get; set; }

    public Microwave(string name, string _description) : base(name)
    {
        description = _description;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"This microwave has the following characteristics: {description}");
    }

}

class Auto : Device
{
    public string description { get; set; }

    public Auto(string name ,string _description) : base(name)
    {
        description = _description;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($" This car has the following characteristics: {description}");
    }
}

class Steamship : Device
{

    public string description { get; set; }

    public Steamship(string name, string _description) : base(name)
    {
        description = _description;
    }

    public override void Description()
    {
        base.Description();
        Console.WriteLine($"This steamer has the following characteristics: {description}");
    }
}

class Money
{
    public int Dollars { get; set; }
    public int Cent { get; set; }

    public Money(int dollars, int cent)
    {
        this.Dollars = dollars;
        this.Cent = cent;
    }

    public void Show()
    {
        Console.WriteLine($"Price: Dollar: {Dollars} Cent: {Cent}");
    }
}

class Product
{
    private string Name { get; set; }
    private Money Price { get; set; }

    public Product(string name, Money price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void ReducePrice(int reductionDollars, int reductionCents)
    {
        int totalCents = (Price.Dollars  * 100 + Price.Cent) - (reductionDollars * 100 + reductionCents);

        if (totalCents >= 0)
        {
            Price.Dollars = totalCents / 100;
            Price.Cent = totalCents % 100;
        }
        else
        {
            throw new ArgumentException("Снижение цены на продукт невозможно.");
        }
    }
}

class Pasport
{
    private string PassportNumber { get; set; }
    private string OwnerName { get; set; }
    private DateTime PasportData { get; set; }

    public void PasportInfo(string _passportNumber, string _ownerName, DateTime _pasportData)
    {
        this.PassportNumber = _passportNumber;
        this.OwnerName = _ownerName;
        this.PasportData = _pasportData;
    }

    public void InfoError(string _passportNumber, string _ownerName, DateTime _pasportData)
    {
        if (string.IsNullOrWhiteSpace(_passportNumber) || _passportNumber.Length != 9)
            throw new ArgumentException("Invalid passport number.");
        if (string.IsNullOrWhiteSpace(_ownerName))
            throw new ArgumentException("Incorrect owner name.");
        if (_pasportData > DateTime.Now)
            throw new ArgumentException("Incorrect issue date.");
        else
            Show();
    }

    public void Show()
    {
        Console.WriteLine($"Pasport Number: {this.PassportNumber}");
        Console.WriteLine($"Owner Full Name: {this.OwnerName}");
        Console.WriteLine($"Date Of Issue: {this.PasportData.ToShortDateString()}");
    }

}

class LogicOperation
{

    public string logicOperation;

    public bool Operationresult(string _logicOperation)
    {
        string[] operators = { "<", ">", "<=", ">=", "==", "!=" };
        string[] nums = _logicOperation.Split(' ');

        if (nums.Length != 3 || Array.IndexOf(operators, nums[1]) == -1)
        {
            throw new FormatException("Invalid expression format");
        }

        int firstNum = int.Parse(nums[0]);
        string operd = nums[1];
        int secondNum = int.Parse(nums[2]);

        switch (operd)
        {
            case "<":
                return firstNum < secondNum;
            case ">":
                return firstNum > secondNum;
            case "<=":
                return firstNum <= secondNum;
            case ">=":
                return firstNum >= secondNum;
            case "==":
                return firstNum == secondNum;
            case "!=":
                return firstNum != secondNum;
            default:
                throw new InvalidOperationException("Unsupported operator");
        }

    }

    public void Show()
    {
        Console.WriteLine("Hello User");
        Console.Write("Input Logic Operation: ");
        this.logicOperation = Console.ReadLine();
        Operationresult(this.logicOperation);
    }
}

class ConvertTonumber
{

    private string number;

    public string StringToNumber()
    {
        
            switch (this.number)
            {
                case "zero":
                    Console.WriteLine(0);
                    break;
                case "one":
                    Console.WriteLine(1);
                    break;
                case "two":
                    Console.WriteLine(2);
                    break;
                case "three":
                    Console.WriteLine(3);
                    break;
                case "four":
                    Console.WriteLine(4);
                    break;
                case "five":
                    Console.WriteLine(5);
                    break;
                case "six":
                    Console.WriteLine(6);
                    break;
                case "seven":
                    Console.WriteLine(7);
                    break;
                case "eight":
                    Console.WriteLine(8);
                    break;
                case "nine":
                    Console.WriteLine(9);
                    break;
            }
        
        return this.number;
    }

    public void Show()
    {
        Console.WriteLine("Hello World");
        Console.Write("input Number: ");
        this.number = Console.ReadLine();
        if (this.number.Length < 3)
            Console.WriteLine("Enter Using Words");
        else
            StringToNumber();
    }

}

class Magazine
{
    private string magazName;
    private string magazAdres;
    private string magazDescription;
    private string magazKontakt;
    private string magazMail;

    public void MagazInfoInput()
    {
        Console.Write("Input Magazine Name: ");
        this.magazName = Console.ReadLine();
        Console.Write("Input Magazine Adress: ");
        this.magazAdres = Console.ReadLine();
        Console.Write("Input Magazine Profile: ");
        this.magazDescription = Console.ReadLine();
        Console.WriteLine("Input Magazine Kontakt: ");
        this.magazKontakt = Console.ReadLine();
        Console.WriteLine("Input Magazine Mail: ");
        this.magazMail = Console.ReadLine();
    }

    public string MagazName { get; set; }
    public string MagazAdres { get; set; }
    public string MagazDescription {get; set; }
    public string MagazKontakt { get; set; }
    public string MagnazMail { get; set; }

    public void Show()
    {
        Console.WriteLine($"Magazine Name: {this.magazName}");
        Console.WriteLine($"Magazine Adress: {this.magazAdres}");
        Console.WriteLine($"Magazine Profile: {this.magazDescription}");
        Console.WriteLine($"Magazine Kontakt: {this.magazKontakt}");
        Console.WriteLine($"Magazine Mail: {this.magazMail}");
    }
}

class Jurnal
{
    public int jurnalWorker = 5;
    public int AddWorker;
    private string jurnalName;
    private string jurnalYear;
    private string jurnalDescription;
    private string jurnalMobile;
    private string jurnalMail;
    

    public void InfoInput()
    {
        Console.Write("Input Jurnal Name: ");
        this.jurnalName = Console.ReadLine();
        Console.Write("Input Jurnal Year: ");
        this.jurnalYear = Console.ReadLine();
        Console.Write("Input Jurnal Description: ");
        this.JurnalDescription = Console.ReadLine();
        Console.Write("Input Jurnal Mobile: ");
        this.jurnalMobile = Console.ReadLine();
        Console.Write("Input Jurnal Mail: ");
        this.jurnalMail = Console.ReadLine();
        Console.Write($"Default: {this.jurnalWorker} How Many Workers to Add: ");
        this.AddWorker = int.Parse(Console.ReadLine());

        //return $"Jurnal is: {this.jurnalName.ToString()}";
    }

    public string JurnalName { get; set; }
    public string JurnalYear { get; set; }
    public string JurnalDescription { get; set; }
    public string JurnalMobile { get; set; }
    public string JurnalMail { get; set; }

    //public static Jurnal operator +(Jurnal _AddWorker , Jurnal _jurnalWorker)
    //{
        

    //    Jurnal jurnal = new Jurnal();
    //    _jurnalWorker.jurnalWorker += _AddWorker.AddWorker;
        
    //}
        

    public void Show()
    {
        Console.WriteLine($"Jurnal Name: {this.jurnalName}");
        Console.WriteLine($"Jurnal Year: {this.jurnalYear}");
        Console.WriteLine($"Jurnal Description: {this.jurnalDescription}");
        Console.WriteLine($"Jurnal Mobile: {this.jurnalMobile}");
        Console.WriteLine($"Jurnal Mail: {this.jurnalMail}");
        Console.WriteLine($"Worker: {jurnalWorker}");
    }
}

class WebSite
{
    private string siteName;
    private string siteUrl;
    private string description;
    private string siteIp;

    public void InputInfo()
    {
        Console.Write("Input Site Name: ");
        this.siteName = Console.ReadLine();
        Console.Write("Input Site Url: ");
        this.siteUrl = Console.ReadLine();
        Console.Write("Input Site Description: ");
        this.description = Console.ReadLine();
        Console.Write("Input Site Ip: ");
        this.siteIp = Console.ReadLine();
    }

    public string SiteName { get; set; }
    public string SiteUrl { get; set; }
    public string SiteDescriptoin { get; set; }
    public string SiteIp { get; set; }

    public void ShowSite()
    {
        Console.WriteLine($"Site Name: {this.siteName}");
        Console.WriteLine($"Site Url: {this.siteUrl}");
        Console.WriteLine($"Site Description: {this.description}");
        Console.WriteLine($"Site Ip: {this.siteIp}");
    }

}