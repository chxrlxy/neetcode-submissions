public class Solution {
    public bool hasDuplicate(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
        {
            int value = nums[i];

            for (int z = i + 1; z < nums.Length; z++)
            {
                if (value == nums[z])
                {
                    return true;
                }
            }
        }

        return false;
    }
}