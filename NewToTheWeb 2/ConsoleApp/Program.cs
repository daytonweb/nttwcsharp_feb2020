using Puzzle;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Fizz Buzz!");

      var fb = new FizzBuzz {
        Start = 5,
        Stop = 50,
        Step = 1,
        Replacers = new List<FizzBuzz.NumberReplacer> {
          FizzBuzz.Fizz,
          new FizzBuzz.NumberReplacer((int i, out string replaceText) => {
            if(i % 7 == 0) {
              replaceText = "Bazz";
              return true;
              }
            replaceText = String.Empty;
            return false;
          })
        }
      };
      string solution = fb.Solve();
      Console.WriteLine(solution);
    }
  }
}
