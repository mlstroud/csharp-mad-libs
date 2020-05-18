namespace MadLibs.Models
{
  public class Game
  {
    public string[] test { get; set; }

    public Game(string test1, string test2)
    {
      test = new string[2];
      test[0] = test1;
      test[1] = test2;
    }
  }
}