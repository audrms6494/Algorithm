public class Solution {
    public int solution(string s) {
        int answer = 0;
        if (s[0] == '-')
        {
            answer = -int.Parse(s.Substring(1));
        }
        else if (s[0] == '+')
        {
            answer = int.Parse(s.Substring(1));
        }
        else
        {
            answer = int.Parse(s);
        }
        return answer;
    }
}