using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Flight
    {
        private string flNum;
        private string origin;
        private string destination;
        public Flight(string flNum, string origin, string destination)
        {
            this.flNum = flNum;
            this.origin = origin;
            this.destination = destination;
        }
        public string FlNum { get { return flNum; } }
        public string Origin { get { return origin; } }
        public string Destination { get { return destination; } }
    }
}
