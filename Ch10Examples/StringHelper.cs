namespace Ch10Examples
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}