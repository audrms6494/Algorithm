public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int sum = 0;
        int length = 0;
        foreach (int i in arr)
        {
            sum += i;
            length += 1;
        }
        answer = (double) sum / length;
        return answer;
    }
}