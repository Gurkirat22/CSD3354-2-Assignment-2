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

    public class Program
    {
        private static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();

    public class DelegateExcercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }

    }
}