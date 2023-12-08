using System;
using System.Linq;

public class Solution {
    public long solution(long n) 
    {
        char[] num = n.ToString().ToCharArray(); // 정수를 문자열로 변환하고 각 자릿수를 배열에 저장
        
        Array.Sort(num);   // 각 자릿수를 내림차순으로 정렬하고 뒤집기
        Array.Reverse(num);
       
        long answer = long.Parse(new string(num)); // 정렬된 자릿수를 문자열로 결합하여 정수로 변환

        return answer;
    }
}