using Nancy;
using System.Collections.Generic;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        PingPong.ClearList();
        return View["index.cshtml"];
      };

      Post["/ping-pong"] = _ => {
        PingPong.ClearList();
        int userInput = int.Parse(Request.Form["number"]);
        PingPong.pingPongTester(userInput);
        List<string> outputList = PingPong.GetList();
        return View["results.cshtml", outputList];
      };
    }
  }
}
