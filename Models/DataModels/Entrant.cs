using System;
using System.ComponentModel.DataAnnotations;

namespace bracket.Models
{
  public abstract class Entrant
  {
    [Key]
    public int EntrantID {get;set;}
    public string GivenName {get;set;}
    public string Surname {get;set;}
    public string Show {get;set;}
    /* ?? maybe some sort of Show ID; perhaps we build out a Show/Franchise
    class later for other kinds of contests */
    public string ImageURL {get;set;}
    // ** for now we will access images via user URLs or APIs
    public int VoteCount {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdateAt {get;set;}
  }
}