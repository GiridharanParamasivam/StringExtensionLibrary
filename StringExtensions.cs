namespace StringExtensionLibrary
{
    public static class StringExtensions // Changed from 'internal' to 'public'
    {
        public static bool StartsWithUpper(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            char firstChar = input[0];
            return char.IsUpper(firstChar);
        }
    }
}
