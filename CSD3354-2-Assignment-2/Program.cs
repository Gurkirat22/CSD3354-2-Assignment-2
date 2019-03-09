using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSD3354_2_Assignment_2
//Gurkirat Singh C0732169
//Manvir Singh C0730069
//CSD3354 Section 2
//Assignment 2
//March 8,2019
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises de = new DelegateExcercises();
            de.Method3();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        public int Method1(int intMethod1)
        {
            return intMethod1 * 2;
        }
        public int Method2(int intMethod2)
        {
            return intMethod2 * 10;
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
        }
    }
}