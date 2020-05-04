using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car();
    volkswagen.MakeModel = "1974 Volkswagen Thing";
    volkswagen.Price = 1100;
    volkswagen.Miles = 234232;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 9092222;

    Car ford = new Car();
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 14000000;
    ford.Miles = 234222;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 7;
    amc.Miles = 8675309;



    List<Car> cars = new List<Car>() { volkswagen, yugo, ford, amc };

    foreach (Car automobile in cars)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}