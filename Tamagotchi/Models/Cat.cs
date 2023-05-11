using System.Timers;
using System;

namespace Tamagotchi.Models
{
  public class Cat : Pet
  {
    public Cat(string name)
    {
      Name = name;

      TimePass = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
      TimePass.Elapsed += DecrementTimerElapsed;
      TimePass.AutoReset = true;
      TimePass.Start();

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