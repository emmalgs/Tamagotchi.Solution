// using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Cat : Pet
  {
    public int Id { get; }
    public Cat(string name)
    {
      Name = name;
      AllPets.Add(this);
      Id = AllPets.Count;
    }
  }
}