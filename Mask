public class Program 
{
    public static string Maskify(string str) 
    {
      int NUM_ASTERISKS = 4;

        if (str.Length < NUM_ASTERISKS) return str;

        int asterisks = str.Length - NUM_ASTERISKS;
        string result = new string('#', asterisks);
        result += str.Substring(str.Length - NUM_ASTERISKS);
        return result;
    }
}
