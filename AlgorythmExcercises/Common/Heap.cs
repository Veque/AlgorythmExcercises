using Common.Exceptions;

namespace Common;

public class Heap<T>
{
    private Func<T, T, int> _compare;
    private T[] _innerArray;
        
    public int Count {get; private set;}
        
    public Heap(int capacity, Func<T, T, int> compare)
    {
        _innerArray = new T[capacity];
        _compare = compare;
        Count = 0;
    }
        
    public void Push(T item)
    {
        _innerArray[Count] = item;
        MoveUp(Count);
        Count +=1;
    }
        
    public T Pop()
    {
        if(Count == 0) throw new ArrayIsEmptyException();
            
        var item = _innerArray[0];
            
        _innerArray[0] = _innerArray[Count - 1];
        Count -= 1;
        MoveDown(0);
            
        return item;
    }
        
    private void MoveUp(int index)
    {
        if(index == 0) return;
            
        var parentIndex = (index - 1)/2;
            
        var item = _innerArray[index];
            
        var parent = _innerArray[parentIndex];
        if(_compare(item, parent) == 1)
        {
            _innerArray[parentIndex] = item;
            _innerArray[index] = parent;
                
            MoveUp(parentIndex);
        }
    }
        
    private void MoveDown(int index)
    {
        var item = _innerArray[index];
        var childIndex1 = index*2 + 1;
        var childIndex2 = childIndex1 + 1;
       
        if (childIndex1 < Count)
        {
            var child1 = _innerArray[childIndex1];
            if( _compare(child1, item) == 1)
            {
                _innerArray[childIndex1] = item;
                _innerArray[index] = child1;
                MoveDown(childIndex1);
                return;
            }
        }

        if (childIndex2 < Count)
        {
            var child2 = _innerArray[childIndex2];
            if(_compare(child2, item) == 1)
            {
                _innerArray[childIndex2] = item;
                _innerArray[index] = child2;
                MoveDown(childIndex2);
            }
        }
    }
}