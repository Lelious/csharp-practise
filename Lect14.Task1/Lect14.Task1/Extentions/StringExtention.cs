public static class StringExtension
{
    public static void StringUpdate(this string str)
    {
        if (str.Length >= 5)
        {
            while (str.Length > 5)
            {
                str = str.Remove(str.Length-1);
            }

            str +="...";
            System.Console.WriteLine(str);
        }
    }
}
