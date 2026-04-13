using System;

class Program
{
    static void Main()
    {
        // по умолчанию
        Car car1 = new Car();
        car1.Speed = 80;
        car1.Fuel = 30;
        car1.ShowInfo();
        Console.WriteLine();

        // с параметрами
        Car car2 = new Car("BMW", 120, 40);
        car2.Drive();
        car2.Refuel(15);
        car2.ShowInfo();
        Console.WriteLine();

        // копирования
        Car car3 = new Car(car2);
        car3.Drive(150);
        car3.Refuel();
        car3.ShowInfo();
    }
}
