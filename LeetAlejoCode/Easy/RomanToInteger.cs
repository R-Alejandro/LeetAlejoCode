namespace LeetAlejoCode.Easy;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        var map = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        
        int total = 0;
        int sub = 0;
        for (int i = s.Length - 1 ; i >= 0; i--)
        {
            int current = map[s[i]];
            
            if (current < sub)
            {
                total -= current;
            }
            else
            {
                total += current;
                sub = current;
            }
        }
        
        return total;
    }
}