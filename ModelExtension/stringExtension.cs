namespace ModelExtension
{
    public static class stringExtension
    {
        public static string ToCamelCase(this string phrase)
        {
            string result = string.Empty;

            if (phrase.Length > 0)
            {
                result = phrase.Substring(0, 1).ToLower();
                result += phrase.Substring(1, phrase.Length);
            }

            return result;
        }
    }
}