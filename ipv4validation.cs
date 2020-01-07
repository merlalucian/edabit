using System;
using System.Net;
using System.Linq;
public class Program
{
    public static bool IsValidIP(string IP)
    {

		if (IP.Count(c => c == '.') != 3) return false;
    IPAddress address;
    return IPAddress.TryParse(IP, out address);
    }
}
