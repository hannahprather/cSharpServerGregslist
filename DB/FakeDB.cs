using cSharpServerGregslist.models;

namespace cSharpServerGregslist.DB;

public static class FakeDb
{
  public static List<Car> Cars { get; set; } = new List<Car>() {
    new Car("Jeep", "Wrangler", 1993, 9876),
    new Car("Honda", "CRV", 2007, 7899),
    new Car("Ford", "Ranger", 2003, 9788),
    new Car("Toyota", "Prius", 2008, 4567),
  };
}