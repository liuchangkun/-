using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_线性表
{
    public interface IListDs<T>
    {
        int GetLength();//返回长度
        void Clear();//清空

        bool IsEmpty(); //判断是否为空

        void Append(T item);//附加元素
        void Insert(T item, int index);//插入操作
        T Delete(int index);//删除操作
        

        T GetEle(int index);//取表元

        int Locate(T item);//按值查找


    }
}
