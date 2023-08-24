using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for (int i = 2; i * i <= n-1; i++)
        {
            if ((n-1) % i == 0)
            {
                answer = i;
                break;
            }
        }
        if (answer == 0)
        {
            answer = n-1;
        }
        return answer;
    }
}