public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        StringBuilder lcp = new StringBuilder();   
        for(int i=0;i<strs[0].Length;i++){
            char prefix = strs[0][i];
            for(int j=1;j<strs.Length;j++){
                if(i>=strs[j].Length || prefix != strs[j][i]){
                    return lcp.ToString();
                }
            }
            lcp.Append(prefix);
        }
        return lcp.ToString();
    }
}