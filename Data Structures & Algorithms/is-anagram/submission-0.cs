public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sCharArray = s.ToCharArray();
        char[] tCharArray = t.ToCharArray();

        if (sCharArray.Length != tCharArray.Length)
        {
            return false;
        }

        Array.Sort(sCharArray);
        Array.Sort(tCharArray);

        for (int i = 0; i < sCharArray.Length; i++)
        {
            if (sCharArray[i] != tCharArray[i])
            {
                return false;
            }
        }

        return true;
    }
}
