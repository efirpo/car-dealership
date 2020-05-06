using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
public class Program
{
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 234232);
      Car yugo = new Car("1980 Yugo Koral", 700, 9092222);
      Car ford = new Car("1988 Ford Country Squire", 14000000, 234222);
      Car amc = new Car("1976 AMC Pacer", 7, 8675309);

      List<Car> cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter max price: ");
      int maxPrice = int.Parse(Console.ReadLine());
      List<Car> CarsInPriceRange = new List<Car>(0);

      foreach (Car automobile in cars)
      {
        if (automobile.PriceRange(maxPrice))
        {
          CarsInPriceRange.Add(automobile);
        }
      }

      foreach (Car automobile in CarsInPriceRange)
      {
        Console.WriteLine("--------------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}