using System;
public class Solution {
    public bool solution(string s) {
        bool answer = true;
        if (s.Length != 4 && s.Length != 6)
        {
            answer = false;
        }
        foreach(var c in s)
        {
            if (48 > (int) c || (int) c > 57)
            {
                answer = false;
            }
        }
        return answer;
    }
}