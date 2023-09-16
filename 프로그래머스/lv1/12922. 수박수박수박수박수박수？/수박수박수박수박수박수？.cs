using System;
using System.Linq;
public class Solution {
    public string solution(int n) {
        string s = "수박";
        string answer = String.Concat(Enumerable.Repeat(s, n/2));
        if (n%2 ==1) {answer += "수";}
        return answer;
    }
}