using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeLink
{
    class Program
    {
        // Node functions
        static void Print(Node<int> p)
        {
            Console.Write("[");
            if (p != null)
            {
                Console.Write(p.GetValue());
                p = p.GetNext();
            }
            while (p != null)
            {
                Console.Write($", {p.GetValue()}");
                p = p.GetNext();
            }
            Console.Write("]");
        }
        static Node<int> Generate_Nodes(int count)
        {
            Random rnd = new Random();
            Node<int> first = new Node<int>(rnd.Next(30) + 1);
            Node<int> last = first;
            for (int i = 1; i < count; i++)
            {
                last.SetNext(new Node<int>(rnd.Next(30) + 1));
                last = last.GetNext();
            }
            return first;
        }
        static int Length(Node<int> p)
        {
            int count = 0;
            while (p != null)
            {
                count++;
                p = p.GetNext();
            }
            return count;
        }
        static Node<int> GetLast(Node<int> p)
        {
            while (p != null)
            {
                if (p.GetNext() == null)
                    return p;
                p = p.GetNext();
            }
            return null;
        }
        static bool Found(Node<int> first, int x)
        {
            while(first != null)
            {
                if (first.GetValue() == x) return true;
                first = first.GetNext();
            }
            return false;
        }
        static int Count(Node<int> first, int number)
        {
            int count = 0;
            while (first != null)
            {
                if (first.GetValue() == number)
                    count++;
                first = first.GetNext();
            }
            return count;
        }

        public Node<int> FindBefore(Node<int> top, Node<int> p)
        {
            while (p != null)
            {
                if (top.GetNext() == p)
                    return top;
                top = top.GetNext();
            }
            return null;
        }
        public int Sum(Node<int> first)
        {
            int sum = 0;
            while (first != null)
            {
                sum += first.GetValue();
                first = first.GetNext();
            }
            return sum;
        }
        public double GetAverage(Node<int> first)
        {
            int count = 0;
            int sum = 0;
            while (first != null)
            {
                sum += first.GetValue();
                count++;
                first = first.GetNext();
            }
            return sum / count;
        }
        static bool IsSorted(Node<int> p)
        {
            bool flag = true;
            while (p != null)
            {
                if (p.GetValue() > p.GetNext().GetValue())
                    flag = false;
            }
            return flag;
        }
        public static Node<int> Prev (Node<int> first, Node<int> p)
        {
            while(first != null)
            {
                if(first.GetNext() == p)
                    return first;
                first = first.GetNext();
            }
            return null;
        }
        
    
      
        static void Main(string[] args)
        {
            Node<int> first = Generate_Nodes(12);
            Print(first);
            Console.ReadKey();
        }
    }
}
