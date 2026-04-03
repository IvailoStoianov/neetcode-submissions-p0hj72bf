public class Solution {
    public int[] CountBits(int n) {
        List<int> list = new List<int>();
        for(int i = 0; i <= n; i++)
        {
            int counter = 0;
            int crr = i;
            while(crr>0)
            {
                if((crr & 1) == 1)
                {
                    counter++;
                }
                crr = crr >> 1;
            }
            list.Add(counter);
        }
        int[] myArray = list.ToArray();
        return myArray;
    }
}
