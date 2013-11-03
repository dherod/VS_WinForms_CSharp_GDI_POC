using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication_GDI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // GDI+
            //DrawUsingGdiPlus(e);

            // GDI
            DrawUsingGdi(e);
        }

        private unsafe void DrawUsingGdi(PaintEventArgs e)
        {
            // Get handle to device context
            IntPtr hdc = e.Graphics.GetHdc();

            // Original example - Draw rectangle with GDI using default pen
            //GDI.Rectangle(hdc, 10, 70, 110, 120);

            // Create new pen to match web site
            int newPenColor = 0x00913d0b; // 0x00BBGGRR from frsoft.com
            int newPenStyle = 0; // PS_SOLID from wingdi.h
            int newPenWidth = 3;
            IntPtr hNewPen = GDI.CreatePen(newPenStyle, newPenWidth, newPenColor);
            IntPtr hPrevPen = GDI.SelectObject(hdc, hNewPen);

            // Draw lines to create logo
            GDI.POINT point = new GDI.POINT();
            // Tic-tac-toe
            GDI.MoveToEx(hdc, 0, 20, &point);
            GDI.LineTo(hdc, 50, 20);
            GDI.MoveToEx(hdc, 0, 30, &point);
            GDI.LineTo(hdc, 50, 30);
            GDI.MoveToEx(hdc, 20, 0, &point);
            GDI.LineTo(hdc, 20, 50);
            GDI.MoveToEx(hdc, 30, 0, &point);
            GDI.LineTo(hdc, 30, 50);
            // Corners
            GDI.MoveToEx(hdc, 0, 20, &point);
            GDI.LineTo(hdc, 20, 0);
            GDI.MoveToEx(hdc, 30, 0, &point);
            GDI.LineTo(hdc, 50, 20);
            GDI.MoveToEx(hdc, 50, 30, &point);
            GDI.LineTo(hdc, 30, 50);
            GDI.MoveToEx(hdc, 20, 50, &point);
            GDI.LineTo(hdc, 0, 30);
            

            // Clean up
            GDI.SelectObject(hdc, hPrevPen);
            GDI.DeleteObject(hNewPen);
            e.Graphics.ReleaseHdc(hdc);
        }

        private void DrawUsingGdiPlus(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 7);
            e.Graphics.DrawLine(pen, 1, 1, 100, 100);
            e.Graphics.DrawLine(pen, 100, 1, 200, 100);
        }
    }
}
