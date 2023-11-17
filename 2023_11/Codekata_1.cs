public class Solution
{
    public string solution(int num)
    {
        string answer = "";

        if (num % 2 == 1) // 2로나누었을때 나머지가 1 = 홀수
        {
            answer = "Odd";
        }

        else if (num % 2 == 0) // 2로나누었을때 나머지가 0 = 홀수
        {
            answer = "Even";
        }
        return answer;
    }

}
