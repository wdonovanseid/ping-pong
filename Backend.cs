using System;
using System.Collections.Generic;

namespace PingPong.Backend
{
  public class Calc
  {
    public static List<string> GetStringList(int intNum)
    {
      List<string> numList = new List<string> { };

      for (int i = 1; i <= intNum; i++)
      {
        if (i % 5 == 0 && i % 3 == 0)
        {
          numList.Add("ping-pong");
        }
        else if (i % 5 == 0)
        {
          numList.Add("pong");
        }
        else if (i % 3 == 0)
        {
          numList.Add("ping");
        }
        else
        {
          string temp = i.ToString();
          numList.Add(temp);
        }
      }
      return numList;
    }
  }
}
