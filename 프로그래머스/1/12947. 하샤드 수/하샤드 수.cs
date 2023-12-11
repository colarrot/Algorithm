public class Solution
{
    public bool solution(int x) 
    {
        int numsum = CalculateNumSum(x);
        return x % numsum == 0;
    }
    
    public int CalculateNumSum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}