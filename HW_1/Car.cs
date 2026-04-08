using System;

public class Car
{
    private string brand;
    private int speed;
    private double fuel;

    public string Brand { get { return brand; } }
    public int Speed { set { speed = value; } }
    public double Fuel { get { return fuel; } set { fuel = value; } }

    // конструкторы
    public Car()
    {
        brand = "Unknown";
        speed = 0;
        fuel = 0;
    }

    public Car(string brand, int speed, double fuel)
    {
        this.brand = brand;
        this.speed = speed;
        this.fuel = fuel;
    }

    public Car(Car other)
    {
        this.brand = other.brand;
        this.speed = other.speed;
        this.fuel = other.fuel;
    }

    // методы с выводом
    public void Drive()
    {
        Console.WriteLine($"{brand} едет со скоростью {speed} км/ч");
    }

    public void Drive(int newSpeed)
    {
        speed = newSpeed;
        Console.WriteLine($"{brand} теперь едет со скоростью {speed} км/ч");
    }

    public void Refuel(double amount)
    {
        fuel += amount;
        Console.WriteLine($"{brand} заправлено {amount} литров. Топливо сейчас: {fuel}");
    }

    public void Refuel()
    {
        fuel += 10;
        Console.WriteLine($"{brand} автозаправка +10 литров. Топливо сейчас: {fuel}");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Марка: {brand}, Скорость: {speed}, Топливо: {fuel}");
    }

    public void ShowInfo(string msg)
    {
        Console.WriteLine(msg);
        ShowInfo();
    }
}