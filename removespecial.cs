using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program 
{
  public static string RemoveSpecialCharacters(string str) 
  {
		return string.Join("", str.Where(c => 
                                     Char.IsLetterOrDigit(c) ||
                                     Char.IsWhiteSpace(c) ||
                                     c == '-' ||
                                     c == '_'));
  }
}
