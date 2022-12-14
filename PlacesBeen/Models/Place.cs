using System.Collections.Generic;

namespace PlacesBeen.Models
{
  
  public class Place
  {
    // properties
    public string Location { get; set; }
    public string Companion { get; set; }
    public string Dates { get; set; }
    public string Journal { get; set; }
    public string Image { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place>{};

    // constructor
    public Place(string location)
    {
      Location = location;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Place(string location, string companion, string dates, string journal, string image)
      : this(location)
    {
      Companion = companion;
      Dates = dates;
      Journal = journal;
      Image = image;
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

    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
