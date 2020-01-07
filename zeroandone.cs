using System.Text.RegularExpressions;

public class Program 
{
    public static string TextToNumberBinary(string str) 
    {
			str = Regex.Replace(str, "zero", "0", RegexOptions.IgnoreCase);
		  str = Regex.Replace(str, "one", "1", RegexOptions.IgnoreCase);
			str = Regex.Replace(str, "[^01]", "");
			
			int newLength = str.Length - (str.Length % 8);
			
			return str.Substring(0, newLength);
    }
}
