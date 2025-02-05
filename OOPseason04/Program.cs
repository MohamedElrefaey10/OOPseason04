using System.Xml.Serialization;
using OOPseason04.Interface;

namespace OOPseason04
{
    internal class Program
    {
        public static void Print10NumberFromSeries(ISeries Series)
        {
            if (Series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Series.Current);
                    Series.GetNext();
                }
                Series.Reset();
            }
        }
        //public static void Print10NumberFromSeries(SeriesByTwo Series)
        //{
        //    if (Series is not null) 
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(Series.Current);
        //            Series.GetNext();
        //        }
        //        Series.Reset();
        //    }

        //}
        //public static void Print10NumberFromSeries(SeriesByThree Series)
        //{
        //    if (Series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(Series.Current);
        //            Series.GetNext();
        //        }
        //        Series.Reset();

        //    }

        //}
        static void Main(string[] args)
        {

            #region Interface

            //IMyType myType = new IMyType();

            //MyType myType = new MyType();

            ////myType.myfun();
            ////myType.Salary = 5000;

            ////myType.print();

            //IMyType myType1 = new MyType();

            //myType1.Salary = 6000;
            //myType1.myfun();
            //myType1.print();

            #endregion

            #region Interface Example

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumberFromSeries(seriesByTwo);

            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10NumberFromSeries(seriesByThree);

            #endregion

            #region Implicit and Explict Implement Interface

            //AirPlane airPlane = new AirPlane();
            //airPlane.Forword();

            IFlyable AirPlane = new AirPlane();
            AirPlane.Forword();

            IMoveble AirPlane2 = new AirPlane();
            AirPlane2.Forword();
            #endregion


        }
    }
}
