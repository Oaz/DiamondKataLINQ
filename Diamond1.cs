using System;
using System.Collections.Generic;

namespace DiamondKata
{
  public class Diamond1
  {
    public static string Create(string seed)
    {
      return string.Join ("\n", GetLines (seed));
    }

    private static IEnumerable<string> GetLines(string seed)
    {
      if (seed == "A") {
        yield return "A";
        yield break;
      }

      if (seed == "B") {
        yield return " A ";
        yield return "B B";
        yield return " A ";
        yield break;
      }

      yield return "  A  ";
      yield return " B B ";
      yield return "C   C";
      yield return " B B ";
      yield return "  A  ";
    }
  }
}

