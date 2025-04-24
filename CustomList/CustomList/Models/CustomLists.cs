namespace CustomList.Models;

public class CustomLists<T>
{
    public T[] _lists = [];
    public int Count => _lists.Length;
    public T this [int index] => _lists[index];

    public void Add(T item)
    {
        if (_lists.Contains(item)) return;

        Array.Resize(ref _lists, _lists.Length + 1);
        _lists[^1] = item;
    }

    public bool Remove(T item)
    {
        return RemoveAt(IndexOf(item));
    }
    // 0   1    2     3    4   5
    // A   B    C     D    E   F    
    public bool RemoveAt(int index)
    {
        if (index < 0 || index >= _lists.Length) return false;
        Array.Copy(_lists, index + 1, _lists, index, _lists.Length - index - 1);
        Array.Resize(ref _lists, _lists.Length - 1);
        return true;
    }

    public bool RemoveAll(Predicate<T> predicate)
    {
        bool Isremove = false;
        for (int i=0; i < _lists.Length;)
        {
            if (predicate(_lists[i]))
            {
                RemoveAt(i);
                Isremove = true;
            }
            
        }
        return Isremove;
    }

    public int IndexOf(T item)
    {
        return Array.IndexOf(_lists, item);

    }

    public T? Find(Predicate<T> predicate)
    {
        foreach ( var item in _lists)
        {
            if (predicate (item))
                return item; 
        }
        return default;
    }

    public CustomLists<T> FindAll(Predicate<T> predicate)
    {
        CustomLists<T> result = new();
        foreach (var item in _lists)
        {
            if (predicate(item))
                result.Add(item);
        }
        return result;
    }



}
