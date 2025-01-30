using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPseason04.Interface
{
    internal interface IMyType
    {
        //Default Access Modifier Inside Interface
        // public
        //what you can Write in Interface ?

        //Signature for Property
        int Salary { get; set; }


        //Signature for Method
        void myfun();


        //Default Implemented Method => C# 8 .NETCore 3.1 [2019]

        public void print()
        {
            Console.WriteLine("Hello From Default Implemented method");
        }


    }
    class MyType : IMyType /*Implementation*/
    {
        //private int salary;
        public int Salary { get; set;}//Automatic Prop

        public void myfun()
        {
            Console.WriteLine("Hello Route");
        }
    }
}
