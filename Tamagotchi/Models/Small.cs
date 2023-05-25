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
      FoodMin = 0;
      FoodMax = 5;
      FoodPlus = 1;
      Attention = 15;
      AttnMin = 0;
      AttnMax = 15;
      AttnPlus = 5;
      Rest = 10;
      RestMin = 0;
      RestMax = 10;
      RestPlus = 3;
      Type = "small pet";
    }
  }
}