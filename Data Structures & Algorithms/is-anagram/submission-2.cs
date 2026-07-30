public class Solution {
    public bool IsAnagram(string s, string t) {

        Dictionary<char, int> DictS = FillDict(s);
        Dictionary<char, int> DictT = FillDict(t);

        foreach(KeyValuePair<char,int> entry in DictS)
        {
            if(!DictT.ContainsKey(entry.Key))
            {
                return false;
            }
            else if(entry.Value != DictT[entry.Key])
            {
                return false;
            }
        }

        return DictS.Count() == DictT.Count();



    }

    public Dictionary<char,int> FillDict(string x)
    {
        Dictionary<char, int> DictX = new Dictionary<char,int>();
        foreach(char c in x)
        {
            if(DictX.ContainsKey(c))
            {
                DictX[c]++;

            }
            else
            {
                DictX.Add(c,1);
            }
        }

        return DictX;

    }
}
