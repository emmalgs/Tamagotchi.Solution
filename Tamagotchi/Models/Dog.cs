// using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Dog : Pet
  {
    public int Id { get; }
    public Dog(string name)
    {
      Name = name;
      AllPets.Add(this);
      Id = AllPets.Count;
    }
  }
}