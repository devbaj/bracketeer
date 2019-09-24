using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace bracket.Models
{
  public class Contest
  {
    [Key]
    public int ContestID {get;set;}
    public string Title {get;set;}
    public User Creator {get;set;}
    public List<User> Admins {get;set;}
    public List<Round> Rounds {get;set;}
    public List<Nominee> Nominees {get;set;}
    public int MaxContestants {get;set;}
    public List<Contestant> Contestants {get;set;}
    public bool Active {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
  }
}