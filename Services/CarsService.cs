using cSharpServerGregslist.DB;
using cSharpServerGregslist.models;


namespace cSharpServerGregslist.Services;

public class CarsService
{
  internal List<Car> GetAll()
  {
    return FakeDb.Cars;
  }
  internal Car GetById(string id)
  {
    Car found = FakeDb.Cars.Find(c => c.Id == id);
    if (found == null)
    {
      throw new Exception("Invalid Id");
    }
    return found;
  }

  internal Car Create(Car newCar)
  {
    FakeDb.Cars.Add(newCar);
    return newCar;
  }

  internal Car Update(Car updates)
  {
    Car original = GetById(updates.Id);
    original.Make = updates.Make ?? original.Make;
    original.Model = updates.Model ?? original.Model;
    original.Year = updates.Year ?? original.Year;
    original.Price = updates.Price ?? original.Price;

    return original;
  }

  internal void Delete(string id)
  {
    Car found = GetById(id);
    FakeDb.Cars.Remove(found);
  }

}