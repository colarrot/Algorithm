using System;

public class Solution {
    public long solution(int a, int b) 
    {
                long sum = 0;  
        if (a == b)
        {
            return a;
        }
        int Fir = Math.Min(a, b);
        int Sec = Math.Max(a, b);
      
        for (int i = Fir; i <= Sec; i++)
        {
            sum += i;
        }

        return sum;
    }
}