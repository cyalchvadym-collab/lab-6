// Vehicles/Car.cs
namespace lab6.Vehicles;

public class Car : Vehicle, IRefuelable
{
    public int FuelCapacity { get; set; }

    public Car(string brand, int speed, int fuelCapacity) 
        : base(brand, speed)
    {
        FuelCapacity = fuelCapacity;
    }

    public override void Move()
    {
        Console.WriteLine($"🚗 Автомобіль {Brand} їде {Speed} км/год");
    }

    public void Refill()
    {
        Console.WriteLine($"⛽ Заправка {Brand}, бак {FuelCapacity}л");
    }
}