using NUnit.Framework;
using System;

namespace DiamondKata
{
  [TestFixture]
  public class Test
  {
    [Test]
    public void Level1()
    {
      Assert.That (Diamond.Create ('A'), Is.EqualTo ("A"));
    }

    [Test]
    public void Level2()
    {
      Assert.That (Diamond.Create ('B'), Is.EqualTo (" A \nB B\n A "));
    }

    [Test]
    public void Level3()
    {
      Assert.That (Diamond.Create ('C'), Is.EqualTo ("  A  \n B B \nC   C\n B B \n  A  "));
    }

    [Test]
    public void Level4()
    {
      Assert.That (Diamond.Create ('D'), Is.EqualTo ("   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   "));
    }
  }
}

