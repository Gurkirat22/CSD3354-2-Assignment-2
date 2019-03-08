using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_Assignment_2
//Gurkirat Singh C0732169
//Manvir Singh C0730069

{
    public class Program
    {
        public delegate void MyDelegate();

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        static void Main(string[] args)
        {

        }
    }
}