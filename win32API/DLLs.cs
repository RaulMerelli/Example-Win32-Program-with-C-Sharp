using System;
using System.Runtime.InteropServices;
using System.Text;

namespace win32API
{
    public partial class Program
    {
        /// <summary>
        /// Creates a menu. The menu is initially empty, but it can be filled with menu items by using the InsertMenuItem, AppendMenu, and InsertMenu functions.
        /// </summary>
        /// <returns>
        /// If the function succeeds, the return value is a handle to the newly created menu.
        /// If the function fails, the return value is NULL.To get extended error information, call GetLastError.
        /// </returns>
        [DllImport("user32.dll")]
        static extern IntPtr CreateMenu();

        [DllImport("user32")]
        public static extern bool GetMessage(ref MSG lpMsg, IntPtr handle, uint mMsgFilterInMain, uint mMsgFilterMax);

        [DllImport("user32.dll")]
        static extern bool EndPaint(IntPtr hWnd, [In] ref PAINTSTRUCT lpPaint);

        [DllImport("user32.dll")]
        static extern bool UpdateWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, MessageBoxOptions type);

        [DllImport("user32.dll")]
        static extern int FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, string lpIconName);

        [DllImport("user32.dll")]
        public static extern IntPtr LoadIcon(IntPtr hInstance, IntPtr lpIConName);

        [DllImport("gdi32.dll")]
        public static extern IntPtr GetStockObject(StockObjects fnObject);

        [DllImport("user32.dll")]
        static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern bool AppendMenu(IntPtr hMenu, MenuFlags uFlags, uint uIDNewItem, string lpNewItem);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool DestroyWindow(IntPtr hWnd);

        /// <summary>
        ///     Copies the text of the specified window's title bar (if it has one) into a buffer. If the specified window is a
        ///     control, the text of the control is copied. However, GetWindowText cannot retrieve the text of a control in another
        ///     application.
        ///     <para>
        ///     Go to https://msdn.microsoft.com/en-us/library/windows/desktop/ms633520%28v=vs.85%29.aspx  for more
        ///     information
        ///     </para>
        /// </summary>
        /// <param name="hWnd">
        ///     C++ ( hWnd [in]. Type: HWND )<br />A <see cref="IntPtr" /> handle to the window or control containing the text.
        /// </param>
        /// <param name="lpString">
        ///     C++ ( lpString [out]. Type: LPTSTR )<br />The <see cref="StringBuilder" /> buffer that will receive the text. If
        ///     the string is as long or longer than the buffer, the string is truncated and terminated with a null character.
        /// </param>
        /// <param name="nMaxCount">
        ///     C++ ( nMaxCount [in]. Type: int )<br /> Should be equivalent to
        ///     <see cref="StringBuilder.Length" /> after call returns. The <see cref="int" /> maximum number of characters to copy
        ///     to the buffer, including the null character. If the text exceeds this limit, it is truncated.
        /// </param>
        /// <returns>
        ///     If the function succeeds, the return value is the length, in characters, of the copied string, not including
        ///     the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window
        ///     or control handle is invalid, the return value is zero. To get extended error information, call GetLastError.<br />
        ///     This function cannot retrieve the text of an edit control in another application.
        /// </returns>
        /// <remarks>
        ///     If the target window is owned by the current process, GetWindowText causes a WM_GETTEXT message to be sent to the
        ///     specified window or control. If the target window is owned by another process and has a caption, GetWindowText
        ///     retrieves the window caption text. If the window does not have a caption, the return value is a null string. This
        ///     behavior is by design. It allows applications to call GetWindowText without becoming unresponsive if the process
        ///     that owns the target window is not responding. However, if the target window is not responding and it belongs to
        ///     the calling application, GetWindowText will cause the calling application to become unresponsive. To retrieve the
        ///     text of a control in another process, send a WM_GETTEXT message directly instead of calling GetWindowText.<br />For
        ///     an example go to
        ///     <see cref="!:https://msdn.microsoft.com/en-us/library/windows/desktop/ms644928%28v=vs.85%29.aspx#sending">
        ///     Sending a
        ///     Message.
        ///     </see>
        /// </remarks>
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// The CreateWindowEx function creates an overlapped, pop-up, or child window with an extended window style; otherwise, this function is identical to the CreateWindow function.
        /// </summary>
        /// <param name="dwExStyle">Specifies the extended window style of the window being created.</param>
        /// <param name="lpClassName">Pointer to a null-terminated string or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. The atom must be in the low-order word of lpClassName; the high-order word must be zero. If lpClassName is a string, it specifies the window class name. The class name can be any name registered with RegisterClass or RegisterClassEx, provided that the module that registers the class is also the module that creates the window. The class name can also be any of the predefined system class names.</param>
        /// <param name="lpWindowName">Pointer to a null-terminated string that specifies the window name. If the window style specifies a title bar, the window title pointed to by lpWindowName is displayed in the title bar. When using CreateWindow to create controls, such as buttons, check boxes, and static controls, use lpWindowName to specify the text of the control. When creating a static control with the SS_ICON style, use lpWindowName to specify the icon name or identifier. To specify an identifier, use the syntax "#num". </param>
        /// <param name="dwStyle">Specifies the style of the window being created. This parameter can be a combination of window styles, plus the control styles indicated in the Remarks section.</param>
        /// <param name="x">Specifies the initial horizontal position of the window. For an overlapped or pop-up window, the x parameter is the initial x-coordinate of the window's upper-left corner, in screen coordinates. For a child window, x is the x-coordinate of the upper-left corner of the window relative to the upper-left corner of the parent window's client area. If x is set to CW_USEDEFAULT, the system selects the default position for the window's upper-left corner and ignores the y parameter. CW_USEDEFAULT is valid only for overlapped windows; if it is specified for a pop-up or child window, the x and y parameters are set to zero.</param>
        /// <param name="y">Specifies the initial vertical position of the window. For an overlapped or pop-up window, the y parameter is the initial y-coordinate of the window's upper-left corner, in screen coordinates. For a child window, y is the initial y-coordinate of the upper-left corner of the child window relative to the upper-left corner of the parent window's client area. For a list box y is the initial y-coordinate of the upper-left corner of the list box's client area relative to the upper-left corner of the parent window's client area.
        /// <para>If an overlapped window is created with the WS_VISIBLE style bit set and the x parameter is set to CW_USEDEFAULT, then the y parameter determines how the window is shown. If the y parameter is CW_USEDEFAULT, then the window manager calls ShowWindow with the SW_SHOW flag after the window has been created. If the y parameter is some other value, then the window manager calls ShowWindow with that value as the nCmdShow parameter.</para></param>
        /// <param name="nWidth">Specifies the width, in device units, of the window. For overlapped windows, nWidth is the window's width, in screen coordinates, or CW_USEDEFAULT. If nWidth is CW_USEDEFAULT, the system selects a default width and height for the window; the default width extends from the initial x-coordinates to the right edge of the screen; the default height extends from the initial y-coordinate to the top of the icon area. CW_USEDEFAULT is valid only for overlapped windows; if CW_USEDEFAULT is specified for a pop-up or child window, the nWidth and nHeight parameter are set to zero.</param>
        /// <param name="nHeight">Specifies the height, in device units, of the window. For overlapped windows, nHeight is the window's height, in screen coordinates. If the nWidth parameter is set to CW_USEDEFAULT, the system ignores nHeight.</param> <param name="hWndParent">Handle to the parent or owner window of the window being created. To create a child window or an owned window, supply a valid window handle. This parameter is optional for pop-up windows.
        /// <para>Windows 2000/XP: To create a message-only window, supply HWND_MESSAGE or a handle to an existing message-only window.</para></param>
        /// <param name="hMenu">Handle to a menu, or specifies a child-window identifier, depending on the window style. For an overlapped or pop-up window, hMenu identifies the menu to be used with the window; it can be NULL if the class menu is to be used. For a child window, hMenu specifies the child-window identifier, an integer value used by a dialog box control to notify its parent about events. The application determines the child-window identifier; it must be unique for all child windows with the same parent window.</param>
        /// <param name="hInstance">Handle to the instance of the module to be associated with the window.</param> <param name="lpParam">Pointer to a value to be passed to the window through the CREATESTRUCT structure (lpCreateParams member) pointed to by the lParam param of the WM_CREATE message. This message is sent to the created window by this function before it returns.
        /// <para>If an application calls CreateWindow to create a MDI client window, lpParam should point to a CLIENTCREATESTRUCT structure. If an MDI client window calls CreateWindow to create an MDI child window, lpParam should point to a MDICREATESTRUCT structure. lpParam may be NULL if no additional data is needed.</para></param>
        /// <returns>If the function succeeds, the return value is a handle to the new window.
        /// <para>If the function fails, the return value is NULL. To get extended error information, call GetLastError.</para>
        /// <para>This function typically fails for one of the following reasons:</para>
        /// <list type="">
        /// <item>an invalid parameter value</item>
        /// <item>the system class was registered by a different module</item>
        /// <item>The WH_CBT hook is installed and returns a failure code</item>
        /// <item>if one of the controls in the dialog template is not registered, or its window window procedure fails WM_CREATE or WM_NCCREATE</item>
        /// </list></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowEx(
           WindowStylesEx dwExStyle,
           [MarshalAs(UnmanagedType.LPStr)] string lpClassName,
           [MarshalAs(UnmanagedType.LPStr)] string lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           IntPtr hMenu,
           IntPtr hInstance,
           IntPtr lpParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowEx(
           long dwExStyle,
           [MarshalAs(UnmanagedType.LPStr)] string lpClassName,
           [MarshalAs(UnmanagedType.LPStr)] string lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           IntPtr hMenu,
           IntPtr hInstance,
           IntPtr lpParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr CreateWindowEx(
           long dwExStyle,
           [MarshalAs(UnmanagedType.LPStr)] string lpClassName,
           long lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           IntPtr hMenu,
           IntPtr hInstance,
           IntPtr lpParam);

        public static IntPtr CreateWindowEx(long dwExStyle,
           string lpClassName,
           string lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           int hMenu,
           IntPtr hInstance,
           IntPtr lpParam)
        {
            return CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, (IntPtr)hMenu, hInstance, lpParam);
        }

        public static IntPtr CreateWindowEx(long dwExStyle,
           string lpClassName,
           string lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           int hMenu)
        {
            return CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, (IntPtr)hMenu, IntPtr.Zero, IntPtr.Zero);
        }

        public static IntPtr CreateWindowEx(long dwExStyle,
           string lpClassName,
           long lpWindowName,
           long dwStyle,
           int x,
           int y,
           int nWidth,
           int nHeight,
           IntPtr hWndParent,
           int hMenu)
        {
            return CreateWindowEx(dwExStyle, lpClassName, lpWindowName, dwStyle, x, y, nWidth, nHeight, hWndParent, (IntPtr)hMenu, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("user32.dll", SetLastError = true, EntryPoint = "RegisterClassEx")]
        static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpWndClass);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        static extern bool TextOut(IntPtr hdc, int nXStart, int nYStart, string lpString, int cbString);

        [DllImport("user32.dll")]
        static extern IntPtr BeginPaint(IntPtr hwnd, out PAINTSTRUCT lpPaint);

        [DllImport("kernel32.dll")]
        static extern uint GetLastError();

        [DllImport("user32.dll")]
        static extern IntPtr DefWindowProc(IntPtr hWnd, WM uMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        static extern void PostQuitMessage(int nExitCode);

        [DllImport("user32.dll")]
        static extern IntPtr LoadCursor(IntPtr hInstance, int lpCursorName);

        [DllImport("user32.dll")]
        static extern bool TranslateMessage([In] ref MSG lpMsg);

        [DllImport("user32.dll")]
        static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

        [DllImport("user32.dll")]
        static extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hrgnClip, DeviceContextValues flags);

        static public IntPtr GetDC(IntPtr hWnd)
        {
            return GetDCEx(hWnd, IntPtr.Zero, DeviceContextValues.ExcludeRgn);
        }

        public static int MulDiv(int number, int numerator, int denominator)
        {
            return (int)(((long)number * numerator) / denominator);
        }

        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("gdi32.dll")]
        static extern IntPtr CreateFontIndirect([In] ref LOGFONT lplf);

        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDC);


        public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        /// <summary>
        /// Enumerates the child windows that belong to the specified parent 
        /// window by passing the handle to each child window, in turn, to an 
        /// application-defined callback function. EnumChildWindows continues 
        /// until the last child window is enumerated or the callback function 
        /// returns FALSE.
        /// </summary>
        /// <param name="window">A handle to the parent window whose child windows are to be enumerated. If this parameter is NULL, this function is equivalent to EnumWindows.</param>
        /// <param name="callback">A pointer to an application-defined callback function.</param>
        /// <param name="i">An application-defined value to be passed to the callback function.</param>
        /// <returns>Return FALSE</returns>
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

        /// <summary>
        /// Retrieves a handle to a window whose class name and window name match the specified strings. 
        /// The function searches child windows, beginning with the one following the specified child window. 
        /// This function does not perform a case-sensitive search.
        /// </summary>
        /// <param name="hwndParent">A handle to the parent window whose child windows are to be searched. If hwndParent is NULL, the function uses the desktop window as the parent window. The function searches among windows that are child windows of the desktop. If hwndParent is HWND_MESSAGE, the function searches all message-only windows.</param>
        /// <param name="hwndChildAfter">A handle to a child window. The search begins with the next child window in the Z order. The child window must be a direct child window of hwndParent, not just a descendant window. If hwndChildAfter is NULL, the search begins with the first child window of hwndParent. Note that if both hwndParent and hwndChildAfter are NULL, the function searches all top-level and message-only windows.</param>
        /// <param name="lpszClass">Optional: The class name or a class atom created by a previous call to the RegisterClass or RegisterClassEx function. The atom must be placed in the low-order word of lpszClass; the high-order word must be zero. If lpszClass is a string, it specifies the window class name. The class name can be any name registered with RegisterClass or RegisterClassEx, or any of the predefined control-class names, or it can be MAKEINTATOM(0x8000). In this latter case, 0x8000 is the atom for a menu class. For more information, see the Remarks section of this topic.</param>
        /// <param name="lpszWindow">Optional: The window name (the window's title). If this parameter is NULL, all window names match.</param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        /// <summary>
        /// Retrieves the name of the class to which the specified window belongs.
        /// </summary>
        /// <param name="hWnd">A handle to the window and, indirectly, the class to which the window belongs.</param>
        /// <param name="lpClassName">The class name string.</param>
        /// <param name="nMaxCount">The length of the lpClassName buffer, in characters. The buffer must be large enough to include the terminating null character; otherwise, the class name string is truncated to nMaxCount-1 characters.</param>
        /// <returns>If the function succeeds, the return value is the number of characters copied to the buffer, not including the terminating null character. If the function fails, the return value is zero. To get extended error information, call GetLastError.</returns>
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        /// <summary>
        /// Retrieves a handle to the desktop window. The desktop window covers the entire screen. The 
        /// desktop window is the area on top of which other windows are painted.
        /// </summary>
        /// <returns>The return value is a handle to the desktop window</returns>
        [DllImport("user32.dll", SetLastError = false)]
        public static extern IntPtr GetDesktopWindow();

        /// <summary>
        /// Copies the text of the specified window's title bar (if it has one) into a buffer. If the 
        /// specified window is a control, the text of the control is copied. However, GetWindowText 
        /// cannot retrieve the text of a control in another application.
        /// </summary>
        /// <param name="hWnd">A handle to the window or control containing the text.</param>
        /// <param name="text">The buffer that will receive the text. If the string is as long or longer than the buffer, the string is truncated and terminated with a null character.</param>
        /// <param name="count">The maximum number of characters to copy to the buffer, including the null character. If the text exceeds this limit, it is truncated.</param>
        /// <returns>If the function succeeds, the return value is the length, in characters, of the copied string, not including the terminating null character. If the window has no title bar or text, if the title bar is empty, or if the window or control handle is invalid, the return value is zero. To get extended error information, call GetLastError.</returns>       
        
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hwnd, WM wmConstant, int wParam, StringBuilder sb);
        /// <summary>
        /// Sends the specified message to a window or windows. The SendMessage function calls the 
        /// window procedure for the specified window and does not return until the window procedure 
        /// has processed the message.
        /// </summary>
        /// <param name="hwnd">A handle to the window whose window procedure will receive the message. If this parameter is HWND_BROADCAST ((HWND)0xffff), the message is sent to all top-level windows in the system, including disabled or invisible unowned windows, overlapped windows, and pop-up windows; but the message is not sent to child windows.</param>
        /// <param name="wmConstant">Messages defined in wmConstants enum. See pinvoke.net for more details.</param>
        /// <param name="wParam">IntPtr.Zero</param>
        /// <param name="lParam">IntPtr.Zero</param>
        /// <returns></returns>

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hwnd, uint wmConstant, int wParam, StringBuilder sb);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hwnd, WM wmConstant, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hwnd, long wmConstant, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, IntPtr className, string windowTitle);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowByClassName(IntPtr parentHandle, IntPtr childAfter, string className, IntPtr windowTitle);

        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowByClassNameAndCaption(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hWnd, string lpString);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        public static int SendMessage(IntPtr hWnd, WM Msg, IntPtr wParam, bool lParam)
        {
            return SendMessage(hWnd, Msg, wParam, (IntPtr)Convert.ToInt16(lParam));
        }
        /// <summary>
        /// Find window by Caption only. Note you must pass IntPtr.Zero as the first parameter.
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        public static IntPtr GetClassLongPtr(IntPtr hWnd, ClassLongFlags nIndex)
        {
            return (IntPtr.Size > 4) ? GetClassLongPtr64(hWnd, (int)nIndex) : new IntPtr(GetClassLongPtr32(hWnd, (int)nIndex));
        }

        [DllImport("user32.dll", EntryPoint = "GetClassLong")]
        private static extern uint GetClassLongPtr32(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", EntryPoint = "GetClassLongPtr")]
        private static extern IntPtr GetClassLongPtr64(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern uint IsDlgButtonChecked(IntPtr hDlg, int nIDButton);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool CheckDlgButton(IntPtr hDlg, int nIDButton, CheckState uCheck);

        [DllImport("user32.dll")]
        static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int GetDlgCtrlID(IntPtr hwndCtl);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetDlgItemText(IntPtr hDlg, int nIDDlgItem, [Out] StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SetDlgItemText(IntPtr hDlg, uint hedit, string lpString);

        static int MAKELPARAM(int p, int p_2)
        {
            return ((p_2 << 16) | (p & 0xFFFF));
        }
    }
}