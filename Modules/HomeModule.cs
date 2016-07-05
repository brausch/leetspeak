using Nancy;
using System.Collections.Generic;
using Leetspeak;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/Leetspeak"] = _ => {
        Leetspeak newPhrase = new Leetspeak(
        Request.Query["phrase"]);
        return View["leetspeak.cshtml", newPhrase];
      };
    }
  }
}
