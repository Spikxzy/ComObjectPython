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
    [Guid("40051BA5-014B-415F-B96C-3F94879A046F")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface IResults
    {
        [DispId(1)]
        Coordinates[] GetCoordinates();
    }
}
