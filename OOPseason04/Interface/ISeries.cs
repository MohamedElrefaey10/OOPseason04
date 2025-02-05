using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPseason04.Interface
{
    internal interface ISeries
    {
        public int Current { get; set; }

        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }

    }
    class SeriesByTwo : ISeries
    {
        public int Current { get  ; set  ; }

        public void GetNext()
        {
            Current += 2;
        }

        
    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

        
    }
}
