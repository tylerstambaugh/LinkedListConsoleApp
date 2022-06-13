
Deque<int> deque = new Deque<int>();
deque.Push(10);
Console.WriteLine("pushed 10");
deque.Push(20);
Console.WriteLine("pushed 20");

LinkedList<int> theLinkedList = deque.TheLinkedList();

foreach( int i in theLinkedList)
{
    Console.WriteLine($"the queue: {i}");
}

int firstPop = deque.Pop();
Console.WriteLine($"first pop {firstPop}");
int secondPop = deque.Pop();
Console.WriteLine($"second pop {secondPop}");

Console.ReadLine();


public class Deque<T>
{
    LinkedList<T> linkedList = new LinkedList<T>();

    public LinkedList<T> TheLinkedList()
    {
        return linkedList;
    }
    public void Push(T value)
    {
        linkedList.AddLast(value);   
    }

    public T Pop()
    {
        var returnObj = linkedList.Last.Value;
        linkedList.RemoveLast();
        return returnObj;
    }

    public void Unshift(T value)
    {
        linkedList.AddFirst(value);
    }

    public T Shift()
    {
        var returnObj = linkedList.First.Value;
        linkedList.RemoveFirst();
        return returnObj;
    }
}