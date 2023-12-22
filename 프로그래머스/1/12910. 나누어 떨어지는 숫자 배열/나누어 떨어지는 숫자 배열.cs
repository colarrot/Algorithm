using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) 
    {
        // divisor로 나누어 떨어지는 값을 필터링하여 배열을 생성
        int[] divNum = arr.Where(num => num % divisor == 0).ToArray();

        // 나누어 떨어지는 값이 하나도 없으면 -1을 담은 배열 반환
        if (divNum.Length == 0)
            return new int[] { -1 };

        // 나누어 떨어지는 값이 있는 경우 정렬하여 반환
        Array.Sort(divNum);
        return divNum;
    }
}