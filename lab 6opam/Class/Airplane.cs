// Vehicles/Airplane.cs
namespace lab6.Vehicles;

public class Airplane : Vehicle, IRefuelable
{
    public int MaxAltitude { get; set; }

    public Airplane(string brand, int speed, int maxAltitude) 
        : base(brand, speed)
    {
        MaxAltitude = maxAltitude;
    }

    public override void Move()
    {
        Console.WriteLine($"✈️ Літак {Brand} летить {Speed} км/год, висота {MaxAltitude}м");
    }

    public void Refill()
    {
        Console.WriteLine($"⛽ Заправка літака {Brand} авіапаливом");
    }
}