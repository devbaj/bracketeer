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
    [ HttpPost("api/post/test") ]

    public IActionResult TestPost([FromBody] ApiModel body)
    {
      System.Console.WriteLine("***Test post route reached***");
      System.Console.WriteLine(body);
      CreateContestForm testContest = JsonConvert.DeserializeObject<CreateContestForm>(body.Content);
      System.Console.WriteLine(testContest.Title);
      System.Console.WriteLine(testContest.MaxContestants);
      var Obj = new {
        Success = true
      };
      return Json(Obj);
    }

    [HttpPost("api/contest/create")]
    public IActionResult CreateNewContest(CreateContestForm formData)
    {
      // ** for now, contests will be required to have 2^x participants
      if (!IsPowerOfTwo(formData.MaxContestants)) {return null;}
      Contest createdContest = new Contest();
      createdContest.Title = formData.Title;
      createdContest.NumberOfSeeds = formData.MaxContestants;

      return Json(createdContest);

    }
    public bool IsPowerOfTwo(int x)
    {
      return (x != 0) && ((x & (x - 1)) == 0);
    }
  }

}
