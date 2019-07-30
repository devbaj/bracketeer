using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bracket.Pages;
using bracket.Models;
using Microsoft.EntityFrameworkCore;

namespace bracket.Controllers
{
  public class ContestController : Controller
  {
    [ HttpPost("api/post/test") ]

    public IActionResult TestPost(object data)
    {
      System.Console.WriteLine("Test post route reached");
      System.Console.WriteLine();
      CreateContestForm confirmTest = new CreateContestForm();
      confirmTest.Title = data.GetType().GetProperty("title").GetValue(data)
        .ToString();
      confirmTest.MaxContestants = (int) data.GetType()
        .GetProperty("maxContestants").GetValue(data);
      return Json(confirmTest);
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