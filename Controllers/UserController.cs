using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bracket.Pages;
using bracket.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace bracket.Controllers
{
  public class UserController : Controller
  {
    private Context dbContext;
    public UserController(Context context)
    {
      dbContext = context;
    }

    [HttpPost("api/users/create")]
    public IActionResult CreateUser([FromBody] ApiModel body)
    {
      User newUser = JsonConvert
        .DeserializeObject<User>(body.Content);
      newUser.RedditConnected = false;
      newUser.CreatedAt = DateTime.Now;
      newUser.UpdatedAt = DateTime.Now;
      dbContext.Users.Add(newUser);
      dbContext.SaveChanges();
      var res = new
      {
        success = true,
      };
      return Json(res);
    }

    [HttpGet("api/users/read")]
    public IActionResult ReadOneUser([FromBody] ApiModel body)
    {
      int userID = JsonConvert.
        DeserializeObject<int>(body.Content);
      User readUser = dbContext.Users.SingleOrDefault(u => u.UserID == userID);
      return Json(readUser);
    }

    [HttpPatch("api/users/update")]
    public IActionResult UpdateUser([FromBody] ApiModel body)
    {
      User updateData = JsonConvert.
        DeserializeObject<User>(body.Content);
      User editUser = dbContext.Users
        .SingleOrDefault(u => u.UserID == updateData.UserID);
      editUser.GivenName = updateData.Username;
      editUser.Surname = updateData.Surname;
      editUser.Username = updateData.Username;
      editUser.Email = updateData.Email;
      editUser.Birthdate = updateData.Birthdate;
      editUser.UpdatedAt = DateTime.Now;
      dbContext.SaveChanges();
      var res = new
      {
        success = true,
        editUser
      };
      return Json(res);
    }

    [HttpDelete("api/users/delete")]
    public IActionResult DeleteUser([FromBody] ApiModel body)
    {
      int userID = JsonConvert
        .DeserializeObject<int>(body.Content);
      User deleteUser = dbContext.Users
        .SingleOrDefault(u => u.UserID == userID);
      dbContext.Users.Remove(deleteUser);
      dbContext.SaveChanges();
      var res = new
      {
        success = true
      };
      return Json(res);
    }
  }
}