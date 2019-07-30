using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace bracket.Models
{
  public class Round
  {
    [Key]
    public int RoundID {get;set;}
    public List<Matchup> Matchups {get;set;}
    public string Title {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdateAt {get;set;}
  }
}