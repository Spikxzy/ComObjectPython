using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace COMObjectForPython.Interfaces
{
    [ComImport]
    [Guid("9B0465A1-B518-4D72-9DEB-5AE57EA50FA7")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface ICoordinates
    {
        [DispId(1)]
        double getX();

        [DispId(2)]
        double getY();
    }
}
