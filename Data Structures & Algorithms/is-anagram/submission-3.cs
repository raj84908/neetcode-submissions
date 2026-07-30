public class Solution {
    public bool IsAnagram(string s, string t) {


        if(s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char,int> CharCountS = new Dictionary<char,int>();
        Dictionary<char,int> CharCountT = new Dictionary<char,int>();

        foreach(char x in s) //O(n)
        {
            if(CharCountS.ContainsKey(x))
            {
                CharCountS[x]++;

            }
            else
            {
                CharCountS[x] = 1;
            }
        }
        foreach(char y in t) //O(n)
        {
            if(CharCountT.ContainsKey(y))
            {
                CharCountT[y]++;

            }
            else
            {
                CharCountT[y] = 1;
            }
        }

        foreach(KeyValuePair<char,int>entry in CharCountS) //O(n)
        {
            if(!CharCountT.ContainsKey(entry.Key))
            {
                return false;
            }
            else if(CharCountT[entry.Key] != entry.Value)
            {
                return false;
            }

        }
        return true;


    }


    //Thoughts and explanantion
    //I created 2 seperate dictionaries that keep the char value and number count of
    //each string. Then I go through each string and count the characters.
    // At the end I compare the counts and see if both of the dicts have the same nums of chars.
}
