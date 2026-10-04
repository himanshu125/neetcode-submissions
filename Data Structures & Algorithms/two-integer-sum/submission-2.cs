public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            int x=0,y=0;
            Dictionary<int,int>lookup = new Dictionary<int,int>();
         
            for(int i=0;i<nums.Length;i++)
            {
                if(lookup.ContainsKey(nums[i]))
                {
                    x=i;
                    y=lookup[nums[i]];
                    break;
                }
                else
                lookup.Add(target-nums[i],i);
            }

            return new int[2]{y,x};
    }
}
