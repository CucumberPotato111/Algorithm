using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestInput();
            Console.ReadLine();
        }
        static void TestInput()
        {
            MyList list1 = new MyList();
            list1.Input();
            Console.WriteLine("DSLK so nguyen list1:");
            list1.ShowList();
            MyList list2 = new MyList();
            list2.Input();
            Console.WriteLine("DSLK so nguyen list2:");
            list2.ShowList();
            MyList list3 = new MyList();
            list3.JoinList(list1);
            list3.JoinList(list2);
            Console.WriteLine("DSLK so nguyen list3:");
            list3.ShowList();

            //Console.WriteLine("Tim gia tri x: " +list1.SearchX(11));

            //Console.WriteLine("Gia tri lon nhat: "+list1.GetMax());

            //Console.WriteLine("Gia tri nho nhat: "+list1.GetMin());

            //Console.WriteLine("Danh sach so chan: ");
            //list1.GetEvenList();
            //Console.WriteLine("Danh sach so le: ");
            //list1.GetOddList();
        }
    }
}
