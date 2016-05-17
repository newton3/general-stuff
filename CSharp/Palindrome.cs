namespace CSharp
{
  public static class Palindrome
  {
    public static bool IsPalindrome(string str)
    {
      if (string.IsNullOrEmpty(str))
      {
        return false;
      }

      for (var i = 0; i < str.Length / 2; i++)
      {
        if (str[i] != str[str.Length - 1 - i])
        {
          return false;
        }
      }

      return true;
    }
  }
}
