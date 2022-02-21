using System;

namespace Dealership.Models{

  public class Car
  {
    // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }
    public string GetMakeModel()
    {
    return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public double GetSale()
    {
      return Price * .8;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}