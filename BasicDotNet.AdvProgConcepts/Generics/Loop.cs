using System.Collections;
using System.Collections.Generic;

namespace BasicDotNet.AdvProgConcepts
{

    public class Loop<T>: IEnumerable<T>
    {
        LinkedList<T> loop = new LinkedList<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return loop.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            loop.AddLast(item);
        }

        public void Left()
        {
            LinkedListNode<T> first = loop.First;        
            loop.RemoveFirst();        
            loop.AddLast(first);        
        }

        public void Rigth()
        {
            LinkedListNode<T> last = loop.Last;    
            loop.RemoveLast();
            loop.AddFirst(last);
        }

        public T PopOut()
        {
            T first = loop.First.Value;
            loop.RemoveFirst();
            return first;
        }

        public T ShowFirst()
        {
            return loop.First.Value;
        }
    }
}
