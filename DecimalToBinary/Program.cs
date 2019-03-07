using System;
using System.Collections.Generic;
using System.Linq;

namespace DecimalToBinary
{
  class Program
  {
    static void Main(string[] args)
    {
      var entry = "";
      var parsed = false;
      var number = 0;
      do
      {
        Console.Write("Enter an integer: ");
        entry = Console.ReadLine();
        parsed = int.TryParse(entry, out number);
      } while (!parsed);
      var quotient = number;
      List<int> remainders = new List<int>();
      do
      {
        remainders.Add(quotient % 2);
        quotient /= 2;
      } while (quotient != 0);
      remainders.Reverse();
      var binary = string.Join("", remainders.ToArray());
      Console.WriteLine($"Decimal: {number}, Binary: {binary}");
      Console.ReadKey();
    }
  }
}
