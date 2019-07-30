using System.Collections.Generic;
namespace bracket.Models
{
  public class Contestant : Entrant
  {
    public int Seed {get;set;}
    public int FinalPlacement {get;set;}
    public List<Contestant> Opponents {get;set;}
  }
}