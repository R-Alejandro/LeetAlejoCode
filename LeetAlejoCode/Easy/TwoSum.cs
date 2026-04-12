namespace LeetAlejoCode.Easy;

//1
public class TwoSum
{
    // O(n)
    public int[] Soluiton(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int partner = target - nums[i];

            if (map.ContainsKey(partner))
            {
                return new int[] {map[partner], i};
            }
            
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return new int[2];
    }
}