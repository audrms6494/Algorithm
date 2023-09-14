using System;
public class Solution {
    public string solution(string s) {
        int l = s.Length;
        string answer = "";
        if (l%2 == 0)
        {
            answer = s.Substring(l/2-1, 2);
        }
        else
        {
            answer = s.Substring(l/2, 1);
        }
        return answer;
    }
}