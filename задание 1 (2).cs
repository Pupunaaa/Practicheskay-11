using System;

public class Car
{
    private int speed;
    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            if (value < 0)
                Console.WriteLine("Скорость не может быть отрицательной!");
            else if (value > 300)
                Console.WriteLine("Скорость не может превышать 300!");
            else
                speed = value;
        }
    }

    public string Model { get; set; } = "Unknown";

    public Car(string model, int speed)
    {
        Model = model;
        Speed = speed;
    }

    public void Drive()
    {
        Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
    }
}
class Program
{
    static void Main()
    {
        Car car = new Car("BMW", 150);
        car.Drive();
        car.Speed = 400;
        car.Drive();
        car.Speed = -50;
        car.Drive();
    }
}