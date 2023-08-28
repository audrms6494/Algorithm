using System;
public class Solution {
    public long solution(long n) {
        string nString = n.ToString();
        char[] nArr = nString.ToCharArray();
        Array.Sort(nArr);
        Array.Reverse(nArr);
        string ans = new string(nArr);
        long answer = long.Parse(ans);
        return answer;
    }
}