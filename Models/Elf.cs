namespace elves.Models 
{
  public class Elf
  {
    public string Name { get; set; }
    public int TimeIn { get; set; }
    public int TimeOut {get; set;}
    public int CandyConsumed {get; set;}


    public Elf(string name, int timein, int timeout, int candy)
    {
        Name = name;
        TimeIn = timein;
        TimeOut = timeout;
        CandyConsumed = candy;
    }
  }
}