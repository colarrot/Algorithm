using System;

public class Solution 
{
    public int solution(int num1, int num2) 
    {
        double x = (double) num1 / num2;
        int answer = (int) (x * 1000);
        return answer;
    }
}