using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水管
{
    class Class1
    {
        public int m, n;
        public int[,] arr;
        public bool t;
        public bool[,] book;
        public Class1(int x,int y)
        {
            m = x;
            n = y;
            t = false;
            arr = new int[x, y];
            book = new bool[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    book[i, j] = false;
                }                    
            }               
        }
        private Class1()
        {

        }
    }
}
