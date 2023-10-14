using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        private int count;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public int Count
        {
            get
            {
                int count = 0;
                IntNode p = first;
                while (p != null)
                {
                    count++;
                    p = p.Next;
                }
                return count;
            }
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                first = last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddLast(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public string SearchX(int x)
        {
            IntNode p = first;
            while(p != null)
            {
                if(p.Data == x)
                {
                    return "found";
                }
                p = p.Next;
            }
            return "not found";
        }
        public int GetMax()
        {
            IntNode p = first;
            int max = p.Data;
            while (p != null)
            {
                if(p.Data > max)
                {
                    max = p.Data;
                }
                p = p.Next;
            }
            return max;
        }
        public int GetMin()
        {
            IntNode p = first;
            int min = p.Data;
            while (p != null)
            {
                if (p.Data < min)
                {
                    min = p.Data;
                }
                p = p.Next;
            }
            return min;
        }
        public void GetEvenList()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 == 0) 
                {
                    Console.Write("{0} -> ", p.Data);                 
                }
                p = p.Next;

            }
            Console.WriteLine("null");
        }
        public void GetOddList()
        {
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    Console.Write("{0} -> ", p.Data);
                }
                p = p.Next;

            }
            Console.WriteLine("null");
        }
        public void JoinList(MyList secondList)
        {
            if (secondList.IsEmpty())
            {
                return;
            }

            if (IsEmpty())
            {
                first = secondList.First;
                last = secondList.Last;
            }
            else
            {
                last.Next = secondList.First;
                last = secondList.Last;
            }
        }


    }

}   
