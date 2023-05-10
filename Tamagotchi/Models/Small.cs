// using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Small : Pet
  {
    public Small(string name)
    {
      Name = name;

      AmtFood = 5;
      FoodMinMax.Add(0);
      FoodMinMax.Add(5);
      FoodPlus = 1;
      Attention = 15;
      AttnMinMax.Add(0);
      AttnMinMax.Add(15);
      AttnPlus = 5;
      Rest = 10;
      RestMinMax.Add(0);
      RestMinMax.Add(10);
      RestPlus = 3;

      AllPets.Add(this);
      Id = AllPets.Count;
    }
  }
}