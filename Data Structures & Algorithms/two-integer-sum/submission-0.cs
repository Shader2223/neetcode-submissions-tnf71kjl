public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> checkSums = new Dictionary<int, int>();
        for(int i = 0; i< nums.Length; i++){
            checkSums[nums[i]] = i ; //key = nums value, value = nums index
        }

        for(int i = 0; i < nums.Length; i++){
            int difference = target - nums[i]; 
            if(checkSums.ContainsKey(difference) && checkSums[difference] != i){
                return new int[] {i, checkSums[difference]};
            }
        }
        return new int[0];
    }
}
