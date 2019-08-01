using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace bracket.Models
{
  public class Context : DbContext
  {
    public Context(DbContextOptions options) : base(options) {}
    public DbSet<User> Users {get;set;}
    public DbSet<Contest> Contests {get;set;}
  }
}