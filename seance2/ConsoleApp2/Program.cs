public static class MesExtensions
{
    public static bool IsAPalindrome (this string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse (chars);
        if(new string(chars).Equals(s))
        {
            return true;
        }
        return false;
    }
}

class String
{
    static void Main(string[] args)
    {
        string s = "kayak";
        Console.WriteLine(s.IsAPalindrome());
    }
}