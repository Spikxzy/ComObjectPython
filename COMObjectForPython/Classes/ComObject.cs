using COMObjectForPython.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectForPython.Objects
{
    [Guid("C79A76AA-9D99-4DA5-9B2A-F3BE276906D0")]
    [ClassInterface(ClassInterfaceType.None)]
    [ComVisible(true)]
    [ProgId("PythonComObject")]
    public class ComObject : IComObject
    {
        private Results results;

        public ComObject()
        {
            results = new Results();
        }

        public Coordinates[] Coordinates() => results.GetCoordinates();
    }
}
