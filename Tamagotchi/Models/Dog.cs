using  System.Timers;
using System;

namespace Tamagotchi.Models
{
  public class Dog : Pet
  {
    public Dog(string name)
    {
      Name = name;

      TimePass = new Timer(TimeSpan.FromMinutes(1).TotalMilliseconds);
      // TimePass.Elapsed += DecrementTimerElapsed;
      TimePass.AutoReset = true;
      TimePass.Start();

      AmtFood = 20;
      FoodMin = 0;
      FoodMax = 20;
      FoodPlus = 2;
      Attention = 5;
      AttnMin = 0;
      AttnMax = 20;
      AttnPlus = 5;
      Rest = 2;
      RestMin = 0;
      RestMax = 10;
      RestPlus = 1;
      Type = "dog";
    }
  }
}