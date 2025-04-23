namespace CustomList.Models;

public class CustomLists<T>
{
    public T[] _lists = [];

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

    public int IndexOf(T item)
    {
        return Array.IndexOf(_lists, item);


    }

}
