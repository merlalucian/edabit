using System;
using System.Linq;
public class Program 
{
    public static bool IsAnagram(string str1, string str2) 
    {
      str1 = str1.ToLower();
    str2 =  str2.ToLower();
        // Get lenghts of both strings 
        int n1 = str1.Count(); 
        int n2 = str2.Count(); 
  
        // If length of both strings is not 
        // same, then they cannot be anagram 
        if (n1 != n2) { 
            return false; 
        } 
  
      
        char[] a = str1.ToCharArray();

        Array.Sort(a);
​
        str1 = String.Join("", a);
        char[] b = str2.ToCharArray();
​
        Array.Sort(b);
​
       
        str2 = String.Join("", b);
      
  
        for (int i = 0; i < n1; i++) { 
            if (str1[i] != str2[i]) { 
                return false; 
            } 
        } 
  
        return true; 
    } 
}
