public class Solution {
    public bool IsPalindrome(string s) {
        string first = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());

        return first.SequenceEqual(first.Reverse());


    }
}
