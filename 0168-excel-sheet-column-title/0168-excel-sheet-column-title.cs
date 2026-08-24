using System;
using System.Text;

public class Solution {
    public string ConvertToTitle(int number) {
        StringBuilder columnName = new StringBuilder();
        
        while (number > 0) {
            int rem = (number - 1) % 26;
            columnName.Append((char)(rem + 'A'));
            number = (number - 1) / 26;
        }
        
        char[] charArray = columnName.ToString().ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
