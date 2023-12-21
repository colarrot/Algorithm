using System;
public class Solution {
    public string solution(string[] seoul) 
    {
        
        int numkim = Array.IndexOf(seoul, "Kim");
        string answer = $"김서방은 {numkim}에 있다";
        return answer;
    }
}