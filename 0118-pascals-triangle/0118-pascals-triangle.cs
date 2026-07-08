public class Solution {
    public IList<IList<int>> Generate(int numRows) {
         IList<IList<int>> pascalTriangle = new List<IList<int>>();
        for(int i=0;i<numRows;i++)
        {
           IList<int> row = new List<int>();
           for(int j=0;j<=i;j++)
           {
             if(j==0 || j==i)
             {
                row.Add(1);
             }
             else {
                    IList<int> prevRow = pascalTriangle[i - 1]; 
                    row.Add(prevRow[j - 1] + prevRow[j]);
                  }
           }
           pascalTriangle.Add(row);
        }
        return pascalTriangle;
    }
}