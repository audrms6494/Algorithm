public class Solution {
    public int solution(int n) {
        int k = 1;
        int answer = 0;
        for (k = 1; k * k <= n; k ++ )
        {
            if (k * k == n)
            {
                answer += k;
            }
            else if (n % k == 0)
            {
                answer += k + (n/k);
            }
        }

        return answer;
    }
}