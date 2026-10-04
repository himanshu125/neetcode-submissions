public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int>hasDuplicateOrNot = new HashSet<int>();

        for(int i=0;i<nums.Length;i++)
        {
            hasDuplicateOrNot.Add(nums[i]);
        }
        
        return !(nums.Length==hasDuplicateOrNot.Count);
    }
}