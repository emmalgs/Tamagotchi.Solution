using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Cat : Pet
  {
    public int Id { get; }
    public Cat(string name)
    {
      Name = name;

      AmtFood = 5;
      FoodMinMax.Add(0);
      FoodMinMax.Add(10);
      FoodPlus = 3;
      Attention = 10;
      AttnMinMax.Add(-10);
      AttnMinMax.Add(10);
      AttnPlus = 4;
      Rest = 17;
      RestMinMax.Add(0);
      RestMinMax.Add(20);
      RestPlus = 2;

      AllPets.Add(this);
      Id = AllPets.Count;
    }
  }
}