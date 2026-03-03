using lab6;
using lab6.Vehicles;
using lab6.BankAccounts;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// ==================== ЗАВДАННЯ №1 ====================
Console.WriteLine("╔════════════════════════════════════╗");
Console.WriteLine("║     ЗАВДАННЯ №1: ТРАНСПОРТ         ║");
Console.WriteLine("╚════════════════════════════════════╝\n");

List<Vehicle> vehicles = new()
{
    new Car("Bmw", 120, 50),
    new Bicycle("Cube", 25, 21),
    new Airplane("Dreamliner", 900, 10000),
    new Car("Tesla", 150, 75)
};

foreach (var v in vehicles)
{
    Console.WriteLine($"Тип: {v.GetType().Name}");
    v.Move();
    if (v is IRefuelable r) 
    {
        r.Refill();
    }
    Console.WriteLine();
}

// ==================== ЗАВДАННЯ №2 ====================
Console.WriteLine("\nНатисніть Enter для завдання №2...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("╔════════════════════════════════════╗");
Console.WriteLine("║   ЗАВДАННЯ №2: БАНКІВСЬКІ РАХУНКИ  ║");
Console.WriteLine("╚════════════════════════════════════╝\n");

List<Account> accounts = new()
{
    new SavingsAccount("UA111", "Іван Петренко", 5000m),
    new BusinessAccount("UA222", "Олена Коваленко", 15000m, "ТОВ Успіх"),
    new SavingsAccount("UA333", "Петро Сидоренко", 3000m, 0.04m)
};

// Інфо
foreach (var acc in accounts)
{
    acc.DisplayInfo();
}

// Тест зняття
Console.WriteLine("\n--- Тестування зняття ---");
accounts[0].Withdraw(1000m);                    // Ощадний: без комісії
accounts[1].Withdraw(2000m);                    // Бізнес: 1%
((SavingsAccount)accounts[0]).ApplyInterest(); // Відсотки

// Фінальний стан
Console.WriteLine("\n--- Фінальний стан ---");
foreach (var acc in accounts)
{
    acc.DisplayInfo();
}

Console.WriteLine("\nГотово! Натисніть Enter...");
Console.ReadLine();
     
        
Console.WriteLine("\nНатисніть Enter для завдання №3...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("╔════════════════════════════════════╗");
Console.WriteLine("║   ЗАВДАННЯ №3: ВИПРАВЛЕННЯ ПОЛІМОРФІЗМУ  ║");
Console.WriteLine("╚════════════════════════════════════╝\n");


List<Artifact> inventory = new List<Artifact>();

inventory.Add(new MagicScroll(101));
inventory.Add(new AncientSword(202));

Console.WriteLine("--- Аналіз інвентарю ---");

foreach (var item in inventory)
{
    item.Identify();
}

Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
Console.ReadKey();

