using COMObjectForPython.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectForPython.Objects
{
    [Guid("C6E5ED6D-D289-4F8F-8FB3-7280E2CE6932")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    public class Results : IResults
    {
        public Results()
        {
            coordinates = new Coordinates[] { new Coordinates(1,1), new Coordinates(2,2), new Coordinates(3,3) };
        }

        public Coordinates[] GetCoordinates() => coordinates;

        private Coordinates[] coordinates;
    }
}
