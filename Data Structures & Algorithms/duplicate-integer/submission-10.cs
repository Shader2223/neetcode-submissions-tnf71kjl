public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> duplicate = new HashSet<int> ();

        for(int i=0; i<nums.Length;i++){
            if(duplicate.Contains(nums[i])){
                return true;
            }
            duplicate.Add(nums[i]);
        }
        return false;
    }
}