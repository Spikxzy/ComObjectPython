using COMObjectForPython.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectForPython.Objects
{
    [Guid("82176C07-D083-486F-A238-7E4E7AB413D9")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Coordinates : ICoordinates
    {
        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        private double x;
        private double y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }
    }

}
