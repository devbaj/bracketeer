using System;
using System.ComponentModel.DataAnnotations;
namespace bracket.Models
{
  public class Matchup
  {
    public Matchup()
    {
      Left = null;
      Right = null;
      Parent = null;
    }
    [Key]
    public int MatchupID {get;set;}
    public Contestant HighSeed {get;set;}
    public Contestant LowSeed {get;set;}
    public Matchup Left {get;set;}
    public Matchup Right {get;set;}
    public Matchup Parent {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdateAt {get;set;}
  }
}