using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Lib.Ds;

public class LinkedList<T>
{
    public LinkedList() { }

    public LinkedList(T t)
    {
        _header = new Node<T>(t);
    }

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

    public void Insert(T t, int index)
    {
        if (index == 0)
        {
            Add(t);
        }
        else
        {
            int position = 0;
            Node<T> current = _header;
            Node<T> node = new Node<T>(t);
            while (position < index - 1)
            {
                position++;
                current = current.Next;
            }
            node.Next = current.Next;
            current.Next = node;
        }
    }

    public Node<T> Search(T t)
    {
        Node<T> current = _header;
        while (current != null)
        {
            if (Equals(current.Data, t))
            {
                break;
            }
            current = current.Next;
        }
        return current;
    }

    public Node<T> Remove(T t)
    {
        Node<T> current = _header;
        if (_header.Data.Equals(t))
        {
            current = _header;
            _header = _header.Next;
        }
        else
        {
            Node<T> previous = current;
            while (current != null)
            {
                if (current.Data.Equals(t))
                {
                    previous.Next = current.Next;
                    break;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }
        
        return current;
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

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        Node<T> current = null;
        if (_header != null)
        {
            sb.Append(_header.Data);
            current = _header.Next;
        }

        while (current != null)
        {
            sb.Append($"->{current.Data}");
            current = current.Next;
        }

        return sb.ToString();
    }
}