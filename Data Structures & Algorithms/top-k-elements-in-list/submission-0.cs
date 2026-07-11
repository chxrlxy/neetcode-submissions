public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dictFreq = new Dictionary<int, int>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {

            if (dictFreq.ContainsKey(nums[i])) {
                continue;
            }

            int frequency = 1;

            for (int z = i + 1; z < nums.Length; z++) {
                if (nums[z] == nums[i]) {
                    frequency++;
                }
                else
                {
                    continue;
                }
            }

            dictFreq[nums[i]] = frequency;
        }

        var solution = new List<int>();

        for (int z = 1; z < k + 1; z++) {
            var maxKVP = dictFreq.MaxBy(kvp => kvp.Value);
            solution.Add(maxKVP.Key);
            dictFreq.Remove(maxKVP.Key);
        }
        
        return solution.ToArray();
    }
}
