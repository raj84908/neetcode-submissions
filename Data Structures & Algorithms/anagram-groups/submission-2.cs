public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        List<List<string>> ListString = new List<List<string>>();
        List<string> StringValues = new List<string>(strs);
        Dictionary<string,List<string>> Groups = new Dictionary<string,List<string>>();


        foreach(string x in StringValues)
        {
            string SortedString = new string(x.OrderBy(x=> x).ToArray());
            if(!Groups.ContainsKey(SortedString))
            {
                Groups[SortedString] = new List<string>();
            }
            Groups[SortedString].Add(x);
        }


        return Groups.Values.Select(x=>x.ToList()).ToList();
       
    }

    public bool isAnagram(string x, string y)
    {

        if(x.Length != y.Length) return false;

        return x.OrderBy(x=> x).SequenceEqual(y.OrderBy(y=>y));

    }
}
