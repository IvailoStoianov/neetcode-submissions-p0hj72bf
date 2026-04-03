public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[], double>();

        foreach (int[] point in points) {
            double distance = Math.Sqrt(point[0] * point[0] + point[1] * point[1]);
            pq.Enqueue(point, distance);
        }

        int[][] result = new int[k][];
        for (int i = 0; i < k; i++) {
            result[i] = pq.Dequeue();
        }

        return result;
    }
}
