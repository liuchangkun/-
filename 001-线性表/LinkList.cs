using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    internal class LinkList<T> : IListDs<T>
    {
        private Node<T> _head; //头结点


        public LinkList()
        {
            _head = null;
        }


        public T this[int index]
        {
            get
            {
                Node<T> temp = _head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                return temp.Data;
            }

            set
            {

                Node<T> temp = _head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                temp.Data = value;

            }
        }
        public int GetLength()
        {

            if (_head == null)
            {
                return 0;
            }

            int length = 0;

            Node<T> temp = _head;
            while (true)
            {
                temp = temp.Next;
                length++;
                if (temp.Next == null)
                {
                    break;
                }
            }

            return length;
        }

        public void Clear()
        {
            _head = null;

        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void Append(T item)
        {
            Node<T> newNode = new Node<T>(item); //创建一个新的结点

            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node<T> temp = _head;
                while (true)
                {

                    if (temp.Next == null)
                    {
                        break;
                    }

                    temp = temp.Next;
                }

                temp.Next = newNode;
            }
        }

        public void Insert(T item, int index)
        {

            Node<T> newNode = new Node<T>(item); //创建一个新的结点

            Node<T> ernewNode = _head;

            if (index == 0)
            {
                newNode.Next = _head;

                _head = newNode;
            }
            else
            {
                Node<T> temp = _head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }

                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;

                preNode.Next = newNode;
                newNode.Next = currentNode;


            }
        }

        public T Delete(int index)
        {

            T data = default;

            if (index == 0)
            {
                data = _head.Data;
                _head = _head.Next;

            }
            else
            {
                Node<T> temp = _head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;

            }

            return data;

        }

        public T GetEle(int index)
        {

            Node<T> temp = _head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }



            return temp.Data;

        }

        public int Locate(T item)
        {
            throw new NotImplementedException();
        }
    }
}