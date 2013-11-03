using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_GDI1
{
    public class GDI
    {
        public struct POINT
        {
            long x;
            long y;
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool Rectangle(
           IntPtr hdc,
           int ulCornerX, int ulCornerY,
           int lrCornerX, int lrCornerY);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern IntPtr CreatePen(
            int fnPenStyle,
            int nWidth,
            int crColor //0x00BBGGRR
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern IntPtr SelectObject(
            IntPtr hdc,
            IntPtr hgdiobj
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool DeleteObject(
            IntPtr hObject
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern unsafe bool MoveToEx(
          IntPtr hdc,
          int X,
          int Y,
          POINT* lppoint
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool LineTo(
           IntPtr hdc,
           int nXEnd,
           int nYEnd
        );
    }
}
