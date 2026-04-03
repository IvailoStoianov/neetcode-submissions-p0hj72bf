public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int, int>();
        foreach(int stone in stones)
        {
            pq.Enqueue(stone, stone*(-1));
        }
        while (pq.Count > 1) {

            int x = pq.Dequeue();
            int y = pq.Dequeue();

            if(x==y)
            {
                continue;
            }
            pq.Enqueue(x-y,(x-y)*(-1));
        }
        if(pq.Count == 0)
        {
            return 0;
        }
        return pq.Dequeue();
    }
}
