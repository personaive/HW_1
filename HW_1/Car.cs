using System;

public class Car
{
    // поля
    private string brand;
    private int speed;
    private double fuel;
    
    // конструкторы: по умолчанию
    public Car()
    {
        brand = "Unknown";
        speed = 0;
        fuel = 0;
    }
    
    // с параметрами
    public Car(string brand, int speed, double fuel)
    {
        this.brand = brand;
        this.speed = speed;
        this.fuel = fuel;
    }
    
    // копирования
    public Car(Car car)
    {
        this.brand = car.brand;
        this.speed = car.speed;
        this.fuel = car.fuel;
    }

    // свойства
    public string Brand
    {
        get { return brand; }
    }

    public int Speed
    {
        set { speed = value; }
    }

    public double Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }
    
    // методы с выводом
    public void Drive()
    {
        Console.WriteLine($"{brand} едет {speed} км/ч");
    }

    public void Drive(int newSpeed)
    {
        speed = newSpeed;
        Console.WriteLine($"{brand} теперь едет {speed} км/ч");
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
