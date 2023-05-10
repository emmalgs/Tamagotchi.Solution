namespace Tamagotchi.Models
{
  public abstract class Pet
  {
    public int Id { get; }
    public string Name { get; set; }
    public int AmtFood { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
  }
}
