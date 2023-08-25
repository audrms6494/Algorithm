public class Solution {
    public long solution(long n) {
        long min = 1;
        long max = 2;
        long mid = 1;
        while (max*max <= n)
        {
            min *= 2;
            max *= 2;
        }
        while (min <= max)
        {
            mid = (min + max)/2;
            if (mid * mid == n)
            {
                return (mid+1) * (mid+1);
            }
            else if (mid * mid < n)
            {
                min = mid + 1;
            }
            else if (mid * mid > n)
            {
                max = mid - 1;
            }
        }
        return -1;
    }
}