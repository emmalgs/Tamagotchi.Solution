using System.Collections.Generic;
using System.Timers;
// using System.Diagnostics;

namespace Tamagotchi.Models
{
  public abstract class Pet
  {
    public Timer TimePass { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public int AmtFood { get; set; }
    public int FoodPlus { get; set; }
    public List<int> FoodMinMax { get; set; } = new List<int> { };
    public int Attention { get; set; }
    public int AttnPlus { get; set; }
    public List<int> AttnMinMax { get; set; } = new List<int> { };
    public int Rest { get; set; }
    public int RestPlus { get; set; }
    public List<int> RestMinMax { get; set; } = new List<int> { };
    public static List<Pet> AllPets { get; set; } = new List<Pet> { };
    public static void ClearAll()
    {
      AllPets.Clear();
    }

    public void Feed()
    {
      if (AmtFood > FoodMinMax[0] && AmtFood < FoodMinMax[1])
      {
        AmtFood += FoodPlus;
        Rest -= RestPlus;
        Attention ++;
      }
    }

    public void Play()
    {
      if (Attention > AttnMinMax[0] && Attention < AttnMinMax[1])
      {
        Attention += AttnPlus;
        AmtFood -= FoodPlus;
      }
    }

    public void Sleep()
    {
      Rest = RestMinMax[1];
      AmtFood -= FoodPlus;
      Attention -= AttnPlus;
    }

    public static Pet Find(int searchId)
    {
      return AllPets[searchId - 1];
    }

    public void DecrementTimerElapsed(object sender, ElapsedEventArgs e)
    {
      AmtFood--;
      Attention--;
      Rest--;
    }
  }
}
