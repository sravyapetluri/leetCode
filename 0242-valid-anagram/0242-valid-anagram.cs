/*using System.Collections.Generic;
public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length != t.Length){
         return false;
        }
       char[] arr1 = s.ToCharArray();
       char[] arr2 = t.ToCharArray();
    
    Array.Sort(arr1);
    Array.Sort(arr2);
    
    return arr1.SequenceEqual(arr2);
    
    }
} */

public class Solution {
    public bool IsAnagram(string s, string t) {
        int[] alphabet = new int[26];
        for(int i=0;i<s.Length;i++){
            alphabet[s[i]-'a']++;
        }
        for(int i=0;i<t.Length;i++){
            alphabet[t[i]-'a']--;
        }
        for(int i=0;i<alphabet.Length;i++){
            if(alphabet[i]!=0){
                return false;
            }
        }
        return true;
    }
}