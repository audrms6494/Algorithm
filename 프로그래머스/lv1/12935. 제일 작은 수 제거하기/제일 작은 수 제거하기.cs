using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length == 1)
        {
            arr[0] = -1;
            return arr;
        }
        int minimum = arr.Min();
        int[] answer = arr.Where(num => num != minimum).ToArray();
        return answer;
    }
}