using System;
using System.Text;
using System.Linq;
public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      bool digit = pin.All(char.IsDigit);
			if(digit == true && pin.Length == 4 || pin.Length ==6)
			return true;
			else 
				return false;
    }
	
}
