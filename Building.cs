using System;

namespace Planner
{
    public class Building
    {
      private string _designer = "Aaron Frankenfield";
      private DateTime _dateConstructed {get; set;}
      private string _address {get; set;}
      private string _owner {get; set;}

      public int Stories {get; set;}
      public double Width {get; set;}
      public double Depth {get; set;}
      public string Name {get; set;}

      public double Volume {
        get
        {
          return Width * Depth * (3 * Stories);
        }
      }

      public Building(string address) {
        _address = address;
      }

      public void Construct()
      {
        _dateConstructed = DateTime.Now;
      }
      public void Purchase(string owner)
      {
        _owner = owner;
      }

      public void PrintBuildings()
      {
        DateTime printTime = _dateConstructed;
        string printOwner = _owner;
        string printAddress = _address;
        Console.WriteLine("----------------");
        Console.WriteLine(printAddress);
        Console.WriteLine($"Constructed on {printTime}");
        Console.WriteLine($"Owned by {printOwner}");
        Console.WriteLine($"{Volume} cubic meters");
      }
    }
}





