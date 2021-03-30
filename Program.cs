using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace 水管
{
    public struct Note<T>
    {
        public T x;
        public T y;
        public Note(T a,T b)
        {
            x = a;
            y = b;
        }
    }
    class Program
    {
        static Class1 myclass = new Class1(5, 4);
        static List<Note<int>> Stack = new List<Note<int>>();
        public static void Dfs(int x, int y, int front)
        {
            if(x==myclass.m-1&&y==myclass.n)
            {
                myclass.t = true;
                foreach(Note<int> i in Stack)
                {
                    Write($"({i.x+1},{i.y+1}) ");
                }
                return;
            }
            if (x >= myclass.m || y >= myclass.n || x < 0 || y < 0)
                return;
            if (myclass.book[x, y])
                return;
            myclass.book[x, y] = true;
            Stack.Add(new Note<int>(x, y));
            if (myclass.arr[x,y]>=5&&myclass.arr[x,y]<=6)
            {
                if (front == 1)
                    Dfs(x, y + 1, 1);
                if (front == 2)
                    Dfs(x + 1, y, 2);
                if (front == 3)
                    Dfs(x, y - 1, 3);
                if (front == 4)
                    Dfs(x - 1, y, 4);
            }
            if (myclass.arr[x, y] >= 1&&myclass.arr[x,y]<=4)
            {
                if(front==1)
                {
                    Dfs(x + 1, y, 2);
                    Dfs(x - 1, y, 4);
                }
                if(front==2)
                {
                    Dfs(x, y + 1, 1);
                    Dfs(x, y - 1, 3);
                }
                if(front==3)
                {
                    Dfs(x - 1, y, 4);
                    Dfs(x + 1, y, 2);
                }
                if(front==4)
                {
                    Dfs(x, y + 1, 1);
                    Dfs(x, y - 1, 3);
                }
            }
            myclass.book[x, y] = false;
            Stack.RemoveAt(Stack.Count - 1);
            return;
        }
        static void Main(string[] args)
        {
            Dfs(0, 0, 1);
            if (!myclass.t)
                WriteLine("不可");
            ReadKey();
        }
    }
}
