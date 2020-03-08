using System.Linq;
public class Program 
{
    public static bool IsSmooth(string sentence) 
    {
			 string[] array = sentence.Split(' ');
            int match = 0;
            for (int i = 1; i <= array.Length-1; i++)
            {
                char ch = array[i - 1].Last();
                char ch2 = array[i].First();
                 if (char.ToLower(ch) == char.ToLower(ch2))
                    match++;
                else
                    break;
            }
            if (match == array.Length - 1)
                return true;
            return false;
    }
}
