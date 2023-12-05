
//N1

//Money money = new Money(13, 45);
//Product product = new Product("Bambuk", money);
//money.Show();
//product.ReducePrice(7, 35);
//money.Show();

//class Money
//{
//    public int Dollars { get; set; }
//    public int Cent { get; set; }

//    public Money(int dollars, int cent)
//    {
//        this.Dollars = dollars;
//        this.Cent = cent;
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Price: Dollar: {Dollars} Cent: {Cent}");
//    }
//}

//class Product
//{
//    private string Name { get; set; }
//    private Money Price { get; set; }

//    public Product(string name, Money price)
//    {
//        this.Name = name;
//        this.Price = price;
//    }

//    public void ReducePrice(int reductionDollars, int reductionCents)
//    {
//        int totalCents = (Price.Dollars  * 100 + Price.Cent) - (reductionDollars * 100 + reductionCents);

//        if (totalCents >= 0)
//        {
//            Price.Dollars = totalCents / 100;
//            Price.Cent = totalCents % 100;
//        }
//        else
//        {
//            throw new ArgumentException("Снижение цены на продукт невозможно.");
//        }
//    }
//}


//N2

//Создать базовый класс «Устройство» и производные
//классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого
//устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//Sound — издает звук устройства (пишем текстом в
//консоль);
//Show — отображает название устройства;
//Desc — отображает описание устройства.

// Device device = new Device("Общее устройство");
// Kettle kettle = new Kettle("Чайник", "Объем: 1.5 литра, мощность: 1500 Вт");
// Microwave microwave = new Microwave("Микроволновка", "Мощность: 1000 Вт, объем: 20 литров");
// Auto auto = new Auto("Автомобиль", "Скорость: 200 км/ч, марка: Toyota");
// Steamship steamship = new Steamship("Пароход", "Вместимость: 200 пассажиров, мощность: 3000 л.с.");
// device.Show();
// device.Sound();
// device.Description();
// kettle.Show();
// kettle.Sound();
// kettle.Description();
// microwave.Show();
// microwave.Sound();
// microwave.Description();
// auto.Show();
// auto.Sound();
// auto.Description();
// steamship.Show();
// steamship.Sound();
// steamship.Description();

//class Device
//{
//    private string name;

//    public Device(string name)
//    {
//        this.name = name;
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Device Name: {name}");
//    }

//    public void Sound()
//    {
//        Console.WriteLine($"Device {name} makes a sound");
//    }

//    public virtual void Description()
//    {
//        Console.WriteLine($"Device Description: {name}");
//    }
//}

//class Kettle : Device
//{

//    public string description {get; set;}

//    public Kettle(string name, string _description) : base(name)
//    {
//        description = _description;
//    }

//    public override void Description()
//    {
//        base.Description();
//        Console.WriteLine($"This kettle has the following characteristics: {description}");
//    }
//}

//class Microwave : Device
//{

//    public string description { get; set; }

//    public Microwave(string name, string _description) : base(name)
//    {
//        description = _description;
//    }

//    public override void Description()
//    {
//        base.Description();
//        Console.WriteLine($"This microwave has the following characteristics: {description}");
//    }

//}

//class Auto : Device
//{
//    public string description { get; set; }

//    public Auto(string name ,string _description) : base(name)
//    {
//        description = _description;
//    }

//    public override void Description()
//    {
//        base.Description();
//        Console.WriteLine($" This car has the following characteristics: {description}");
//    }
//}

//class Steamship : Device
//{

//    public string description { get; set; }

//    public Steamship(string name, string _description) : base(name)
//    {
//        description = _description;
//    }

//    public override void Description()
//    {
//        base.Description();
//        Console.WriteLine($"This steamer has the following characteristics: {description}");
//    }
//}


//N3

//MusicalInstrument violin = new Violin("Violin", "String musical instrument", "The violin was developed in the 16th century");
//MusicalInstrument trombone = new Trombone("Trombone", "Brass instrument", "The trombone has a long history");
//MusicalInstrument ukulele = new Ukulele("Ukulele", "String musical instrument", "The ukulele comes from Hawaii");
//MusicalInstrument cello = new Cello("Cello", "String musical instrument", "The cello is used in classical music");

//violin.Show();
//violin.Desc();
//violin.HistoryInfo();
//violin.Sound();

//Console.WriteLine();

//trombone.Show();
//trombone.Desc();
//trombone.HistoryInfo();
//trombone.Sound();

//Console.WriteLine();

//ukulele.Show();
//ukulele.Desc();
//ukulele.HistoryInfo();

//public class MusicalInstrument
//{
//    public string Name { get; set; }
//    public string Description { get; set; }
//    public string History { get; set; }

//    public MusicalInstrument(string name, string description, string history)
//    {
//        Name = name;
//        Description = description;
//        History = history;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine($"Sound {Name}");
//    }

//    public void Show()
//    {
//        Console.WriteLine($"Instrument: {Name}");
//    }

//    public void Desc()
//    {
//        Console.WriteLine($"Description: {Description}");
//    }

//    public void HistoryInfo()
//    {
//        Console.WriteLine($"History: {History}");
//    }
//}

