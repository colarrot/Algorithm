using System;
public class Solution {
    public int solution(int num) 
    {
        int answer = 0;
        long n = num;
        
        while (n != 1)
        {
            if (answer == 500) // 500번 반복했는데도 1이 되지 않으면 -1 반환
            {
                answer = -1;
                break;
            }

            if (n % 2 == 0) // 짝수이면 2로 나눔
            {
                n /= 2;
            }
            else // 홀수이면 3을곱하고 1을더함
            {
                n = n * 3 + 1;
            }

            answer++;
        }
        
        
        return answer;
    }
}