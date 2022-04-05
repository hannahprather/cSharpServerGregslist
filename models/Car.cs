using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace cSharpServerGregslist.models
{
  public class Car
  {
    public string Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int? Year { get; set; }
    public int? Price { get; set; }


    public Car(string model, string make, int? year, int? price)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Model = model;
      Year = year;
      Price = price;
    }
  }


}