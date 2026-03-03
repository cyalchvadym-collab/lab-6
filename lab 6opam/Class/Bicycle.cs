// Vehicles/Bicycle.cs
namespace lab6.Vehicles;

public class Bicycle : Vehicle
{
    public int GearCount { get; set; }

    public Bicycle(string brand, int speed, int gearCount) 
        : base(brand, speed)
    {
        GearCount = gearCount;
    }

    public override void Move()
    {
        Console.WriteLine($"🚴 Велосипед {Brand} їде {Speed} км/год, передач: {GearCount}");
    }
}