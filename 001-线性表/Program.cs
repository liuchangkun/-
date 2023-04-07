using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;



namespace _001_线性表
{
    internal class Program
    {
        static void Main(string[] args)
        {


            test();
            while (true)
            {
                
            }

        }



       static void test()
        {
            //LinkList<string> linkList = new LinkList<string>();



            //for (int i = 0; i <= 100000; i++)
            //{
            //    linkList.Append(i.ToString());
            //}







            //linkList.Clear();


            //GC.Collect();

            List<string > aList= new List<string>();


            for (int i = 0; i <= 999999999; i++)
            {
                aList.Append("哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈哈");
            }

            aList.Clear();

            Console.WriteLine("生产完毕");
        }


    }
}
