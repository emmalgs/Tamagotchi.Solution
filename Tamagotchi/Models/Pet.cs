using System.Timers;

namespace Tamagotchi.Models
{
  public abstract class Pet
  {
    public int PetId { get; set; }
    public Timer TimePass { get; set; }
    public string Name { get; set; }
    public int AmtFood { get; set; }
    public int FoodPlus { get; set; }
    public int FoodMin { get; set; }
    public int FoodMax { get; set; }
    public int Attention { get; set; }
    public int AttnPlus { get; set; }
    public int AttnMin { get; set; }
    public int AttnMax { get; set; }
    public int Rest { get; set; }
    public int RestPlus { get; set; }
    public int RestMin { get; set; }
    public int RestMax { get; set; }
    public string Type { get; set; }

    public void Feed()
    {
      if (AmtFood > FoodMin && AmtFood < FoodMax)
      {
        AmtFood += FoodPlus;
        Rest -= RestPlus;
        Attention++;
      }
    }

    public void Play()
    {
      if (Attention > AttnMin && Attention < AttnMax)
      {
        Attention += AttnPlus;
        AmtFood -= FoodPlus;
      }
    }
    public void Sleep()
    {
      Rest = RestMax;
      AmtFood -= FoodPlus;
      Attention -= AttnPlus;
    }

    public void DecrementTimerElapsed(object sender, ElapsedEventArgs e)
    {
      AmtFood--;
      Attention--;
      Rest--;
    }
  }
}
