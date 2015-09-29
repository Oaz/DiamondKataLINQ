using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
  public static class Diamond2
  {
    public static string Create(string seed)
    {
      return string.Join ("\n", GetLines (seed));
    }

    private static IEnumerable<string> GetLines(string seed)
    {
      if (seed == "A")
        return "A".ToLines();

      if (seed == "B") {
        var linesA = GetLines ("A").WrapWithSpaces();
        return linesA
          .Concat("B B".ToLines())
          .Concat(linesA);
      }

      var linesB = GetLines ("B").WrapWithSpaces();
      return linesB.Take(2)
        .Concat("C   C".ToLines())
        .Concat(linesB.Take(2).Reverse());
    }

    private static IEnumerable<string> ToLines(this string line)
    {
      yield return line;
    }

    private static IEnumerable<string> WrapWithSpaces(this IEnumerable<string> lines)
    {
      return lines.Select (line => " " + line + " ");
    }

  }

}

