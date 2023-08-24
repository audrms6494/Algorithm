using System;
public class Solution {
    public int[] solution(long n) {
        string nString = n.ToString();
        int[] answer = new int[nString.Length];
        for (int i = 0; i < nString.Length; i++)
        {
            answer[i] = (int)Char.GetNumericValue(nString[nString.Length - 1 - i]);
        }
        return answer;
    }
}