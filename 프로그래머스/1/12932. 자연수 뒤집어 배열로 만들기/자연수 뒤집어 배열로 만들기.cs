using System.Collections.Generic;
public class Solution {
    List<int> a = new List<int>();
    public int[] solution(long n)     {
        int[] answer = new int[0] ;
        while(n > 0)
        {
            int m = (int)(n%10);
            a.Add(m);
             n/=10;
        }
        answer = a.ToArray();
        return answer;
    }
}