public class Solution {
    public int Reverse(int x) {
        if (x == int.MinValue) 
        {
            return 0;
        }
        
        bool negative = x < 0;
        string a = Math.Abs(x).ToString();
        char[] s = a.ToCharArray();
        int left = 0, right = s.Length - 1;
    
        while (left < right) 
        {
            // Two-pointer method
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            left++;
            right--;
        }
        
        long reverse = long.Parse(s);
        if (reverse > int.MaxValue) 
        { 
            return 0; 
        }
        else
        {
            return negative ? (int)reverse * -1 : (int)reverse;
        }
    }
}
