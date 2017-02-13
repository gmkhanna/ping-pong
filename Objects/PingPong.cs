using System.Collections.Generic;

namespace PingPong
{
  public class PingPong
  {
    public static List<string> outputList = new List<string>();

    public static void pingPongTester (int number)
    {
      for(int index = 1; index <= number; index++)
      {
        if(index % 15 == 0)
        {
          outputList.Add("ping-pong");
        }
        else if(index % 5 == 0)
        {
          outputList.Add("pong");
        }
        else if(index % 3 == 0)
        {
          outputList.Add("ping");
        }
        else
        {
          outputList.Add(index.ToString());
        }
      }
    }

    public static List<string> GetList()
    {
      return outputList;
    }

    public static void ClearList()
    {
      outputList.Clear();
    }
  }
}
