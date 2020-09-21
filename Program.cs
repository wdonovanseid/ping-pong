using System;
using System.Collections.Generic;
using PingPong.Backend;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringNum = Console.ReadLine();
      int intNum = int.Parse(stringNum);

      List<string> numList = Calc.GetStringList(intNum);

      foreach (string element in numList)
      {
        Console.WriteLine(element);
      }
    }
  }
}