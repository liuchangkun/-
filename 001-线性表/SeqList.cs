using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    internal class SeqList<T> : IListDs<T>, IEnumerable, IEnumerator
    {

        private T[] _data;//存储数据
        private int _count = 0;//存储了多少个数据
        private int _MaxCount = 0;

        public SeqList(int size)//size 最大容量
        {
            _data = new T[size];
            _count = 0;
            _MaxCount = size;
        }

        public SeqList() : this(10)//默认构造方法
        {

        }




        public void Append(T item)
        {
            if (_count == _data.Length)
            {
                Console.WriteLine("数组已满！");
            }
            else
            {
                _data[_count] = item;
                _count++;
            }


        }

        public T this[int index]
        {

            get
            {
                return GetEle(index);
            }


            set
            {
                if (index >= 0)
                {

                    _data[index] = value;
                    _count++;
                }
            }
        }
        public void Clear()
        {
            _count = 0;
        }

        public T Delete(int index)
        {
            T temp = _data[index];

            for (int i = index + 1; i < _count; i++)
            {
                _data[i - 1] = _data[i];

            }

            _count--;

            return temp;

        }



        public T GetEle(int index)
        {
            if (index >= 0 && index <= _count - 1)
            {
                return _data[index];
            }
            else
            {
                Console.WriteLine("索引不存在");
                return default(T);
            }
        }


        public int GetLength()//获取数据个数
        {
            return _count;
        }

        public void Insert(T item, int index)
        {

            for (int i = _count - 1; i >= index; i--)
            {

                _data[i + 1] = _data[i];

            }


            _data[index] = item;

            _count++;
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public int Locate(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_data[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }


        int position = -1;
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {

            position++;
            return (position < _data.Length);
        }

        public void Reset()
        {
            position = 0;
        }

        public object Current
        {
            get
            {
                return _data[position];
            }
        }
    }


}
