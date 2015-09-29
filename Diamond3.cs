using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
  public static class Diamond3
  {
    public static string Create(char seed)
    {
      return string.Join ("\n", GetLines (seed));
    }

    private static IEnumerable<string> GetLines(this char seed)
    {
      if (seed == 'A')
        return "A".ToLines();

      if (seed == 'B') {
        var previousLines = seed.Previous().GetLines().ToList();
        var upgradedPreviousLines = previousLines.Take(1).WrapWithSpaces();
        var newLine = (seed + Spaces (previousLines.Count()) + seed).ToLines ();
        return upgradedPreviousLines
          .Concat(newLine)
          .Concat(upgradedPreviousLines.Reverse());
      }

      var previousLines2 = seed.Previous().GetLines().ToList();
      var upgradedPreviousLines2 = previousLines2.Take(2).WrapWithSpaces();
      var newLine2 = (seed + Spaces (previousLines2.Count()) + seed).ToLines ();
      return upgradedPreviousLines2
        .Concat(newLine2)
        .Concat(upgradedPreviousLines2.Reverse());
    }

    private static IEnumerable<string> ToLines(this string line)
    {
      yield return line;
    }

    private static IEnumerable<string> WrapWithSpaces(this IEnumerable<string> lines)
    {
      return lines.Select (line => " " + line + " ");
    }

    private static string Spaces(int length)
    {
      return string.Join (string.Empty, Enumerable.Repeat (' ', length));
    }

    private static char Previous(this char c)
    {
      if (c == 'B')
        return 'A';
      return 'B';
    }

  }

}

