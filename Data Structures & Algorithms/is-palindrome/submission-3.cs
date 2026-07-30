public class Solution {
    public bool IsPalindrome(string s) {
        string AlphaNumericString = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        int first = 0;
        int end = AlphaNumericString.Count()-1;

        while(end > first)
        {
            if(AlphaNumericString[first] == AlphaNumericString[end])
            {
                first++;
                end--;
                continue;
            }
            else{
                return false;
            }
        }
        return true;


    }
}
