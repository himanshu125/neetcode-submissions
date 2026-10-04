public class Solution {
            public List<List<string>> GroupAnagrams(string[] strs) {

            List < List<string> > res = new List<List<string>>();

            Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                int[] freq = new int[26];
                foreach (char c in str)
                {
                    freq[c - 'a']++;
                }
                string key = string.Join("#", freq);
                if (!anagramGroups.ContainsKey(key))
                {
                    anagramGroups[key] = new List<string>();
                }
                anagramGroups[key].Add(str);
            }

            foreach (var group in anagramGroups.Values)
            {
                res.Add(group);
            }

            return res;
        }
}