//public class Violin : MusicalInstrument
//{
//    public Violin(string name, string description, string history) : base(name, description, history)
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("The violin makes the sound of violin music");
//    }
//}

//public class Trombone : MusicalInstrument
//{
//    public Trombone(string name, string description, string history) : base(name, description, history)
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("The trombone makes the sound of trombone music");
//    }
//}

//public class Ukulele : MusicalInstrument
//{
//    public Ukulele(string name, string description, string history) : base(name, description, history)
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("The ukulele makes a ukulele sound");
//    }
//}

//public class Cello : MusicalInstrument
//{
//    public Cello(string name, string description, string history) : base(name, description, history)
//    {
//    }

//    public override void Sound()
//    {
//        Console.WriteLine("The ukulele makes a ukulele sound");
//    }
//}

//N4

//Создать абстрактный базовый класс Worker (работника)
//с методом Print(). Создайте четыре производных класса:
//President, Security, Manager, Engineer. Переопределите метод
//Print() для вывода информации, соответствующей
//каждому типу работника.

//President president = new President("Axmed Axmedovic", 1001);
//Security security = new Security("Pyetr Petrenko", 2001);
//Manager manager = new Manager("Xalid Xalilov", 3001);
//Engineer engineer = new Engineer("Yagub Yagubov", 4001);

//president.Print();
//security.Print();
//manager.Print();
//engineer.Print();

//public abstract class Worker
//{
//    public string Name { get; set; }
//    public int EmployeeID { get; set; }

//    public Worker(string name, int employeeID)
//    {
//        Name = name;
//        EmployeeID = employeeID;
//    }

//    public abstract void Print();
//}

//public class President : Worker
//{
//    public President(string name, int employeeID) : base(name, employeeID)
//    {
//    }

//    public override void Print()
//    {
//        Console.WriteLine($"President: {Name}, ID: {EmployeeID}");
//    }
//}

//public class Security : Worker
//{
//    public Security(string name, int employeeID) : base(name, employeeID)
//    {
//    }

//    public override void Print()
//    {
//        Console.WriteLine($"Security: {Name}, ID: {EmployeeID}");
//    }
//}

//public class Manager : Worker
//{
//    public Manager(string name, int employeeID) : base(name, employeeID)
//    {
//    }

//    public override void Print()
//    {
//        Console.WriteLine($"Manager: {Name}, ID: {EmployeeID}");
//    }
//}

//public class Engineer : Worker
//{
//    public Engineer(string name, int employeeID) : base(name, employeeID)
//    {
//    }

//    public override void Print()
//    {
//        Console.WriteLine($"Engineer: {Name}, ID: {EmployeeID}");
//    }
//}


//N1

CreditCard card = new CreditCard("1234-5678-9012-3456", "Иван Иванов", new DateTime(2025, 12, 31), "1234", 1000);

// Подписываемся на события
card.AccountReplenished += (amount) => Console.WriteLine($"Счет пополнен на {amount} рублей.");
card.MoneySpent += (amount) => Console.WriteLine($"Со счета списано {amount} рублей.");
card.CreditUsageStarted += () => Console.WriteLine("Начато использование кредитных денег.");
card.TargetBalanceReached += (targetAmount) => Console.WriteLine($"Достигнута заданная сумма {targetAmount} рублей.");
card.PinChanged += () => Console.WriteLine("PIN-код успешно изменен.");

// Действия с картой
card.ReplenishAccount(500);
card.SpendMoney(300);
card.StartCreditUsage();
card.ReplenishAccount(200);
card.CheckTargetBalance(1000);
card.ChangePIN("5678");
public class CreditCard
{
    public string CardNumber { get; private set; }
    public string OwnerName { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    private string PIN { get; set; }
    public double CreditLimit { get; private set; }
    public double Balance { get; private set; }

    // События
    public event Action<double> AccountReplenished;
    public event Action<double> MoneySpent;
    public event Action CreditUsageStarted;
    public event Action<double> TargetBalanceReached;
    public event Action PinChanged;

    // Конструктор
    public CreditCard(string cardNumber, string ownerName, DateTime expiryDate, string pin, double creditLimit)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        ExpiryDate = expiryDate;
        PIN = pin;
        CreditLimit = creditLimit;
        Balance = 0;
    }

    // Метод для пополнения счета
    public void ReplenishAccount(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            AccountReplenished?.Invoke(amount);
        }
    }

    // Метод для расхода денег со счета
    public void SpendMoney(double amount)
    {
        if (amount > 0 && Balance + CreditLimit >= amount)
        {
            Balance -= amount;
            MoneySpent?.Invoke(amount);
        }
    }

    // Метод для начала использования кредитных денег
    public void StartCreditUsage()
    {
        CreditUsageStarted?.Invoke();
    }

    // Метод для проверки достижения заданной суммы денег
    public void CheckTargetBalance(double targetAmount)
    {
        if (Balance >= targetAmount)
        {
            TargetBalanceReached?.Invoke(targetAmount);
        }
    }

    // Метод для смены PIN-кода
    public void ChangePIN(string newPin)
    {
        if (!string.IsNullOrEmpty(newPin))
        {
            PIN = newPin;
            PinChanged?.Invoke();
        }
    }
}
