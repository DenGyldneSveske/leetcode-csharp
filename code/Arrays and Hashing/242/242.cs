namespace CheckForAnagram
{
    public class IsAnagramClass
    {
        public bool IsAnagram(string s, string t)
        {
            char[] firstWord = s.ToCharArray();
            Array.Sort(firstWord);
            char[] secondWord = t.ToCharArray();
            Array.Sort(secondWord);

            return Enumerable.SequenceEqual(firstWord, secondWord);
        }
    }
}