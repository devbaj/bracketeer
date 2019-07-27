using System;
using System.ComponentModel.DataAnnotations;

namespace bracket.Models
{
  public class User
  {
    [Key]
    public int UserID {get;set;}
    public string Name {get;set;}
    public string SecondName{get;set;}
    public string Surname {get;set;}
    public string SecondSurname {get;set;}
    public string Username {get;set;}
    public string Email {get;set;}
    public DateTime Birthdate {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
  }
}