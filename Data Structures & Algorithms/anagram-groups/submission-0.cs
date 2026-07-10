public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var chars = word.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }

            groups[key].Add(word);
        }

        return groups.Values.ToList();
    }
}
