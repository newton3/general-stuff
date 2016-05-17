using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp
{
  public class PalindromeTests
  {
    [TestCase("abccba")]
    [TestCase("abcba")]
    [TestCase("ingirumimusnocteetconsumimurigni")]
    public void is_palindrome(string str)
    {
      Assert.That(Palindrome.IsPalindrome(str), Is.True);
    }

    [TestCase("abccbad")]
    [TestCase("abcbad")]
    public void is_not_palindrome(string str)
    {
      Assert.That(Palindrome.IsPalindrome(str), Is.False);
    }
  }
}
