using System;
using System.Collections.Generic;
using System.Linq;

namespace LnDCSharpProj1
{
    class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                _list.Add(obj);
            }
            else
            {
                //Console.WriteLine("Stack is null or empty");
                throw new InvalidOperationException("Cannot add null object to stack");
            }
        }

        public object Pop()
        {
            if ((_list != null) || (!_list.Any()))
            {
                int numElements = _list.Count();
                object poppedElem = _list[numElements - 1];
                _list.RemoveAt(numElements - 1);
                //return _list;
                return poppedElem;

            }
            else
            {
                throw new InvalidOperationException("Stack is null or empty");
                //Console.WriteLine("Stack is null or empty");
                //return _list;
            }
        }

        public void Clear()
        {
            if ((_list != null) || (!_list.Any()))
            {
                _list.Clear();
               
            }
            else
            {
                throw new InvalidOperationException("Stack is null or empty");
                //Console.WriteLine("Stack is null or empty");
            }

        }


        public void printStack()
        {
            if ((_list != null) || (!_list.Any()))
            {
                for (int i = 0; i < _list.Count(); i++)
                {
                    Console.WriteLine(_list[i]);
                }
            }
            else
            {
                throw new InvalidOperationException("Stack is null or empty");
                //Console.WriteLine("Stack is null or empty");
            }
        }
    }
}

