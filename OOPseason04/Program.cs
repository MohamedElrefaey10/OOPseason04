using System.Xml.Serialization;
using OOPseason04.Interface;

namespace OOPseason04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Interface

            //IMyType myType = new IMyType();

            MyType myType = new MyType();

            //myType.myfun();
            //myType.Salary = 5000;

            //myType.print();
            
            IMyType myType1 = new MyType();

            myType1.Salary = 6000;
            myType1.myfun();
            myType1.print();

            #endregion

        }
    }
}
