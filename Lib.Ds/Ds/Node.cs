namespace Lib.Ds;

public class Node<T>
{
    public Node()
    {

    }

    public Node(T data)
    {
        _data = data;
    }

    private T _data;
    public T Data
    {
        get { return _data; }
        set { _data = value; }
    }

    private Node<T> _next;
    public Node<T> Next
    {
        get { return _next; }
        set { _next = value; }
    }

    public override string ToString()
    {
        return _data?.ToString();
    }
}