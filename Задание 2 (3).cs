using System;

public class Phone
{
    private int battery;
    public int BatteryLevel
    {
        get
        {
            return battery;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Заряд не может быть отрицательным!");
            else if (value > 100)
                Console.WriteLine("Заряд не может превышать 100!");
            else
                battery = value;
        }
    }
    public string Brand { get; set; } = "Unknown";

    public Phone(string brand, int charge)
    {
        Brand = brand;
        BatteryLevel = charge;
    }
    public void Use()
    {
        BatteryLevel -= 10;
        Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
    }
}
class Program
{
    static void Main()
    {
        Phone phone = new Phone("Samsung", 80);
        phone.Use();
        phone.Use();
        phone.Use();
        Phone phoner = new Phone("Samsung", 150);
    }
}