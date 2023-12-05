
App app = new App();
app.Main();

class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public int countMax = 0;
    public int countMin = 9;

    public DateTime DateOfBirth { get; set; }
}

class App : User
{
    static List<User> users = new List<User>();
    private User currentUser;
    public void Main()
    {
        while (true)
        {
            if (currentUser == null)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Вход");
                Console.WriteLine("2. Регистрация");
                Console.WriteLine("3. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        Register();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из меню.");
                        break;
                }
            }
            else
            {

                Console.WriteLine("Меню:");
                Console.WriteLine("1. Стартовать новую викторину");
                Console.WriteLine("2. Посмотреть результаты прошлых викторин");
                Console.WriteLine("3. Изменить настройки");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartNewQuiz();
                        break;
                    case "2":
                        ViewQuizResults();
                        break;
                    case "3":
                        ChangeSettings();
                        break;
                    case "4":
                        currentUser = null;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из меню.");
                        break;
                }
            }
        }
    }

    public void Register()
    {
        Console.Write("Введите логин: ");
        string username = Console.ReadLine();

        if (IsUsernameTaken(username))
        {
            Console.WriteLine("Этот логин уже занят. Пожалуйста, выберите другой.");
            return;
        }

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        Console.Write("Введите дату рождения (гггг-мм-дд): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
        {
            Console.WriteLine("Неверный формат даты рождения.");
            return;
        }

        User newUser = new User
        {
            Username = username,
            Password = password,
            DateOfBirth = dateOfBirth
        };

        users.Add(newUser);
        Console.WriteLine("Регистрация успешно завершена!");
    }

    public void Login()
    {
        Console.Write("Введите логин: ");
        string username = Console.ReadLine();

        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        User user = users.Find(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            currentUser = user;
            Console.WriteLine($"Добро пожаловать {username}");
        }
        else
        {
            Console.WriteLine("Неверный логин или пароль.");
        }
    }

    public void StartNewQuiz()
    {
        countMax = 0;
        countMin = 9;
        string result;
        bool numCount = true;


        string BiologyQuestion = "Что изучает ботаника?";
        string BiologyAnswear = "A)Динозавров B)Растения C)Бактерий";
        string BiologyQuestion1 = "Могут ли лягушки жить в солёной воде?";
        string BiologyAnswear1 = "A)Нет B)Да";
        string BiologyQuestion2 = "Чем лечат бактериальную инфекцию у людей?";
        string BiologyAnswear2 = "A)Антибиотками B)Наркотиками C)Алкоголю";

        string GeographyQuestion = "Где находится Бразилия?";
        string GeographyAnswear = "A)Южная Америка B)Азия C)Северная Америка";
        string GeographyQuestion1 = "Какая страна самая большая в мире?";
        string GeographyAnswear1 = "A)Россия B)США C)Австралия";
        string GeographyQuestion2 = "В какой стране находится статуя Свободы?";
        string GeographyAnswear2 = "A)Япония B)Польша C)США";

        string MathQuestion = "Какое следующее простое число после 7?";
        string MathAnswear = "A)17 B)4 C)11";
        string MathQuestion1 = "65 – 43 = ?";
        string MathAnswear1 = "A)1 B)22 C)11";
        string MathQuestion2 = "2 + 2 = ?";
        string MathAnswear2 = "A)5 B)4 C)0";

        if (numCount)
        {
            countMax++;
            countMin--;
            Console.WriteLine(BiologyQuestion);
            Console.WriteLine(BiologyAnswear);
            Console.Write("Ваш ответ: ");
            result = Console.ReadLine();
            if (result == "B" || result == "b")
            {
                countMax++;
                countMin--;
                Console.WriteLine(BiologyQuestion1);
                Console.WriteLine(BiologyAnswear1);
                Console.Write("Ваш ответ: ");
                result = Console.ReadLine();
                if (result == "A" || result == "a")
                {
                    countMax++;
                    countMin--;
                    Console.WriteLine(BiologyQuestion2);
                    Console.WriteLine(BiologyAnswear2);
                    Console.Write("Ваш ответ: ");
                    result = Console.ReadLine();
                    if (result == "A" || result == "a")
                    {
                        countMax++;
                        countMin--;
                        Console.WriteLine(GeographyQuestion);
                        Console.WriteLine(GeographyAnswear);
                        Console.Write("Ваш ответ: ");
                        result = Console.ReadLine();
                        if (result == "A" || result == "a")
                        {
                            countMax++;
                            countMin--;
                            Console.WriteLine(GeographyQuestion1);
                            Console.WriteLine(GeographyAnswear1);
                            Console.Write("Ваш ответ: ");
                            result = Console.ReadLine();
                            if (result == "A" || result == "a")
                            {
                                countMax++;
                                countMin--;
                                Console.WriteLine(GeographyQuestion2);
                                Console.WriteLine(GeographyAnswear2);
                                Console.Write("Ваш ответ: ");
                                result = Console.ReadLine();
                                if (result == "c" || result == "C")
                                {
                                    countMax++;
                                    countMin--;
                                    Console.WriteLine(MathQuestion);
                                    Console.WriteLine(MathAnswear);
                                    Console.Write("Ваш ответ: ");
                                    result = Console.ReadLine();
                                    if (result == "c" || result == "C")
                                    {
                                        countMax++;
                                        countMin--;
                                        Console.WriteLine(MathQuestion1);
                                        Console.WriteLine(MathAnswear1);
                                        Console.Write("Ваш ответ: ");
                                        result = Console.ReadLine();
                                        if (result == "C" || result == "c")
                                        {
                                            countMax++;
                                            countMin--;
                                            Console.WriteLine(MathQuestion2);
                                            Console.WriteLine(MathAnswear2);
                                            Console.Write("Ваш ответ: ");
                                            result = Console.ReadLine();

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    public void ViewQuizResults()
    {
        Console.WriteLine("Результаты прошлых викторин");
        Console.WriteLine($"Количество правильных ответов: {this.countMax}");
        Console.WriteLine($"Количество неправильных ответов: {this.countMin}");
    }

    public void ChangeSettings()
    {
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        User user = users.Find(u => u.Password == password);

        if (user == null)
        {
            Console.WriteLine("Неверный логин или пароль.");
            return;
        }

        Console.Write("Введите новый пароль: ");
        string newPassword = Console.ReadLine();

        user.Password = newPassword;

        Console.Write("Введите дату рождения (гггг-мм-дд): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dateOfBirth))
        {
            Console.WriteLine("Неверный формат даты рождения.");
            return;
        }
    }

    public bool IsUsernameTaken(string username)
    {
        return users.Any(u => u.Username == username);
    }
}