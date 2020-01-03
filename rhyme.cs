using System;
using System.Text;
public class Program
{
    public static bool DoesRhyme(string str1, string str2)
    {
			str1 = str1.ToLower();
			str2 = str2.ToLower();
			char[] MyChar = {'!','?','.'};
str1 = str1.TrimEnd(MyChar);
			str2 = str2.TrimEnd(MyChar);
			if(str1.Substring(str1.Length - 2) == str2.Substring(str2.Length - 2))
				 return true;
				 else return false;
    }
}
