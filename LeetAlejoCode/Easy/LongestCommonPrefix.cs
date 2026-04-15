namespace LeetAlejoCode.Easy;

public class LongestCommonPrefix
{
    public static string Solution(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            string prefixTemp = string.Empty;
            int count = 0;

            if (prefix.Length >= strs[i].Length)
            {
                count = strs[i].Length;
            }
            else
            {
                count = prefix.Length;
            }

            for (int x = 0; x < count; x++)
            {
                if (strs[i][x] != prefix[x])
                {
                    break;
                }
                prefixTemp += strs[i][x];
            }
            
            prefix = prefixTemp;
            if (prefix.Length == 0)
                return "";
        }

        return prefix;
    }
}