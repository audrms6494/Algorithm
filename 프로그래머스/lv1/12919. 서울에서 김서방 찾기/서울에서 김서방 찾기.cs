using System;
public class Solution {
    public string solution(string[] seoul) {
        int num = Array.IndexOf(seoul, "Kim");
        string answer = $"김서방은 {num}에 있다";
        return answer;
    }
}