public class Solution {
    public long[] solution(int x, int n)  // 메서드 생성
    {        
        long[] answer = new long[n]; // 배열선언
        
        for (int i = 0; i < n; i++)
        {
            answer[i] = (long)x * (i + 1);
        }
        return answer;
    }
}