using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = String.Concat(s.OrderBy(ch => ch));
        answer = new String(answer.Reverse().ToArray());
        return answer;
    }
}