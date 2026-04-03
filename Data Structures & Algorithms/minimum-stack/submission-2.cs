public class MinStack
{
    private int[] array;
    private const int defaultSize = 3;
    private int count = 0;

    public MinStack()
    {
        array = new int[defaultSize];
    }

    private void DoubleArraySize()
    {
        int[] newArray = new int[array.Length * 2];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }

    public void Push(int val)
    {
        if (count == array.Length)
        {
            DoubleArraySize();
        }
        array[count] = val;
        count++;
    }

    public void Pop()
    {
        if (count > 0)
        {
            count--;
        }
    }

    public int Top()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return array[count - 1];
    }

    public int GetMin()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        int minValue = array[0];
        for (int i = 1; i < count; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }

        return minValue;
    }
}
