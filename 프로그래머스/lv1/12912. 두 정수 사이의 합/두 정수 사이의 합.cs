public class Solution {
    public long solution(int a, int b) {
        long num = 0;
        if (b > a)
        {
            num = (long) b - a + 1;
        }
        else {
            num = (long) a - b + 1;
        }
        long mid = (long) (a+b)/2;
        long answer = 0;
        if (num % 2 == 1)
        {
            answer = num * mid;
        }
        else
        {
            if (mid >= 0)
            {
                answer = num * mid + num / 2;
            }
            else
            {
                answer = num * mid - num / 2;
            }
        }
        return answer;
    }
}