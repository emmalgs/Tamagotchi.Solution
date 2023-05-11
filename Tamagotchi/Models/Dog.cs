// using System.Collections.Generic;
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
      TimePass.Elapsed += DecrementTimerElapsed;
      TimePass.AutoReset = true;
      TimePass.Start();

      AmtFood = 20;
      FoodMinMax.Add(0);
      FoodMinMax.Add(20);
      FoodPlus = 2;
      Attention = 5;
      AttnMinMax.Add(0);
      AttnMinMax.Add(20);
      AttnPlus = 5;
      Rest = 2;
      RestMinMax.Add(0);
      RestMinMax.Add(10);
      RestPlus = 1;

      AllPets.Add(this);
      Id = AssignId();
    }
  }
}