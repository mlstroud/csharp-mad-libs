using System.Collections.Generic;

namespace MadLibs.Models
{
  public class Game
  {
    public string[] Nouns { get; set; }
    public string[] Verbs { get; set; }
    public string[] Adjectives { get; set; }
    public string[] PluralNouns { get; set; }

    public Game(string[] nouns, string[] verbs, string[] adjectives, string[] pluralNouns)
    {
      Nouns = new string[nouns.Length];
      Verbs = new string[verbs.Length];
      Adjectives = new string[adjectives.Length];
      PluralNouns = new string[pluralNouns.Length];
      nouns.CopyTo(Nouns, 0);
      verbs.CopyTo(Verbs, 0);
      adjectives.CopyTo(Adjectives, 0);
      pluralNouns.CopyTo(PluralNouns, 0);
    }
  }
}