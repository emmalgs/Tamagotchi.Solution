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
      FoodMin = 0;
      FoodMax = 10;
      FoodPlus = 3;
      Attention = 10;
      AttnMin = -10;
      AttnMax = 10;
      AttnPlus = 4;
      Rest = 17;
      RestMin = 0;
      RestMax = 20;
      RestPlus = 2;
      Type = "cat";
    }
  }
}