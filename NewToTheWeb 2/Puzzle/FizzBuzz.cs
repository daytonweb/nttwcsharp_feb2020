using System;
using System.Collections.Generic;
using System.Text;

namespace Puzzle {
  public class FizzBuzz {
    public delegate bool NumberReplacer(int i, out string replaceText);
    public List<NumberReplacer> Replacers { get; set; }
    public int Start { get; set; }
    public int Stop { get; set; }
    public int Step { get; set; }
    public FizzBuzz() {
      Start = 1;
      Stop = 100;
      Step = 1;
      Replacers = new List<NumberReplacer> {
        Fizz,
        Buzz
      };
    }
    public string Solve() {
      var sb = new StringBuilder();
      for(var i = Start; i <= Stop; i += Step) {
        string lineText = GetLineText(i);
        sb.AppendLine(lineText);
      }
      return sb.ToString();
    }
    private string GetLineText(int i) {
      string lineText = String.Empty;
      foreach(var isValidReplacer in Replacers) {
        if(isValidReplacer(i, out string replaceText)) {
          lineText += replaceText;
        }
      }
      if(String.IsNullOrEmpty(lineText)) {
        lineText = i.ToString();
      }
      return lineText;
    }
    public static bool Fizz(int i, out string replaceText) {
      if(i % 3 == 0) {
        replaceText = "Fizz";
        return true;
      }
      replaceText = String.Empty;
      return false;
    }
    public static bool Buzz(int i, out string replaceText) {
      if(i % 5 == 0) {
        replaceText = "Buzz";
        return true;
      }
      replaceText = String.Empty;
      return false;
    }
  }
}
