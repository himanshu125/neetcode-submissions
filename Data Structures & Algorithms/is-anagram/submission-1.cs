public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)  return false;

        int[] freqOfs=new int[26];
        int[] freqOft=new int[26];

        for(int i=0;i<s.Length;i++)
            freqOfs[s[i]-'a']++;
        for(int i=0;i<t.Length;i++)
            freqOft[t[i]-'a']++;
        for(int i=0;i<26;i++)
        {
            if(freqOft[i]!=freqOfs[i])    return false;
        }

        return true;

    }
}
