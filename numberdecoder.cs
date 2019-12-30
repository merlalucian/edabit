using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program 
{
    public static string TextToNum(string phone) 
    {
			phone = Regex.Replace(phone, @"[abcABC]", "2");
phone = Regex.Replace(phone, @"[defDEF]", "3");
			phone = Regex.Replace(phone,@"[ghiGHI]", "4");
				phone = Regex.Replace(phone,@"[ghiGHI]", "4");
				phone = Regex.Replace(phone,@"[jklJKL]", "5");
				phone = Regex.Replace(phone,@"[mnoMNO]", "6");
				phone = Regex.Replace(phone,@"[pqrsPQRS]", "7");
				phone = Regex.Replace(phone,@"[tuvTUV]", "8");
				phone = Regex.Replace(phone,@"[WXYZwxyz]", "9");
			
			return phone;
    }
}
