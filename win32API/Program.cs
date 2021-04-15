using System;
using System.Runtime.InteropServices;
using System.Text;

namespace win32API
{
    public partial class Program
    {
        [STAThread]
        public static int Main() => new Program().create();
        private WndProc delegWndProc = myWndProc;

        public int create()
        {
            WNDCLASSEX wind_class = new WNDCLASSEX();
            wind_class.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
            wind_class.style = (int)(ClassStyles.HorizontalRedraw | ClassStyles.VerticalRedraw | ClassStyles.DoubleClicks); //Doubleclicks are active
            wind_class.hbrBackground = (IntPtr)(COLOR.WINDOW);
            wind_class.cbClsExtra = 0;
            wind_class.cbWndExtra = 0;
            wind_class.hInstance = Marshal.GetHINSTANCE(this.GetType().Module); ;// alternative: Process.GetCurrentProcess().Handle;
            wind_class.hIcon = IntPtr.Zero;
            wind_class.hCursor = LoadCursor(IntPtr.Zero, (int)IDC_STANDARD_CURSORS.IDC_ARROW);
            wind_class.lpszMenuName = null;
            wind_class.lpszClassName = "testClass";
            wind_class.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(delegWndProc);
            wind_class.hIconSm = IntPtr.Zero;
            ushort regResult = RegisterClassEx(ref wind_class);

            if (regResult == 0)
            {
                uint error = GetLastError();
                return 0;
            }
            string wndClass = wind_class.lpszClassName;

            IntPtr hWnd = CreateWindowEx(0L, "testClass", "Hello Win32", WS_OVERLAPPEDWINDOW, 0, 0, 300, 400, IntPtr.Zero, IntPtr.Zero, wind_class.hInstance, IntPtr.Zero);

            if (hWnd == IntPtr.Zero)
            {
                uint error = GetLastError();
                return 0;
            }
            ShowWindow(hWnd, 1);
            UpdateWindow(hWnd);
            MSG msg = new MSG();
            while (GetMessage(ref msg, IntPtr.Zero, 0, 0))
            {
                TranslateMessage(ref msg);
                DispatchMessage(ref msg);
            }
            return (int)msg.wParam;
        }

        private static IntPtr myWndProc(IntPtr hWnd, WM msg, IntPtr wParam, IntPtr lParam) //EVENTI DA MESSAGGI
        {
            switch (msg)
            {
                case WM.COMMAND:

                    switch ((int)wParam)
                    {
                        case 1:
                            StringBuilder stringbuilder = new StringBuilder(100);
                            GetWindowText(GetDlgItem(hWnd, 3), stringbuilder, stringbuilder.Capacity);
                            MessageBox(hWnd, stringbuilder.ToString(), "new", MessageBoxOptions.DefButton1);
                            break;
                        case 2:
                            PostQuitMessage(0);
                            return IntPtr.Zero;
                        case 4:
                            MessageBox(hWnd, "Button pressed", "new", MessageBoxOptions.DefButton1);
                            break;
                    }
                    break;

                case WM.CREATE:
                    AddMenus(hWnd);
                    AddControls(hWnd);
                    break;

                case WM.LBUTTONDBLCLK:
                    MessageBox(hWnd, "Doubleclick", "", MessageBoxOptions.IconWarning);
                    break;

                case WM.CLOSE:
                    PostQuitMessage(0);
                    return IntPtr.Zero;

                case WM.DESTROY:
                    DestroyWindow(hWnd);
                    PostQuitMessage(0);
                    return IntPtr.Zero;

                case WM.PAINT:
                    PAINTSTRUCT ps;
                    HDC hdc = BeginPaint(hWnd, &ps);

                    EndPaint(hWnd, &ps);
                    break;
            }
            return DefWindowProc(hWnd, msg, wParam, lParam);
        }

