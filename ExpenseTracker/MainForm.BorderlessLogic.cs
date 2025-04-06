using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker {


    // this is just to stop IDE from gereating resource file for form
    // cause for forms classes to work as forms they need to be a first class in file
    public class PreventResourceFileGeneration2 { }



    public partial class MainForm {



        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public void InitializeBorderlessWindow() {

            // attach to your top panel (title bar)
            TitleBar.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left) {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };

            this.Resize += (s, e) => {

                if (this.WindowState == FormWindowState.Maximized) {
                    var screen = Screen.FromHandle(this.Handle);
                    this.MaximumSize = screen.WorkingArea.Size;
                    this.Location = screen.WorkingArea.Location;
                }
                else {
                    this.MaximumSize = new Size(0, 0); // reset when un-maximized
                }
            };

            bMainFormClose.Click += (s, e) => Close();
            bMainFormMinimize.Click += (s, e) => WindowState = FormWindowState.Minimized;
            bMainFormState.Click += (s, e) => {
                WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            };


            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }


        protected override void WndProc(ref Message m) {
            const int RESIZE_HANDLE_SIZE = 10;
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            const int WM_GETMINMAXINFO = 0x24;

            if (m.Msg == WM_GETMINMAXINFO) {
                WmGetMinMaxInfo(this.Handle, m.LParam);
            }

            if (this.WindowState != FormWindowState.Maximized)
                if (m.Msg == WM_NCHITTEST) {
                    base.WndProc(ref m);
                    var pos = this.PointToClient(new Point(m.LParam.ToInt32()));
                    var width = this.ClientSize.Width;
                    var height = this.ClientSize.Height;

                    if (pos.X <= RESIZE_HANDLE_SIZE) {
                        if (pos.Y <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)HTTOPLEFT;
                        else if (pos.Y >= height - RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)HTBOTTOMLEFT;
                        else
                            m.Result = (IntPtr)HTLEFT;
                    }
                    else if (pos.X >= width - RESIZE_HANDLE_SIZE) {
                        if (pos.Y <= RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)HTTOPRIGHT;
                        else if (pos.Y >= height - RESIZE_HANDLE_SIZE)
                            m.Result = (IntPtr)HTBOTTOMRIGHT;
                        else
                            m.Result = (IntPtr)HTRIGHT;
                    }
                    else if (pos.Y <= RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTTOP;
                    else if (pos.Y >= height - RESIZE_HANDLE_SIZE)
                        m.Result = (IntPtr)HTBOTTOM;
                    else
                        m.Result = (IntPtr)HTCLIENT;

                    return;
                }

            base.WndProc(ref m);
        }

        private void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam) {
            var mmi = Marshal.PtrToStructure<MINMAXINFO>(lParam)!;

            var screen = Screen.FromHandle(hwnd);
            var workingArea = screen.WorkingArea;
            var monitorArea = screen.Bounds;

            mmi.ptMaxPosition.x = workingArea.Left - monitorArea.Left;
            mmi.ptMaxPosition.y = workingArea.Top - monitorArea.Top;
            mmi.ptMaxSize.x = workingArea.Width;
            mmi.ptMaxSize.y = workingArea.Height;

            Marshal.StructureToPtr(mmi, lParam, true);
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct POINT {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MINMAXINFO {
            public POINT ptReserved;
            public POINT ptMaxSize;
            public POINT ptMaxPosition;
            public POINT ptMinTrackSize;
            public POINT ptMaxTrackSize;
        }

    }
}
