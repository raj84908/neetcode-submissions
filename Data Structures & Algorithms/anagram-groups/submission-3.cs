public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string,List<string>> KeyList = new Dictionary<string,List<string>>();

        for(int i =0; i < strs.Count(); i++)
        {
            string OrderedString = string.Concat(strs[i].OrderBy(x=>x));
            if(!KeyList.TryGetValue(OrderedString, out var list))
            {
                list = new List<string>();
                KeyList[OrderedString] = list;
            }
            list.Add(strs[i]);
        }

        List<List<string>>allLists = KeyList.Values.ToList();

        return allLists;



    }

}
