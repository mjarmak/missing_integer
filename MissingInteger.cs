using System;
using System.Linq;

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
            if (A.Max() <= 0)
                return 1;
        
            int number = A.Max()+1;

            int[] S = new int[A.Max()];

            foreach (int i in A)
                if(i > 0)
                    S[i-1] = 1;

            for(int i =0; i < S.Length; i++)
            {
                if (S[i] == 0)
                {
                    number = i + 1;
                    break;
                }
            }
            return number;
    }
}