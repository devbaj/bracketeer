using System;
using System.ComponentModel.DataAnnotations;
namespace bracket.Models
{
  public class Matchup
  {
    [Key]
    public int MatchupID {get;set;}
    public Contestant HighSeed {get;set;}
    public Contestant LowSeed {get;set;}
    // ! the following broke EF; find another way to represent the bracket structure
    // public Matchup Left {get;set;}
    // public Matchup Right {get;set;}
    // public Matchup Parent {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdateAt {get;set;}
  }
}