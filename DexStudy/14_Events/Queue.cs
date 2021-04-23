using System;
using System.Collections.Generic;
using System.Collections;

namespace _14_Events
{
    public class Queue<T> : IEnumerable<T>
    {
        Node<T> head; 
        Node<T> tail; 
        int count;
        const int n = 3;


        public delegate void EventHandler();
        public event EventHandler QueueOverflowed;
        public event EventHandler QueueIsEmpty;
        public void Enqueue(T data)
        {
            if (count >= n)
            {
                OnQueueOverflowed();
            }
            else
            {
                Node<T> node = new Node<T>(data);
                Node<T> tempNode = tail;
                tail = node;
                if (count == 0)
                    head = tail;
                else
                    tempNode.Next = tail;
                count++;
            }
        }
        
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            if (count == 0)
                OnQueueIsEmpty();
            return output;
        }
        
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
       
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        public int Count
        { 
            get
            {
                return count;
            }
        }

       protected void OnQueueOverflowed()
        {
            if (QueueOverflowed != null)
            {
                QueueOverflowed?.Invoke();
            }
        }

        protected void OnQueueIsEmpty()
        {
            if (QueueIsEmpty != null)
            {
                QueueIsEmpty?.Invoke();
            }
        }
        
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
            OnQueueIsEmpty();
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

}
