using System;

namespace ProjectOnboarding
{
  class Program
  {
    /// <summary>
    /// Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1, in the numerator and denominator of which there are only single-digit numbers: 1/2, 1/3, 1/4, ... 2/3, 2/4, ... 8/9.

    /// Task
    /// UniqueFract() --> sum

    /// Notes:
    /// -Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
    /// -Don't include any values >= 1.
    /// -Both the numerator and denominator are single digit.
    /// </summary>
    /// <returns></returns>
    static double UniqueFract()
    {
      double sum = 0;

      int denominator = 2;
      while (denominator < 10)
      {
        int numerator = 1;
        while (numerator < denominator)
        {
          int divisor = GCD(numerator, denominator);
          if (divisor == 1)
          {
            sum += ((double)numerator / (double)denominator);
          }

          numerator++;
        }

        denominator++;
      }

      return sum;
    }


    //Returns the Greatest common divisor between two numbers
    static int GCD(int x, int y)
    {
      if (y == 0)
      {
        return x;
      }

      return GCD(y, x % y);
    }

    /// <summary>
    /// Consider the following operation on an arbitrary positive integer:

    ///- If n is even -> n / 2
    ///- If n is odd -> n* 3 + 1

    ///Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.
    /// </summary>
    /// <param name="n"></param>
    public static int Collatz(int n)
    {
      int steps = 0;
      while (n > 1)
      {
        steps++;
        if (n % 2 == 0)
        {
          n = n / 2;
        }
        else
        {
          n = n * 3 + 1;
        }
      }
      return steps;
    }




    static void Main(string[] args)
    {
      Console.WriteLine(UniqueFract());


      Console.WriteLine(Collatz(4));
      Console.WriteLine(Collatz(5));
      Console.WriteLine(Collatz(12));
      Console.WriteLine("Enter a String to be reversed");
      string s = Console.ReadLine();
      Console.WriteLine(Program1.Reverse(s));

    }
  }

}
