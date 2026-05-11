using Shared;
using System.Text;

namespace DoubleList;

public class DoubleLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public DoubleLinkedList()
    {
        _head = null;
        _tail = null;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void InsertAtBeginning(T data)
    {
        var newNode = new Node<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
    }

    public void InsertAtEnding(T data)
    {
        var newNode = new Node<T>(data);
        if (_tail == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
        }
    }

    public void InsertOrdered(T data)
    {
        var newNode = new Node<T>(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }

        if (Comparer<T>.Default.Compare(data, _head.Data!) < 0)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
            return;
        }

        var current = _head;
        while (current.Next != null && Comparer<T>.Default.Compare(data, current.Next.Data!) >= 0)
        {
            current = current.Next;
        }

        if (current.Next == null)
        {
            current.Next = newNode;
            newNode.Previous = current;
            _tail = newNode;
        }
        else
        {
            newNode.Next = current.Next;
            newNode.Previous = current;
            current.Next.Previous = newNode;
            current.Next = newNode;
        }
    }

    public void Remove(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current == _head)
                {
                    _head = _head.Next;
                    if (_head != null)
                    {
                        _head.Previous = null;
                    }
                    else
                    {
                        _tail = null;
                    }
                }
                else if (current == _tail)
                {
                    _tail = _tail.Previous;
                    _tail!.Next = null;
                }
                else
                {
                    current.Previous!.Next = current.Next;
                    current.Next!.Previous = current.Previous;
                }
                return;
            }
            current = current.Next;
        }
    }

    public int RemoveAll(T data)
    {
        int removed = 0;
        var current = _head;
        while (current != null)
        {
            var next = current.Next;
            if (current.Data != null && current.Data.Equals(data))
            {
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _head = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _tail = current.Previous;
                }
                removed++;
            }
            current = next;
        }
        return removed;
    }

    public void Reverse()
    {
        var current = _head;
        while (current != null)
        {
            var temp = current.Next;
            current.Next = current.Previous;
            current.Previous = temp;
            current = temp;
        }
        var oldHead = _head;
        _head = _tail;
        _tail = oldHead;
    }

    public void Sort()
    {
        if (_head == null || _head.Next == null)
        {
            return;
        }

        bool swapped;
        do
        {
            swapped = false;
            var current = _head;
            while (current!.Next != null)
            {
                if (Comparer<T>.Default.Compare(current.Data!, current.Next.Data!) > 0)
                {
                    var temp = current.Data;
                    current.Data = current.Next.Data;
                    current.Next.Data = temp;
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }

    public List<T> GetModes()
    {
        var modes = new List<T>();
        if (_head == null) return modes;

#pragma warning disable CS8714
        var frequencies = new Dictionary<T, int>();
#pragma warning restore CS8714
        var current = _head;
        while (current != null)
        {
            if (current.Data != null)
            {
                if (frequencies.ContainsKey(current.Data))
                {
                    frequencies[current.Data]++;
                }
                else
                {
                    frequencies[current.Data] = 1;
                }
            }
            current = current.Next;
        }

        var max = frequencies.Values.Max();

        if (max <= 1) return modes;

        foreach (var kvp in frequencies)
        {
            if (kvp.Value == max)
            {
                modes.Add(kvp.Key);
            }
        }

        modes.Sort();
        return modes;
    }

    public string GetGraph()
    {
        if (_head == null) return "Empty list.";

        // Contar ocurrencias
#pragma warning disable CS8714
        var frequencies = new Dictionary<T, int>();
#pragma warning restore CS8714
        var keys = new List<T>();
        var current = _head;
        while (current != null)
        {
            if (current.Data != null)
            {
                if (frequencies.ContainsKey(current.Data))
                {
                    frequencies[current.Data]++;
                }
                else
                {
                    frequencies[current.Data] = 1;
                    keys.Add(current.Data);
                }
            }
            current = current.Next;
        }

        keys.Sort();

        var sb = new StringBuilder();
        foreach (var key in keys)
        {
            sb.AppendLine($"{key} {new string('*', frequencies[key])}");
        }
        return sb.ToString().TrimEnd();
    }

    override public string ToString()
    {
        var current = _head;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Next;
        }
        result += "null";
        return result;
    }

    public string ToStringReverse()
    {
        var current = _tail;
        var result = string.Empty;
        while (current != null)
        {
            result += $"{current.Data} -> ";
            current = current.Previous;
        }
        result += "null";
        return result;
    }
}
