using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabeStack
{
    public class StringStack
    {

        private readonly string[] _stack;
        private int _index;
        public bool IsEmpty
        {
            get { return _index == -1; }
        }
        public int Count { 
            get { return _index + 1; }
        }

        public bool IsFull
        {
            get { return _index == _stack.Length - 1; }
        }
        
        public StringStack(int size )
        {
            _stack = new string[size];
            _index = -1;
        }
            


        // Einen Wert auf den Stack legen
        public void Push(string val)
        {
            if(IsFull)
            {
                return;
            }

            _index++;
            _stack[_index] = val;
        }

        // Obersten Wert zurückgeben und entfernen
        public string Pop()
        {
            if (IsEmpty)
            {
                return null!;
            }

            string value = _stack[_index];
            _stack[_index] = null!;
            _index--;

            return value;

        }

        public string Peek()
        {
            if (IsEmpty)
            {
                return null!;
            }
            return _stack[_index];
        }

        public void Swap()
        {
            if(Count < 2)
            {
                return;
            }

            string temp = _stack[_index];
            _stack[_index] = _stack[_index - 1];
            _stack[_index - 1] = temp;
        }
        
        public void Clear()
        {
            Array.Clear(_stack, 0, _stack.Length);
            _index = -1;
        }

        public string ToString()
        {

            string result = "";

            if (IsEmpty)
            {
                return "Stack is leer.";
            }for(int i = _index; i>= 0; i--)
            {
                result += _stack[i];

                if (i > 0)
                {
                    result += ", ";
                }
            }
            return result;

        }
    }
}
