using System.Collections.Generic;

namespace PlacesBeen.Models
{
  
  public class Place
  {
    // properties
    public string Location { get; set; }
    private static List<Place> _instances = new List<Place>{};

    // constructor
    public Place(string location)
    {
      Location = location;
      _instances.Add(this);
    }

    // methods
    public static List<Place> GetAll()
    {
      return _instances;
    } 

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
