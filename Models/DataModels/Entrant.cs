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
    public string Source {get;set;} // ? not sure what to label this, should be wherever the character is from. Anime, manga, game, etc.
    /* ?? maybe some sort of Show ID; perhaps we build out a Show/Franchise
    class later for other kinds of contests */
    public string ImageURL {get;set;}
    // ** for now we will access images via user URLs or APIs
    public int VoteCount {get;set;}
    public bool Active {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
  }
}