public class Solution {
    public int LengthOfLongestSubstring(string s) {
        //COme back and make better
        if(string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int LongestSequence = 1;
        HashSet<char> HashChar = new HashSet<char>();

        for(int i =0; i < s.Count(); i++)
        {
            HashChar.Clear();
            char CurrentChar = s[i];
            HashChar.Add(CurrentChar);
            int TempSequenceCount = 1;
            for(int j = i+1; j < s.Count(); j++)
            {
                if(!HashChar.Contains(s[j]))
                {
                    TempSequenceCount++;
                    HashChar.Add(s[j]);
                }
                else{
                    break;
                }
                    
                    
            }
            if(TempSequenceCount > LongestSequence)
            {
                LongestSequence = TempSequenceCount;
            }
        }

        return LongestSequence;

    }
}
