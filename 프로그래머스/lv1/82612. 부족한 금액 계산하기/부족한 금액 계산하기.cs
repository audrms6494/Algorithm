using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = (long)price * (long)(count+1) * (long)count / 2 - (long)money;
        if (answer < 0)
            return 0;
        else
            return answer;
    }
}