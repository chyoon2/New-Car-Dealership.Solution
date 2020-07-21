using System;
using System.Collections.Generic;

namespace CarDealer.Models {
  
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _instances = new List<Car> {};

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetPrice()
    {
      return _price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public Car(string makeModel, int price, int miles)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
       _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public string MakeSoundByCar ()
    {
      if (_miles < 200000)
      {
        return "beep";
      }
      else
      {
        return "honk";
      }
    }

    public bool WorthBuying(int maxPrice)
    {
      return (_price < maxPrice);
    }
  }
}