using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main()
    {
        // конструктор по умолчанию
        Car car1 = new Car();
        car1.Speed = 80;
        car1.Fuel = 30;
        car1.ShowInfo();

        Console.WriteLine();

        // конструктор с параметрами
        Car car2 = new Car("Audi", 120, 40);
        car2.Drive();
        car2.Refuel(15);
        car2.ShowInfo("Вторая машина:");

        Console.WriteLine();

        // конструктор копирования
        Car car3 = new Car(car2);
        car3.Drive(150);
        car3.Refuel();
        car3.ShowInfo();

        Console.WriteLine("\nНажмите Enter для выхода...");
        Console.ReadLine(); // чтобы консоль не закрывалась
    }
}