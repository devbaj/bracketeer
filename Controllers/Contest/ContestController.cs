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
  public class ContestController : Controller
  {
    private Context dbContext;
    public ContestController(Context context)
    {
      dbContext = context;
    }

    [HttpPost("api/post/test")]
    public IActionResult TestPost([FromBody] ApiModel body)
    {
      System.Console.WriteLine("***Test post route reached***");
      System.Console.WriteLine(body);
      CreateContestForm testContest = JsonConvert.DeserializeObject<CreateContestForm>(body.Content);
      System.Console.WriteLine(testContest.Title);
      System.Console.WriteLine(testContest.MaxContestants);
      var res = new {Success = true};
      return Json(res);
    }

    [HttpPost("api/contest/create")]
    public IActionResult CreateNewContest([FromBody] ApiModel body)
    {
      // ** for now, contests will be required to have 2^x participants
      CreateContestForm userInput = JsonConvert
        .DeserializeObject<CreateContestForm>(body.Content);
      if (!IsPowerOfTwo(userInput.MaxContestants))
      {
        var errorMsg = new
        {
          success = false,
          errorField = "MaxContestants",
          msg = "Number of contestants must be a power of 2"
        };
        return Json(errorMsg);
      }
      Contest contestToDB = new Contest();
      contestToDB.Title = userInput.Title;
      contestToDB.MaxContestants = userInput.MaxContestants;
      // TODO add user to contest once users are implemented
      contestToDB.CreatedAt = DateTime.Now;
      contestToDB.UpdatedAt = DateTime.Now;
      System.Console.WriteLine(contestToDB.ToString());
      dbContext.Contests.Add(contestToDB);
      var successMsg = new
      {
        success = true,
        contest = Json(contestToDB)
      };
      return Json(successMsg);
    }
    public bool IsPowerOfTwo(int x)
    {
      return (x != 0) && ((x & (x - 1)) == 0);
    }

    [HttpGet("api/contests/readone")]
    public IActionResult ReadOneContest([FromBody] ApiModel body)
    {
      int? contestID = JsonConvert
        .DeserializeObject<int>(body.Content);
      if (contestID == null)
      {
        return Json(new { success = false });
      }
      Contest retrievedContest = dbContext.Contests
        .SingleOrDefault(c => c.ContestID == contestID);
      var res = new
      {
        success = true,
        retrievedContest
      };
      return Json(res);
    }

    [HttpGet("api/contests/readall")]
    public IActionResult ReadAllContests()
    {
      List<Contest> AllContests = dbContext.Contests
        .ToList();
      var res = new
      {
        success = true,
        AllContests
      };
      return Json(res);
    }

    [HttpPatch("api/contests/update")]
    public IActionResult UpdateContest([FromBody] ApiModel body)
    {
      Contest updateData = JsonConvert
        .DeserializeObject<Contest>(body.Content);
      Contest editedContest = dbContext.Contests
        .SingleOrDefault(c => c.ContestID == updateData.ContestID);
      editedContest.Title = updateData.Title;
      if (IsPowerOfTwo(updateData.MaxContestants))
      {
        editedContest.MaxContestants = updateData.MaxContestants;
      }
      editedContest.UpdatedAt = DateTime.Now;
      dbContext.SaveChanges();
      var res = new
      {
        success = true,
        editedContest
      };
      return Json(res);
    }

    [HttpDelete("api/contest/delete")]
    public IActionResult DeleteContest([FromBody] ApiModel body)
    {

      int? contestID = JsonConvert
        .DeserializeObject<int>(body.Content);

      Contest retrievedContest = dbContext.Contests
        .SingleOrDefault(c => c.ContestID == contestID);
      dbContext.Contests.Remove(retrievedContest);
      dbContext.SaveChanges();
      var res = new
      {
        success = true
      };
      return Json(res);
    }
  }
}