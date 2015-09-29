using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
	public static class Diamond
	{
    public static string Create(char seed)
    {
      return string.Join ("\n", GetLines (seed));
    }

    private static IEnumerable<string> GetLines(this char seed)
    {
      if (seed == 'A')
        return "A".ToLines();

      var previousLines = seed.Previous().GetLines().ToList();
      var firstHalfOfPreviousLinesSurroundedByNewSpaces = previousLines.Take((previousLines.Count+1)/2).WrapWithSpaces();
      var newCentralLine = (seed + Spaces (previousLines.Count) + seed);
      return firstHalfOfPreviousLinesSurroundedByNewSpaces
        .Concat(newCentralLine.ToLines ())
        .Concat(firstHalfOfPreviousLinesSurroundedByNewSpaces.Reverse());
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
      return (char)((int)c - 1);
    }

	}

}

