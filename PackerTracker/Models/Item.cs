using System.Collections.Generic;

namespace PackerTracker.Models
{
  
  public class Item
  {
    // properties
    public string Description { get; set; }
    // public string Companion { get; set; }
    // public string Dates { get; set; }
    // public string Journal { get; set; }
    // public string Image { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item>{};

    // constructor
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public Place(string location, string companion, string dates, string journal, string image)
    //   : this(location)
    // {
    //   Companion = companion;
    //   Dates = dates;
    //   Journal = journal;
    //   Image = image;
    // }

    // methods
    public static List<Item> GetAll()
    {
      return _instances;
    } 

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
