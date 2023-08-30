using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List <int> temp = new List <int> ();
        foreach (int num in arr)
        {
            if (num % divisor == 0) 
            {
                temp.Add(num);
            }
        }
        if (temp.Count == 0)
        {
            return new int[] {-1};
        }
        temp.Sort();
        int[] answer = temp.ToArray();
        return answer;
    }
}