using System;


namespace ProjectOnboarding
{
  public class Program1
  {
    public static string Reverse(string str)
    {
      char[] strArr = str.ToCharArray();

      for (int i = 0; i < strArr.Length; i++)
      {
        if (Char.IsUpper(strArr[i]))
        {
          strArr[i] = Char.ToLower(strArr[i]);
        }
        else
        {
          strArr[i] = Char.ToUpper(strArr[i]);
        }
      }
      // Console.WriteLine(strArr);
      return new string(strArr);
    }
  }
}