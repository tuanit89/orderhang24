namespace Models.StringHelper
{
    public static class StringHelper
    {
        public static string CutWordByLength(this string word, int length)
        {
            if (word.Length <= length) return word;
            var wordA = word.Substring(0, length);
            return word.Substring(0, wordA.LastIndexOf(' '))+"...";
        }
    }
}
