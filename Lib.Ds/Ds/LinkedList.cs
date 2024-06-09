using System.ComponentModel;

namespace Lib.Ds;

public class LinkedList<T>
{
    // public LinkedList(Node<T> header)
    // {
    //     _header = header;
    // }

    private Node<T> _header;
    public Node<T> Header
    {
        get { return _header; }
        set { _header = value; }
    }

    public void Add(T t)
    {
        Node<T> node = new Node<T>(t);
        node.Next = _header;
        _header = node;
    }

    public bool IsEmpty()
    {
        return _header == null;
    }

    public int Size()
    {
        int count = 0;
        Node<T> current = _header;

        while (current != null)
        {
            current = current.Next;
            count++;
        }

        return count;
    }
}