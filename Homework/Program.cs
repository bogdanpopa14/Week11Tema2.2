using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringOperations;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                
                
        }


        private static void LinkList3El()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            int numara = 0;

            foreach (var item in list)
            {
                numara++;
                if (numara == list.Count - 2)
                {
                    Console.WriteLine(item);
                }
            }
        }

       
    }
}
