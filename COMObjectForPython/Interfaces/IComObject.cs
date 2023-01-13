using COMObjectForPython.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectForPython.Interfaces
{
    [ComImport]
    [Guid("C599571D-AF36-4E4B-86B4-DACE967EF7DE")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IComObject
    {
        public Coordinates[] Coordinates();
    }
}
