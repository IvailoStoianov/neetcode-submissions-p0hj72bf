public class LRUCache {
    private Dictionary<int, int> myDict;
    private Queue<int> queue;
    private HashSet<int> inQueue;
    private int _capacity;

    public LRUCache(int capacity) {
        myDict = new Dictionary<int, int>();
        queue = new Queue<int>();
        inQueue = new HashSet<int>();
        _capacity = capacity;
    }

    public int Get(int key) {
        if (!myDict.ContainsKey(key)) return -1;

        if (inQueue.Contains(key)) {
            RemoveFromQueue(key);
        }

        queue.Enqueue(key);
        inQueue.Add(key);
        return myDict[key];
    }

    public void Put(int key, int value) {
        if (myDict.ContainsKey(key)) {
            myDict[key] = value;
            if (inQueue.Contains(key)) RemoveFromQueue(key);
        } else {
            if (myDict.Count == _capacity) {
                int toRemove = queue.Dequeue();
                inQueue.Remove(toRemove);
                myDict.Remove(toRemove);
            }
            myDict[key] = value;
        }

        queue.Enqueue(key);
        inQueue.Add(key);
    }

    private void RemoveFromQueue(int key) {
        var newQueue = new Queue<int>();
        while (queue.Count > 0) {
            int current = queue.Dequeue();
            if (current != key) newQueue.Enqueue(current);
        }
        queue = newQueue;
        inQueue.Remove(key);
    }
}
