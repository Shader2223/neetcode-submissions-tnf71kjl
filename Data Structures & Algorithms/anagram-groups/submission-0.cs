public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();

        foreach (string s in strs){
            int[] count = new int[26];

            foreach (char c in s){
                    count[c-'a']++;
                }
                
                string key_index = string.Join(',', count);
                
                if(!res.ContainsKey(key_index)){
                    res[key_index]=new List<string>();
                }
                
                res[key_index].Add(s);
        }
        return res.Values.ToList();
    }
}

