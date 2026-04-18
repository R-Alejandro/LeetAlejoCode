namespace LeetAlejoCode.Easy;
//258
public class AddDigits
{
    public static int Solution(int num)
    {
        //bruh, encontrar el root number
        if (num == 0)
            return 0;
        
        if (num % 9 == 0)
            return 9;
        return num % 9;
    }
}