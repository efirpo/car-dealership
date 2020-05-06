namespace Dealership.Models
{
  public class Car
  {
  public string MakeModel;
  public int Price;
  public int Miles;

  public Car(string makeModel, int price, int miles)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
  }
  public bool PriceRange(int maxPrice)
  {
    return (Price < maxPrice);
  }
}
}