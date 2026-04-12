namespace LeetAlejoCode.Easy;

//9
public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        int tmp = x;
        int newNumber = 0;

        while (tmp > 0)
        {
            newNumber = (newNumber * 10) + (tmp % 10);
            tmp = tmp / 10;
        }
        
        return newNumber == x;

    }
}