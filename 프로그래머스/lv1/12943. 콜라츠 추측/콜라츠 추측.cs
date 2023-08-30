public class Solution {
    public int solution(int num) {
        int count = 0;
        if (num == 1)
        {
            return 0;
        }
        while (count < 500)
        {
            count += 1;
            if (num % 2 == 1)
            {
                num = num * 3 + 1;
            }
            else { num /= 2; }
            if (num == 1)
            {
                return count;
            }
        }
        return -1;
        
    }
}