        static void AddMenus(IntPtr hWnd)
        {
            IntPtr hMenu = CreateMenu();
            IntPtr hFileMenu = CreateMenu();
            IntPtr hSubMenu = CreateMenu();
            AppendMenu(hMenu, MenuFlags.MF_POPUP, (uint)hFileMenu, "File");
            AppendMenu(hFileMenu, MenuFlags.MF_STRING, 1, "New");
            AppendMenu(hFileMenu, MenuFlags.MF_POPUP, (uint)hSubMenu, "Submenu");
            AppendMenu(hSubMenu, MenuFlags.MF_STRING, 1, "Opt 1");
            AppendMenu(hSubMenu, MenuFlags.MF_STRING, 1, "Opt 2");
            AppendMenu(hFileMenu, MenuFlags.MF_SEPARATOR, 0, string.Empty);
            AppendMenu(hFileMenu, MenuFlags.MF_STRING, 2, "Exit");
            AppendMenu(hMenu, MenuFlags.MF_STRING, 3, "Edit");
            SetMenu(hWnd, hMenu);
        }

        static void AddControls(IntPtr hWnd)
        {
            //You can retrieve the window handle elsewhere in the dlgproc with GetDlgItem
            IntPtr defaultFont;
            defaultFont = GetStockObject(StockObjects.DEFAULT_GUI_FONT);

            CreateWindowEx(0, WC_STATIC, "Label:", WS_CHILDWINDOW | WS_VISIBLE, 5, 5, 45, 23, hWnd, 2);
            CreateWindowEx(WS_EX_CLIENTEDGE, "edit", "test", WS_CHILD | WS_VISIBLE | ES_MULTILINE | WS_VSCROLL | ES_AUTOHSCROLL, 5, 40, 140, 50, hWnd, 3);
            CreateWindowEx(0, WC_BUTTON, "Button", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 5, 100, 140, 30, hWnd, 4);
            CreateWindowEx(0, WC_BUTTON, "Checkbox", WS_CHILD | WS_VISIBLE | BS_AUTOCHECKBOX, 5, 155, 100, 20, hWnd, 5);
            CreateWindowEx(0, WC_BUTTON, "Radiobutton1", WS_CHILD | WS_VISIBLE | BS_AUTORADIOBUTTON, 5, 185, 100, 20, hWnd, 6);
            CreateWindowEx(0, WC_BUTTON, "Radiobutton2", WS_CHILD | WS_VISIBLE | BS_AUTORADIOBUTTON, 5, 205, 100, 20, hWnd, 7);
            CreateWindowEx(0, "Combobox", "Combobox", WS_CHILD | WS_VISIBLE | CB_SHOWDROPDOWN, 5, 235, 100, 20, hWnd, 8);
            CreateWindowEx(0, "Combobox", "Combobox", WS_CHILD | WS_VISIBLE | CBS_DROPDOWN | CBS_HASSTRINGS, 5, 265, 100, 20, hWnd, 9);
            CreateWindowEx(WS_EX_CLIENTEDGE, "Listbox", "Listbox", WS_CHILD | WS_VISIBLE | EN_VSCROLL | ES_AUTOVSCROLL, 125, 235, 70, 100, hWnd, 10);
            CreateWindowEx(WS_EX_LEFT | WS_EX_CLIENTEDGE | WS_EX_CONTEXTHELP, "edit", "0", WS_CHILD | WS_VISIBLE, 5, 295, 100, 20, hWnd, 11);
            CreateWindowEx(WS_EX_LEFT | WS_EX_LTRREADING, UPDOWN_CLASS, "0", WS_CHILDWINDOW | WS_VISIBLE | UDS_AUTOBUDDY | UDS_SETBUDDYINT | UDS_ALIGNRIGHT | UDS_ARROWKEYS | UDS_HOTTRACK, 85, 295, 20, 20, hWnd, 12);

            SendMessage(GetDlgItem(hWnd, 12), UDM_SETRANGE, 0, MAKELPARAM(100, 1));    // Sets the controls direction and range.

            CreateWindowEx(0, WC_BUTTON, "GroupBox", WS_VISIBLE | WS_CHILD | WS_GROUP | BS_GROUPBOX, 155, 5, 100, 100, hWnd, 13);


            for (int i = 2; i < 14; i++)
            {
                SendMessage(GetDlgItem(hWnd, i), WM.SETFONT, defaultFont, true);
            }
        }
    }
}