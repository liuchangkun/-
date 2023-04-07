using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    internal class Node<T>
    {

        private T _data;//存储数据
        private Node<T> _next;//指针，指向下一个元素

        ~Node()
        {
         //   Console.WriteLine("调用了内存回收 "+this.Data);
        }
        

        public Node()
        {
            _data = default(T);
            _next = null;
        }

        public Node(T value)
        {
            _data = value;
            _next = null;
        }

        public Node(T value, Node<T> next)
        {
            this._data = value;
            this._next = next;
        }


        public Node(Node<T> next)
        {

            _next = null;
        }



        public T Data
        {
            get => _data;
            set => _data = value;
        }

        public Node<T> Next
        {
            get => _next;
            set => _next = value;
        }









    }
}
