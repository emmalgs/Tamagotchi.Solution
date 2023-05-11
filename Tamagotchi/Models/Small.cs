using System.Timers;
using System;

namespace Tamagotchi.Models
{
  public class Small : Pet
  {
    public Small(string name)
    {
      Name = name;

      TimePass = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
      TimePass.Elapsed += DecrementTimerElapsed;
      TimePass.AutoReset = true;
      TimePass.Start();

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
      Id = AssignId();
    }
  }
}