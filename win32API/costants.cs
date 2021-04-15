using System;
using System.Collections.Generic;
using System.Text;

namespace win32API
{
    public partial class Program
    {

        //============
        // Scrollbar
        //============

        //Scroll bar stuff
        /// <summary>
        /// Retrieves the parameters for the window's standard horizontal scroll bar.
        /// </summary>
        static long SB_HORZ = 0;
        /// <summary>
        /// Retrieves the parameters for the window's standard vertical scroll bar.
        /// </summary>
        static long SB_VERT = 1;
        /// <summary>
        /// Retrieves the parameters for a scroll bar control. The hwnd parameter must be the handle to the scroll bar control.
        /// </summary>
        static long SB_CTL = 2;
        /// <summary>
        /// Retrieves the parameters for the window's standard horizontal and vertical scroll bars.
        /// </summary>
        static long SB_BOTH = 3;

        //Scroll Bar Commands
        /// <summary>
        /// Scrolls one line up.
        /// </summary>
        static long SB_LINEUP = 0;
        static long SB_LINELEFT = 0;
        /// <summary>
        /// Scrolls one line down.
        /// </summary>
        static long SB_LINEDOWN = 1;
        static long SB_LINERIGHT = 1;
        /// <summary>
        /// Scrolls one page up.
        /// </summary>
        static long SB_PAGEUP = 2;
        static long SB_PAGELEFT = 2;
        /// <summary>
        /// Scrolls one page down.
        /// </summary>
        static long SB_PAGEDOWN = 3;
        static long SB_PAGERIGHT = 3;
        /// <summary>
        /// The user has dragged the scroll box (thumb) and released the mouse button. The HIWORD indicates the position of the scroll box at the end of the drag operation.
        /// </summary>
        static long SB_THUMBPOSITION = 4;
        /// <summary>
        /// The user is dragging the scroll box. This message is sent repeatedly until the user releases the mouse button. The HIWORD indicates the position that the scroll box has been dragged to.
        /// </summary>
        static long SB_THUMBTRACK = 5;
        /// <summary>
        /// Scrolls to the upper left.
        /// </summary>
        static long SB_TOP = 6;
        static long SB_LEFT = 6;
        /// <summary>
        /// Scrolls to the lower right.
        /// </summary>
        static long SB_BOTTOM = 7;
        static long SB_RIGHT = 7;
        /// <summary>
        /// Ends scroll.
        /// </summary>
        static long SB_ENDSCROLL = 8;
        static long SB_POLICY_CONTINUOUS = 10;
        static long SB_POLICY_DISCONTINUOUS = 11;
        static long SB_POLICY_DELAYED = 12;

        static long SW_PARENTCLOSING = 1;
        static long SW_OTHERZOOM = 2;
        static long SW_PARENTOPENING = 3;
        static long SW_OTHERUNZOOM = 4;

        static long AW_HOR_POSITIVE = 0x00000001;
        static long AW_HOR_NEGATIVE = 0x00000002;
        static long AW_VER_POSITIVE = 0x00000004;
        static long AW_VER_NEGATIVE = 0x00000008;
        static long AW_CENTER = 0x00000010;
        static long AW_HIDE = 0x00010000;
        static long AW_ACTIVATE = 0x00020000;
        static long AW_SLIDE = 0x00040000;
        static long AW_BLEND = 0x00080000;


        //------------
        //KeyFlags (High word part !!!)
        //------------
        static long KF_EXTENDED = 0x0100;
        static long KF_DLGMODE = 0x0800;
        static long KF_MENUMODE = 0x1000;
        static long KF_ALTDOWN = 0x2000;
        static long KF_REPEAT = 0x4000;
        static long KF_UP = 0x8000;


        //-------------
        //Virtual keys
        //-------------
        static long VK_LBUTTON = 0x01;
        static long VK_RBUTTON = 0x02;
        static long VK_CANCEL = 0x03;
        static long VK_MBUTTON = 0x04;
        static long VK_XBUTTON1 = 0x05;
        static long VK_XBUTTON2 = 0x06;
        static long VK_BACK = 0x08;
        static long VK_TAB = 0x09;
        static long VK_CLEAR = 0x0C;
        static long VK_RETURN = 0x0D;
        static long VK_SHIFT = 0x10;
        static long VK_CONTROL = 0x11;
        static long VK_MENU = 0x12;
        static long VK_PAUSE = 0x13;
        static long VK_CAPITAL = 0x14;
        static long VK_KANA = 0x15;
        static long VK_HANGEUL = 0x15;
        static long VK_HANGUL = 0x15;
        static long VK_JUNJA = 0x17;
        static long VK_FINAL = 0x18;
        static long VK_HANJA = 0x19;
        static long VK_KANJI = 0x19;
        static long VK_ESCAPE = 0x1B;
        static long VK_CONVERT = 0x1C;
        static long VK_NONCONVERT = 0x1D;
        static long VK_ACCEPT = 0x1E;
        static long VK_MODECHANGE = 0x1F;
        static long VK_SPACE = 0x20;
        static long VK_PRIOR = 0x21;
        static long VK_NEXT = 0x22;
        static long VK_END = 0x23;
        static long VK_HOME = 0x24;
        static long VK_LEFT = 0x25;
        static long VK_UP = 0x26;
        static long VK_RIGHT = 0x27;
        static long VK_DOWN = 0x28;
        static long VK_SELECT = 0x29;
        static long VK_PRINT = 0x2A;
        static long VK_EXECUTE = 0x2B;
        static long VK_SNAPSHOT = 0x2C;
        static long VK_INSERT = 0x2D;
        static long VK_DELETE = 0x2E;
        static long VK_HELP = 0x2F;
        static long VK_LWIN = 0x5B;
        static long VK_RWIN = 0x5C;
        static long VK_APPS = 0x5D;
        static long VK_SLEEP = 0x5F;
        static long VK_NUMPAD0 = 0x60;
        static long VK_NUMPAD1 = 0x61;
        static long VK_NUMPAD2 = 0x62;
        static long VK_NUMPAD3 = 0x63;
        static long VK_NUMPAD4 = 0x64;
        static long VK_NUMPAD5 = 0x65;
        static long VK_NUMPAD6 = 0x66;
        static long VK_NUMPAD7 = 0x67;
        static long VK_NUMPAD8 = 0x68;
        static long VK_NUMPAD9 = 0x69;
        static long VK_MULTIPLY = 0x6A;
        static long VK_ADD = 0x6B;
        static long VK_SEPARATOR = 0x6C;
        static long VK_SUBTRACT = 0x6D;
        static long VK_DECIMAL = 0x6E;
        static long VK_DIVIDE = 0x6F;
        static long VK_F1 = 0x70;
        static long VK_F2 = 0x71;
        static long VK_F3 = 0x72;
        static long VK_F4 = 0x73;
        static long VK_F5 = 0x74;
        static long VK_F6 = 0x75;
        static long VK_F7 = 0x76;
        static long VK_F8 = 0x77;
        static long VK_F9 = 0x78;
        static long VK_F10 = 0x79;
        static long VK_F11 = 0x7A;
        static long VK_F12 = 0x7B;
        static long VK_F13 = 0x7C;
        static long VK_F14 = 0x7D;
        static long VK_F15 = 0x7E;
        static long VK_F16 = 0x7F;
        static long VK_F17 = 0x80;
        static long VK_F18 = 0x81;
        static long VK_F19 = 0x82;
        static long VK_F20 = 0x83;
        static long VK_F21 = 0x84;
        static long VK_F22 = 0x85;
        static long VK_F23 = 0x86;
        static long VK_F24 = 0x87;
        static long VK_NAVIGATION_VIEW = 0x88;
        static long VK_NAVIGATION_MENU = 0x89;
        static long VK_NAVIGATION_UP = 0x8A;
        static long VK_NAVIGATION_DOWN = 0x8B;
        static long VK_NAVIGATION_LEFT = 0x8C;
        static long VK_NAVIGATION_RIGHT = 0x8D;
        static long VK_NAVIGATION_ACCEPT = 0x8E;
        static long VK_NAVIGATION_CANCEL = 0x8F;
        static long VK_NUMLOCK = 0x90;
        static long VK_SCROLL = 0x91;
        static long VK_OEM_NEC_EQUAL = 0x92;
        static long VK_OEM_FJ_JISHO = 0x92;
        static long VK_OEM_FJ_MASSHOU = 0x93;
        static long VK_OEM_FJ_TOUROKU = 0x94;
        static long VK_OEM_FJ_LOYA = 0x95;
        static long VK_OEM_FJ_ROYA = 0x96;
        static long VK_LSHIFT = 0xA0;
        static long VK_RSHIFT = 0xA1;
        static long VK_LCONTROL = 0xA2;
        static long VK_RCONTROL = 0xA3;
        static long VK_LMENU = 0xA4;
        static long VK_RMENU = 0xA5;
        static long VK_BROWSER_BACK = 0xA6;
        static long VK_BROWSER_FORWARD = 0xA7;
        static long VK_BROWSER_REFRESH = 0xA8;
        static long VK_BROWSER_STOP = 0xA9;
        static long VK_BROWSER_SEARCH = 0xAA;
        static long VK_BROWSER_FAVORITES = 0xAB;
        static long VK_BROWSER_HOME = 0xAC;
        static long VK_VOLUME_MUTE = 0xAD;
        static long VK_VOLUME_DOWN = 0xAE;
        static long VK_VOLUME_UP = 0xAF;
        static long VK_MEDIA_NEXT_TRACK = 0xB0;
        static long VK_MEDIA_PREV_TRACK = 0xB1;
        static long VK_MEDIA_STOP = 0xB2;
        static long VK_MEDIA_PLAY_PAUSE = 0xB3;
        static long VK_LAUNCH_MAIL = 0xB4;
        static long VK_LAUNCH_MEDIA_SELECT = 0xB5;
        static long VK_LAUNCH_APP1 = 0xB6;
        static long VK_LAUNCH_APP2 = 0xB7;
        static long VK_OEM_1 = 0xBA;
        static long VK_OEM_PLUS = 0xBB;
        static long VK_OEM_COMMA = 0xBC;
        static long VK_OEM_MINUS = 0xBD;
        static long VK_OEM_PERIOD = 0xBE;
        static long VK_OEM_2 = 0xBF;
        static long VK_OEM_3 = 0xC0;
        static long VK_GAMEPAD_A = 0xC3;
        static long VK_GAMEPAD_B = 0xC4;
        static long VK_GAMEPAD_X = 0xC5;
        static long VK_GAMEPAD_Y = 0xC6;
        static long VK_GAMEPAD_RIGHT_SHOULDER = 0xC7;
        static long VK_GAMEPAD_LEFT_SHOULDER = 0xC8;
        static long VK_GAMEPAD_LEFT_TRIGGER = 0xC9;
        static long VK_GAMEPAD_RIGHT_TRIGGER = 0xCA;
        static long VK_GAMEPAD_DPAD_UP = 0xCB;
        static long VK_GAMEPAD_DPAD_DOWN = 0xCC;
        static long VK_GAMEPAD_DPAD_LEFT = 0xCD;
        static long VK_GAMEPAD_DPAD_RIGHT = 0xCE;
        static long VK_GAMEPAD_MENU = 0xCF;
        static long VK_GAMEPAD_VIEW = 0xD0;
        static long VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON = 0xD1;
        static long VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON = 0xD2;
        static long VK_GAMEPAD_LEFT_THUMBSTICK_UP = 0xD3;
        static long VK_GAMEPAD_LEFT_THUMBSTICK_DOWN = 0xD4;
        static long VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT = 0xD5;
        static long VK_GAMEPAD_LEFT_THUMBSTICK_LEFT = 0xD6;
        static long VK_GAMEPAD_RIGHT_THUMBSTICK_UP = 0xD7;
        static long VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN = 0xD8;
        static long VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT = 0xD9;
        static long VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT = 0xDA;
        static long VK_OEM_4 = 0xDB;
        static long VK_OEM_5 = 0xDC;
        static long VK_OEM_6 = 0xDD;
        static long VK_OEM_7 = 0xDE;
        static long VK_OEM_8 = 0xDF;
        static long VK_OEM_AX = 0xE1;
        static long VK_OEM_102 = 0xE2;
        static long VK_ICO_HELP = 0xE3;
        static long VK_ICO_00 = 0xE4;
        static long VK_PROCESSKEY = 0xE5;
        static long VK_ICO_CLEAR = 0xE6;
        static long VK_OEM_RESET = 0xE9;
        static long VK_OEM_JUMP = 0xEA;
        static long VK_OEM_PA1 = 0xEB;
        static long VK_OEM_PA2 = 0xEC;
        static long VK_OEM_PA3 = 0xED;
        static long VK_OEM_WSCTRL = 0xEE;
        static long VK_OEM_CUSEL = 0xEF;
        static long VK_OEM_ATTN = 0xF0;
        static long VK_OEM_FINISH = 0xF1;
        static long VK_OEM_COPY = 0xF2;
        static long VK_OEM_AUTO = 0xF3;
        static long VK_OEM_ENLW = 0xF4;
        static long VK_OEM_BACKTAB = 0xF5;
        static long VK_ATTN = 0xF6;
        static long VK_CRSEL = 0xF7;
        static long VK_EXSEL = 0xF8;
        static long VK_EREOF = 0xF9;
        static long VK_PLAY = 0xFA;
        static long VK_ZOOM = 0xFB;
        static long VK_NONAME = 0xFC;
        static long VK_PA1 = 0xFD;
        static long VK_OEM_CLEAR = 0xFE;
        static long VK_UNKNOWN = 0; //defined by LCL

        static long VK_0 = 0x30;
        static long VK_1 = 0x31;
        static long VK_2 = 0x32;
        static long VK_3 = 0x33;
        static long VK_4 = 0x34;
        static long VK_5 = 0x35;
        static long VK_6 = 0x36;
        static long VK_7 = 0x37;
        static long VK_8 = 0x38;
        static long VK_9 = 0x39;
        //3A-40 Undefined
        static long VK_A = 0x41;
        static long VK_B = 0x42;
        static long VK_C = 0x43;
        static long VK_D = 0x44;
        static long VK_E = 0x45;
        static long VK_F = 0x46;
        static long VK_G = 0x47;
        static long VK_H = 0x48;
        static long VK_I = 0x49;
        static long VK_J = 0x4A;
        static long VK_K = 0x4B;
        static long VK_L = 0x4C;
        static long VK_M = 0x4D;
        static long VK_N = 0x4E;
        static long VK_O = 0x4F;
        static long VK_P = 0x50;
        static long VK_Q = 0x51;
        static long VK_R = 0x52;
        static long VK_S = 0x53;
        static long VK_T = 0x54;
        static long VK_U = 0x55;
        static long VK_V = 0x56;
        static long VK_W = 0x57;
        static long VK_X = 0x58;
        static long VK_Y = 0x59;
        static long VK_Z = 0x5A;

        static long VK_HIGHESTVALUE = 0xFFFF;
        static long VK_UNDEFINED = 0xFF; //defined by LCL

        //==============================================
        //LCL aliases for more clear naming of keys
        //==============================================

        static long VK_LCL_EQUAL = VK_OEM_PLUS;         //The "=+" Key
        static long VK_LCL_COMMA = VK_OEM_COMMA;        //The ",<" Key
        static long VK_LCL_POINT = VK_OEM_PERIOD;       //The ".>" Key
        static long VK_LCL_SLASH = VK_OEM_2;            //The "/?" Key
        static long VK_LCL_SEMI_COMMA = VK_OEM_1;       //The ";:" Key
        static long VK_LCL_MINUS = VK_OEM_MINUS;        //The "-_" Key
        static long VK_LCL_OPEN_BRAKET = VK_OEM_4;      //The "[//" Key
        static long VK_LCL_CLOSE_BRAKET = VK_OEM_6;     //The "]" Key
        static long VK_LCL_BACKSLASH = VK_OEM_5;        //The "\|" Key
        static long VK_LCL_TILDE = VK_OEM_3;            //The "`~" Key
        static long VK_LCL_QUOTE = VK_OEM_7;            //The "'"" Key

        static long VK_LCL_ALT = VK_MENU;
        static long VK_LCL_LALT = VK_LMENU;
        static long VK_LCL_RALT = VK_RMENU;

        static long VK_LCL_CAPSLOCK = VK_CAPITAL;

        //==============================================
        //New LCL defined keys
        //==============================================

        static long VK_LCL_POWER = 0x100;
        static long VK_LCL_CALL = 0x101;
        static long VK_LCL_ENDCALL = 0x102;
        static long VK_LCL_AT = 0x103; //Not equivalent to anything < 0xFF, will only be sent by a primary "@" key
                                       //but not for a @ key as secondary action of a "2" key for example

        static long WH_MIN = (-1);
        static long WH_MSGFILTER = (-1);
        static long WH_JOURNALRECORD = 0;
        static long WH_JOURNALPLAYBACK = 1;
        static long WH_KEYBOARD = 2;
        static long WH_GETMESSAGE = 3;
        static long WH_CALLWNDPROC = 4;
        static long WH_CBT = 5;
        static long WH_SYSMSGFILTER = 6;
        static long WH_MOUSE = 7;
        static long WH_HARDWARE = 8;
        static long WH_DEBUG = 9;
        static long WH_SHELL = 10;
        static long WH_FOREGROUNDIDLE = 11;
        static long WH_CALLWNDPROCRET = 12;
        static long WH_KEYBOARD_LL = 13;
        static long WH_MOUSE_LL = 14;
        static long WH_MAX = 14;
        static long WH_MINHOOK = (-1);
        static long WH_MAXHOOK = 14;


        static long HC_ACTION = 0;
        static long HC_GETNEXT = 1;
        static long HC_SKIP = 2;
        static long HC_NOREMOVE = 3;
        static long HC_NOREM = 3;
        static long HC_SYSMODALON = 4;
        static long HC_SYSMODALOFF = 5;


        static long HCBT_MOVESIZE = 0;
        static long HCBT_MINMAX = 1;
        static long HCBT_QS = 2;
        static long HCBT_CREATEWND = 3;
        static long HCBT_DESTROYWND = 4;
        static long HCBT_ACTIVATE = 5;
        static long HCBT_CLICKSKIPPED = 6;
        static long HCBT_KEYSKIPPED = 7;
        static long HCBT_SYSCOMMAND = 8;
        static long HCBT_SETFOCUS = 9;


        static long WTS_CONSOLE_CONNECT = 0x1;
        static long WTS_CONSOLE_DISCONNECT = 0x2;
        static long WTS_REMOTE_CONNECT = 0x3;
        static long WTS_REMOTE_DISCONNECT = 0x4;
        static long WTS_SESSION_LOGON = 0x5;
        static long WTS_SESSION_LOGOFF = 0x6;
        static long WTS_SESSION_LOCK = 0x7;
        static long WTS_SESSION_UNLOCK = 0x8;
        static long WTS_SESSION_REMOTE_CONTROL = 0x9;
        static long WTS_SESSION_CREATE = 0xa;
        static long WTS_SESSION_TERMINATE = 0xb;
        static long MSGF_DIALOGBOX = 0;
        static long MSGF_MESSAGEBOX = 1;
        static long MSGF_MENU = 2;
        static long MSGF_MOVE = 3;
        static long MSGF_SIZE = 4;
        static long MSGF_SCROLLBAR = 5;
        static long MSGF_NEXTWINDOW = 6;
        static long MSGF_MAX = 8;
        static long MSGF_USER = 4096;

        // Edit styles
        static long ES_LEFT = 0x0000L;
        static long ES_CENTER = 0x0001L;
        static long ES_RIGHT = 0x0002L;
        static long ES_MULTILINE = 0x0004L;
        static long ES_UPPERCASE = 0x0008L;
        static long ES_LOWERCASE = 0x0010L;
        static long ES_PASSWORD = 0x0020L;
        static long ES_AUTOVSCROLL = 0x0040L;
        static long ES_AUTOHSCROLL = 0x0080L;
        static long ES_NOHIDESEL = 0x0100L;
        static long ES_OEMCONVERT = 0x0400L;
        static long ES_READONLY = 0x0800L;
        static long ES_WANTRETURN = 0x1000L;
        static long ES_NUMBER = 0x2000L;

        static long EN_SETFOCUS = 0x0100;
        static long EN_KILLFOCUS = 0x0200;
        static long EN_CHANGE = 0x0300;
        static long EN_UPDATE = 0x0400;
        static long EN_ERRSPACE = 0x0500;
        static long EN_MAXTEXT = 0x0501;
        static long EN_HSCROLL = 0x0601;
        static long EN_VSCROLL = 0x0602;
        static long EN_ALIGN_LTR_EC = 0x0700;
        static long EN_ALIGN_RTL_EC = 0x0701;
        static long EC_LEFTMARGIN = 0x0001;
        static long EC_RIGHTMARGIN = 0x0002;
        static long EC_USEFONTINFO = 0xffff;
        static long EMSIS_COMPOSITIONSTRING = 0x0001;
        static long EIMES_GETCOMPSTRATONCE = 0x0001;
        static long EIMES_CANCELCOMPSTRINFOCUS = 0x0002;
        static long EIMES_COMPLETECOMPSTRKILLFOCUS = 0x0004;

        // Editbox messages
        static long EM_GETSEL = 0x00B0;
        static long EM_SETSEL = 0x00B1;
        static long EM_GETRECT = 0x00B2;
        static long EM_SETRECT = 0x00B3;
        static long EM_SETRECTNP = 0x00B4;
        static long EM_SCROLL = 0x00B5;
        static long EM_LINESCROLL = 0x00B6;
        static long EM_SCROLLCARET = 0x00B7;
        static long EM_GETMODIFY = 0x00B8;
        static long EM_SETMODIFY = 0x00B9;
        static long EM_GETLINECOUNT = 0x00BA;
        static long EM_LINEINDEX = 0x00BB;
        static long EM_SETHANDLE = 0x00BC;
        static long EM_GETHANDLE = 0x00BD;
        static long EM_GETTHUMB = 0x00BE;
        static long EM_LINELENGTH = 0x00C1;
        static long EM_REPLACESEL = 0x00C2;
        static long EM_GETLINE = 0x00C4;
        static long EM_LIMITTEXT = 0x00C5;
        static long EM_CANUNDO = 0x00C6;
        static long EM_UNDO = 0x00C7;
        static long EM_FMTLINES = 0x00C8;
        static long EM_LINEFROMCHAR = 0x00C9;
        static long EM_SETTABSTOPS = 0x00CB;
        static long EM_SETPASSWORDCHAR = 0x00CC;
        static long EM_EMPTYUNDOBUFFER = 0x00CD;
        static long EM_GETFIRSTVISIBLELINE = 0x00CE;
        static long EM_SETREADONLY = 0x00CF;
        static long EM_SETWORDBREAKPROC = 0x00D0;
        static long EM_GETWORDBREAKPROC = 0x00D1;
        static long EM_GETPASSWORDCHAR = 0x00D2;
        static long EM_SETMARGINS = 0x00D3;
        static long EM_GETMARGINS = 0x00D4;
        static long EM_GETLIMITTEXT = 0x00D5;
        static long EM_POSFROMCHAR = 0x00D6;
        static long EM_CHARFROMPOS = 0x00D7;
        static long EM_SETIMESTATUS = 0x00D8;
        static long EM_GETIMESTATUS = 0x00D9;


        static long WB_LEFT = 0;
        static long WB_RIGHT = 1;
        static long WB_ISDELIMITER = 2;

        //Button styles 
        static long BS_PUSHBUTTON = 0x00000000L;
        static long BS_DEFPUSHBUTTON = 0x00000001L;
        static long BS_CHECKBOX = 0x00000002L;
        static long BS_AUTOCHECKBOX = 0x00000003L;
        static long BS_RADIOBUTTON = 0x00000004L;
        static long BS_3STATE = 0x00000005L;
        static long BS_AUTO3STATE = 0x00000006L;
        static long BS_GROUPBOX = 0x00000007L;
        static long BS_USERBUTTON = 0x00000008L;
        static long BS_AUTORADIOBUTTON = 0x00000009L;
        static long BS_PUSHBOX = 0x0000000AL;
        static long BS_OWNERDRAW = 0x0000000BL;
        static long BS_TYPEMASK = 0x0000000FL;
        static long BS_LEFTTEXT = 0x00000020L;
        static long BS_TEXT = 0x00000000L;
        static long BS_ICON = 0x00000040L;
        static long BS_BITMAP = 0x00000080L;
        static long BS_LEFT = 0x00000100L;
        static long BS_RIGHT = 0x00000200L;
        static long BS_CENTER = 0x00000300L;
        static long BS_TOP = 0x00000400L;
        static long BS_BOTTOM = 0x00000800L;
        static long BS_VCENTER = 0x00000C00L;
        static long BS_PUSHLIKE = 0x00001000L;
        static long BS_MULTILINE = 0x00002000L;
        static long BS_NOTIFY = 0x00004000L;
        static long BS_FLAT = 0x00008000L;
        static long BS_RIGHTBUTTON = 0x00000020L;
        static long BS_SPLITBUTTON = 0x0000000C;
        static long BS_DEFSPLITBUTTON = 0x0000000D;
        static long BS_COMMANDLINK = 0x0000000E;
        static long BS_DEFCOMMANDLINK = 0x0000000F;

        static long BN_CLICKED = 0;
        static long BN_PAINT = 1;
        static long BN_HILITE = 2;
        static long BN_UNHILITE = 3;
        static long BN_DISABLE = 4;
        static long BN_DOUBLECLICKED = 5;
        static long BN_PUSHED = 2;
        static long BN_UNPUSHED = 3;
        static long BN_DBLCLK = 5;
        static long BN_SETFOCUS = 6;
        static long BN_KILLFOCUS = 7;

        // Button message
        static long BM_GETCHECK = 0x00F0;
        static long BM_SETCHECK = 0x00F1;
        static long BM_GETSTATE = 0x00F2;
        static long BM_SETSTATE = 0x00F3;
        static long BM_SETSTYLE = 0x00F4;
        static long BM_CLICK = 0x00F5;
        static long BM_GETIMAGE = 0x00F6;
        static long BM_SETIMAGE = 0x00F7;
        static long BM_SETDONTCLICK = 0x00F8;

        // Button state
        static long BST_UNCHECKED = 0x0000;
        static long BST_CHECKED = 0x0001;
        static long BST_INDETERMINATE = 0x0002;
        static long BST_PUSHED = 0x0004;
        static long BST_FOCUS = 0x0008;

        // Static styles
        static long SS_LEFT = 0x00000000L;
        static long SS_CENTER = 0x00000001L;
        static long SS_RIGHT = 0x00000002L;
        static long SS_ICON = 0x00000003L;
        static long SS_BLACKRECT = 0x00000004L;
        static long SS_GRAYRECT = 0x00000005L;
        static long SS_WHITERECT = 0x00000006L;
        static long SS_BLACKFRAME = 0x00000007L;
        static long SS_GRAYFRAME = 0x00000008L;
        static long SS_WHITEFRAME = 0x00000009L;
        static long SS_USERITEM = 0x0000000AL;
        static long SS_SIMPLE = 0x0000000BL;
        static long SS_LEFTNOWORDWRAP = 0x0000000CL;
        static long SS_OWNERDRAW = 0x0000000DL;
        static long SS_BITMAP = 0x0000000EL;
        static long SS_ENHMETAFILE = 0x0000000FL;
        static long SS_ETCHEDHORZ = 0x00000010L;
        static long SS_ETCHEDVERT = 0x00000011L;
        static long SS_ETCHEDFRAME = 0x00000012L;
        static long SS_TYPEMASK = 0x0000001FL;
        static long SS_REALSIZECONTROL = 0x00000040L;
        static long SS_NOPREFIX = 0x00000080L;
        static long SS_NOTIFY = 0x00000100L;
        static long SS_CENTERIMAGE = 0x00000200L;
        static long SS_RIGHTJUST = 0x00000400L;
        static long SS_REALSIZEIMAGE = 0x00000800L;
        static long SS_SUNKEN = 0x00001000L;
        static long SS_EDITCONTROL = 0x00002000L;
        static long SS_ENDELLIPSIS = 0x00004000L;
        static long SS_PATHELLIPSIS = 0x00008000L;
        static long SS_WORDELLIPSIS = 0x0000C000L;
        static long SS_ELLIPSISMASK = 0x0000C000L;
        static long STM_SETICON = 0x0170;
        static long STM_GETICON = 0x0171;
        static long STM_SETIMAGE = 0x0172;
        static long STM_GETIMAGE = 0x0173;
        static long STM_MSGMAX = 0x0174;
        static long STN_CLICKED = 0;
        static long STN_DBLCLK = 1;
        static long STN_ENABLE = 2;
        static long STN_DISABLE = 3;

        //==============================================
        //Menu constants
        //==============================================

        /// <summary>
        /// Uses a bitmap as the menu item. The lpNewItem parameter contains a handle to the bitmap.
        /// </summary>
        static long MF_BITMAP = 0x00000004;
        /// <summary>
        /// Places a check mark next to the menu item. If the application provides check-mark bitmaps (see SetMenuItemBitmaps; this flag displays the check-mark bitmap next to the menu item.
        /// </summary>
        static long MF_CHECKED = 0x00000008;
        /// <summary>
        /// Disables the menu item so that it cannot be selected; but the flag does not gray it.
        /// </summary>
        static long MF_DISABLED = 0x00000002;
        /// <summary>
        /// Enables the menu item so that it can be selected; and restores it from its grayed state.
        /// </summary>
        static long MF_ENABLED = 0x00000000;
        /// <summary>
        /// Disables the menu item and grays it so that it cannot be selected.
        /// </summary>
        static long MF_GRAYED = 0x00000001;
        /// <summary>
        /// Functions the same as the MF_MENUBREAK flag for a menu bar. For a drop-down menu; submenu; or shortcut menu; the new column is separated from the old column by a vertical line.
        /// </summary>
        static long MF_MENUBARBREAK = 0x00000020;
        /// <summary>
        /// Places the item on a new line (for a menu bar) or in a new column (for a drop-down menu; submenu; or shortcut menu) without separating columns.
        /// </summary>
        static long MF_MENUBREAK = 0x00000040;
        /// <summary>
        /// Specifies that the item is an owner-drawn item. Before the menu is displayed for the first time; the window that owns the menu receives a WM_MEASUREITEM message to retrieve the width and height of the menu item. The WM_DRAWITEM message is then sent to the window procedure of the owner window whenever the appearance of the menu item must be updated.
        /// </summary>
        static long MF_OWNERDRAW = 0x00000100;
        /// <summary>
        /// Specifies that the menu item opens a drop-down menu or submenu. The uIDNewItem parameter specifies a handle to the drop-down menu or submenu. This flag is used to add a menu name to a menu bar; or a menu item that opens a submenu to a drop-down menu; submenu; or shortcut menu.
        /// </summary>
        static long MF_POPUP = 0x00000010;
        /// <summary>
        /// Draws a horizontal dividing line. This flag is used only in a drop-down menu; submenu; or shortcut menu. The line cannot be grayed; disabled; or highlighted. The lpNewItem and uIDNewItem parameters are ignored.
        /// </summary>
        static long MF_SEPARATOR = 0x00000800;
        /// <summary>
        /// Specifies that the menu item is a text string; the lpNewItem parameter is a pointer to the string.
        /// </summary>
        static long MF_STRING = 0x00000000;
        /// <summary>
        /// Does not place a check mark next to the item (default). If the application supplies check-mark bitmaps (see SetMenuItemBitmaps); this flag displays the clear bitmap next to the menu item.
        /// </summary>
        static long MF_UNCHECKED = 0x00000000;

        static long MF_BYCOMMAND = 0;
        static long MF_BYPOSITION = 0x400;
        static long MF_BYHANDLE = 0x800; //introduced by the LCL
        static long MF_USECHECKBITMAPS = 0x200;
        static long MF_UNHILITE = 0;
        static long MF_HILITE = 0x80;
        static long MF_DEFAULT = 0x1000;
        static long MF_SYSMENU = 0x2000;
        static long MF_HELP = 0x4000;
        static long MF_RIGHTJUSTIFY = 0x4000;
        static long MF_MOUSESELECT = 0x8000;
        static long MF_UNSUPPORTED = 0xFFFFFFFF;
        static long MF_REMOVE = 0x1000;

        static long OkOnly = 0x000000;
        static long OkCancel = 0x000001;
        static long AbortRetryIgnore = 0x000002;
        static long YesNoCancel = 0x000003;
        static long YesNo = 0x000004;
        static long RetryCancel = 0x000005;
        static long CancelTryContinue = 0x000006;
        static long IconHand = 0x000010;
        static long IconQuestion = 0x000020;
        static long IconExclamation = 0x000030;
        static long IconAsterisk = 0x000040;
        static long UserIcon = 0x000080;
        static long IconWarning = 0x000030;
        static long IconError = 0x000010;
        static long IconInformation = 0x000040;
        static long IconStop = 0x000010;
        static long DefButton1 = 0x000000;
        static long DefButton2 = 0x000100;
        static long DefButton3 = 0x000200;
        static long DefButton4 = 0x000300;
        static long ApplicationModal = 0x000000;
        static long SystemModal = 0x001000;
        static long TaskModal = 0x002000;
        static long Help = 0x004000;
        static long NoFocus = 0x008000;
        static long SetForeground = 0x010000;
        static long DefaultDesktopOnly = 0x020000;
        static long Topmost = 0x040000;
        static long Right = 0x080000;
        static long RTLReading = 0x100000;

        // Window extended sytles
        /// <summary>
        /// Specifies a window that accepts drag-drop files.
        /// </summary>
        static long WS_EX_ACCEPTFILES = 0x00000010;
        /// <summary>
        /// Forces a top-level window onto the taskbar when the window is visible.
        /// </summary>
        static long WS_EX_APPWINDOW = 0x00040000;
        /// <summary>
        /// Specifies a window that has a border with a sunken edge.
        /// </summary>
        static long WS_EX_CLIENTEDGE = 0x00000200;
        /// <summary>
        /// Specifies a window that paints all descendants in bottom-to-top painting order using double-buffering.
        /// This cannot be used if the window has a class style of either CS_OWNDC or CS_CLASSDC. This style is not supported in Windows 2000.
        /// </summary>
        /// <remarks>
        /// With WS_EX_COMPOSITED set; all descendants of a window get bottom-to-top painting order using double-buffering.
        /// Bottom-to-top painting order allows a descendent window to have translucency (alpha) and transparency (color-key) effects;
        /// but only if the descendent window also has the WS_EX_TRANSPARENT bit set.
        /// Double-buffering allows the window and its descendents to be painted without flicker.
        /// </remarks>
        static long WS_EX_COMPOSITED = 0x02000000;
        /// <summary>
        /// Specifies a window that includes a question mark in the title bar. When the user clicks the question mark;
        /// the cursor changes to a question mark with a pointer. If the user then clicks a child window; the child receives a WM_HELP message.
        /// The child window should pass the message to the parent window procedure; which should call the WinHelp function using the HELP_WM_HELP command.
        /// The Help application displays a pop-up window that typically contains help for the child window.
        /// WS_EX_CONTEXTHELP cannot be used with the WS_MAXIMIZEBOX or WS_MINIMIZEBOX styles.
        /// </summary>
        static long WS_EX_CONTEXTHELP = 0x00000400;
        /// <summary>
        /// Specifies a window which contains child windows that should take part in dialog box navigation.
        /// If this style is specified; the dialog manager recurses into children of this window when performing navigation operations
        /// such as handling the TAB key; an arrow key; or a keyboard mnemonic.
        /// </summary>
        static long WS_EX_CONTROLPARENT = 0x00010000;
        /// <summary>
        /// Specifies a window that has a double border.
        /// </summary>
        static long WS_EX_DLGMODALFRAME = 0x00000001;
        /// <summary>
        /// Specifies a window that is a layered window.
        /// This cannot be used for child windows or if the window has a class style of either CS_OWNDC or CS_CLASSDC.
        /// </summary>
        static long WS_EX_LAYERED = 0x00080000;
        /// <summary>
        /// Specifies a window with the horizontal origin on the right edge. Increasing horizontal values advance to the left.
        /// The shell language must support reading-order alignment for this to take effect.
        /// </summary>
        static long WS_EX_LAYOUTRTL = 0x00400000;
        /// <summary>
        /// Specifies a window that has generic left-aligned properties. This is the default.
        /// </summary>
        static long WS_EX_LEFT = 0x00000000;
        /// <summary>
        /// Specifies a window with the vertical scroll bar (if present) to the left of the client area.
        /// The shell language must support reading-order alignment for this to take effect.
        /// </summary>
        static long WS_EX_LEFTSCROLLBAR = 0x00004000;
        /// <summary>
        /// Specifies a window that displays text using left-to-right reading-order properties. This is the default.
        /// </summary>
        static long WS_EX_LTRREADING = 0x00000000;
        /// <summary>
        /// Specifies a multiple-document interface (MDI) child window.
        /// </summary>
        static long WS_EX_MDICHILD = 0x00000040;
        /// <summary>
        /// Specifies a top-level window created with this style does not become the foreground window when the user clicks it.
        /// The system does not bring this window to the foreground when the user minimizes or closes the foreground window.
        /// The window does not appear on the taskbar by default. To force the window to appear on the taskbar; use the WS_EX_APPWINDOW style.
        /// To activate the window; use the SetActiveWindow or SetForegroundWindow function.
        /// </summary>
        static long WS_EX_NOACTIVATE = 0x08000000;
        /// <summary>
        /// Specifies a window which does not pass its window layout to its child windows.
        /// </summary>
        static long WS_EX_NOINHERITLAYOUT = 0x00100000;
        /// <summary>
        /// Specifies that a child window created with this style does not send the WM_PARENTNOTIFY message to its parent window when it is created or destroyed.
        /// </summary>
        static long WS_EX_NOPARENTNOTIFY = 0x00000004;
        /// <summary>
        /// The window does not render to a redirection surface.
        /// This is for windows that do not have visible content or that use mechanisms other than surfaces to provide their visual.
        /// </summary>
        static long WS_EX_NOREDIRECTIONBITMAP = 0x00200000;
        /// <summary>
        /// Specifies an overlapped window.
        /// </summary>
        static long WS_EX_OVERLAPPEDWINDOW = 0x00000100 | 0x00000200;
        /// <summary>
        /// Specifies a palette window; which is a modeless dialog box that presents an array of commands.
        /// </summary>
        static long WS_EX_PALETTEWINDOW = 0x00000100 | 0x00000200 | 0x00000008;
        /// <summary>
        /// Specifies a window that has generic "right-aligned" properties. This depends on the window class.
        /// The shell language must support reading-order alignment for this to take effect.
        /// Using the WS_EX_RIGHT style has the same effect as using the SS_RIGHT (static); ES_RIGHT (edit); and BS_RIGHT/BS_RIGHTBUTTON (button) control styles.
        /// </summary>
        static long WS_EX_RIGHT = 0x00001000;
        /// <summary>
        /// Specifies a window with the vertical scroll bar (if present) to the right of the client area. This is the default.
        /// </summary>
        static long WS_EX_RIGHTSCROLLBAR = 0x00000000;
        /// <summary>
        /// Specifies a window that displays text using right-to-left reading-order properties.
        /// The shell language must support reading-order alignment for this to take effect.
        /// </summary>
        static long WS_EX_RTLREADING = 0x00002000;
        /// <summary>
        /// Specifies a window with a three-dimensional border style intended to be used for items that do not accept user input.
        /// </summary>
        static long WS_EX_STATICEDGE = 0x00020000;
        /// <summary>
        /// Specifies a window that is intended to be used as a floating toolbar.
        /// A tool window has a title bar that is shorter than a normal title bar; and the window title is drawn using a smaller font.
        /// A tool window does not appear in the taskbar or in the dialog that appears when the user presses ALT+TAB.
        /// If a tool window has a system menu; its icon is not displayed on the title bar.
        /// However; you can display the system menu by right-clicking or by typing ALT+SPACE.
        /// </summary>
        static long WS_EX_TOOLWINDOW = 0x00000080;
        /// <summary>
        /// Specifies a window that should be placed above all non-topmost windows and should stay above them; even when the window is deactivated.
        /// To add or remove this style; use the SetWindowPos function.
        /// </summary>
        static long WS_EX_TOPMOST = 0x00000008;
        /// <summary>
        /// Specifies a window that should not be painted until siblings beneath the window (that were created by the same thread) have been painted.
        /// The window appears transparent because the bits of underlying sibling windows have already been painted.
        /// To achieve transparency without these restrictions; use the SetWindowRgn function.
        /// </summary>
        static long WS_EX_TRANSPARENT = 0x00000020;
        /// <summary>
        /// Specifies a window that has a border with a raised edge.
        /// </summary>
        static long WS_EX_WINDOWEDGE = 0x00000100;

        static long SCROLLBAR = 0;
        static long BACKGROUND = 1;
        static long DESKTOP = 1;
        static long ACTIVECAPTION = 2;
        static long INACTIVECAPTION = 3;
        static long MENU = 4;
        static long WINDOW = 5;
        static long WINDOWFRAME = 6;
        static long MENUTEXT = 7;
        static long WINDOWTEXT = 8;
        static long CAPTIONTEXT = 9;
        static long ACTIVEBORDER = 10;
        static long INACTIVEBORDER = 11;
        static long APPWORKSPACE = 12;
        static long HIGHLIGHT = 13;
        static long HIGHLIGHTTEXT = 14;
        static long BTNFACE = 15;
        static long THREEDFACE = 15;
        static long BTNSHADOW = 16;
        static long THREEDSHADOW = 16;
        static long GRAYTEXT = 17;
        static long BTNTEXT = 18;
        static long INACTIVECAPTIONTEXT = 19;
        static long BTNHIGHLIGHT = 20;
        static long TREEDHIGHLIGHT = 20;
        static long THREEDHILIGHT = 20;
        static long BTNHILIGHT = 20;
        static long THREEDDKSHADOW = 21;
        static long THREEDLIGHT = 22;
        static long INFOTEXT = 23;
        static long INFOBK = 24;
        static long IDC_ARROW = 32512;
        static long IDC_IBEAM = 32513;
        static long IDC_WAIT = 32514;
        static long IDC_CROSS = 32515;
        static long IDC_UPARROW = 32516;
        static long IDC_SIZE = 32640;
        static long IDC_ICON = 32641;
        static long IDC_SIZENWSE = 32642;
        static long IDC_SIZENESW = 32643;
        static long IDC_SIZEWE = 32644;
        static long IDC_SIZENS = 32645;
        static long IDC_SIZEALL = 32646;
        static long IDC_NO = 32648;
        static long IDC_HAND = 32649;
        static long IDC_APPSTARTING = 32650;
        static long IDC_HELP = 32651;

        /// <summary>
        /// Aligns the window's client area on a byte boundary (in the x direction). This style affects the width of the window and its horizontal placement on the display.
        /// </summary>
        static long ByteAlignClient = 0x1000;
        /// <summary>
        /// Aligns the window on a byte boundary (in the x direction). This style affects the width of the window and its horizontal placement on the display.
        /// </summary>
        static long ByteAlignWindow = 0x2000;
        /// <summary>
        /// Allocates one device context to be shared by all windows in the class.
        /// Because window classes are process specific; it is possible for multiple threads of an application to create a window of the same class.
        /// It is also possible for the threads to attempt to use the device context simultaneously. When this happens; the system allows only one thread to successfully finish its drawing operation.
        /// </summary>
        static long ClassDC = 0x40;
        /// <summary>Sends a double-click message to the window procedure when the user double-clicks the mouse while the cursor is within a window belonging to the class.</summary>
        static long DoubleClicks = 0x8;
        /// <summary>
        /// Enables the drop shadow effect on a window. The effect is turned on and off through SPI_SETDROPSHADOW.
        /// Typically; this is enabled for small; short-lived windows such as menus to emphasize their Z order relationship to other windows.
        /// </summary>
        static long DropShadow = 0x20000;
        /// <summary>
        /// Indicates that the window class is an application global class. For more information; see the "Application Global Classes" section of About Window Classes.
        /// </summary>
        static long GlobalClass = 0x4000;
        /// <summary>
        /// Redraws the entire window if a movement or size adjustment changes the width of the client area.
        /// </summary>
        static long HorizontalRedraw = 0x2;
        /// <summary>
        /// Disables Close on the window menu.
        /// </summary>
        static long NoClose = 0x200;
        /// <summary>
        /// Allocates a unique device context for each window in the class.
        /// </summary>
        static long OwnDC = 0x20;
        /// <summary>
        /// Sets the clipping rectangle of the child window to that of the parent window so that the child can draw on the parent.
        /// A window with the CS_PARENTDC style bit receives a regular device context from the system's cache of device contexts.
        /// It does not give the child the parent's device context or device context settings. Specifying CS_PARENTDC enhances an application's performance.
        /// </summary>
        static long ParentDC = 0x80;
        /// <summary>
        /// Saves; as a bitmap; the portion of the screen image obscured by a window of this class.
        /// When the window is removed; the system uses the saved bitmap to restore the screen image; including other windows that were obscured.
        /// Therefore; the system does not send WM_PAINT messages to windows that were obscured if the memory used by the bitmap has not been discarded and if other screen actions have not invalidated the stored image.
        /// This style is useful for small windows (for example; menus or dialog boxes) that are displayed briefly and then removed before other screen activity takes place.
        /// This style increases the time required to display the window; because the system must first allocate memory to store the bitmap.
        /// </summary>
        static long SaveBits = 0x800;
        /// <summary>Redraws the entire window if a movement or size adjustment changes the height of the client area.</summary>
        static long VerticalRedraw = 0x1;

        //==============================================
        //Window Styles
        //==============================================
        /// <summary>
        /// The window has a thin-line border.
        /// </summary>
        static long WS_BORDER = 0x800000;
        /// <summary>
        /// The window has a title bar (includes the WS_BORDER style).
        /// </summary>
        static long WS_CAPTION = 0xc00000;
        /// <summary>
        /// The window is a child window. A window with this style cannot have a menu bar. This style cannot be used with the WS_POPUP style.
        /// </summary>
        static long WS_CHILD = 0x40000000;
        /// <summary>
        /// Excludes the area occupied by child windows when drawing occurs within the parent window. This style is used when creating the parent window.
        /// </summary>
        static long WS_CLIPCHILDREN = 0x2000000;
        /// <summary>
        /// Clips child windows relative to each other; that is; when a particular child window receives a WM_PAINT message; the WS_CLIPSIBLINGS style clips all other overlapping child windows out of the region of the child window to be updated.
        /// If WS_CLIPSIBLINGS is not specified and child windows overlap; it is possible; when drawing within the client area of a child window; to draw within the client area of a neighboring child window.
        /// </summary>
        static long WS_CLIPSIBLINGS = 0x4000000;
        /// <summary>
        /// The window is initially disabled. A disabled window cannot receive input from the user. To change this after a window has been created; use the EnableWindow function.
        /// </summary>
        static long WS_DISABLED = 0x8000000;
        /// <summary>
        /// The window has a border of a style typically used with dialog boxes. A window with this style cannot have a title bar.
        /// </summary>
        static long WS_DLGFRAME = 0x400000;
        /// <summary>
        /// The window is the first control of a group of controls. The group consists of this first control and all controls defined after it; up to the next control with the WS_GROUP style.
        /// The first control in each group usually has the WS_TABSTOP style so that the user can move from group to group. The user can subsequently change the keyboard focus from one control in the group to the next control in the group by using the direction keys.
        /// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created; use the SetWindowLong function.
        /// </summary>
        static long WS_GROUP = 0x20000;
        /// <summary>
        /// The window has a horizontal scroll bar.
        /// </summary>
        static long WS_HSCROLL = 0x100000;
        /// <summary>
        /// The window is initially maximized.
        /// </summary>
        static long WS_MAXIMIZE = 0x1000000;
        /// <summary>
        /// The window has a maximize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.
        /// </summary>
        static long WS_MAXIMIZEBOX = 0x10000;
        /// <summary>
        /// The window is initially minimized.
        /// </summary>
        static long WS_MINIMIZE = 0x20000000;
        /// <summary>
        /// The window has a minimize button. Cannot be combined with the WS_EX_CONTEXTHELP style. The WS_SYSMENU style must also be specified.</summary>
        static long WS_MINIMIZEBOX = 0x20000;
        /// <summary>
        /// The window is an overlapped window. An overlapped window has a title bar and a border.
        /// </summary>
        static long WS_OVERLAPPED = 0x0;
        /// <summary>
        /// The window is an overlapped window.
        /// </summary>
        static long WS_OVERLAPPEDWINDOW = 0x0 | 0xc00000 | 0x80000 | 0x40000 | 0x20000 | 0x10000;
        /// <summary>
        /// The window is a pop-up window. This style cannot be used with the WS_CHILD style.
        /// </summary>
        static long WS_POPUP = 0x80000000u;
        /// <summary>
        /// The window is a pop-up window. The WS_CAPTION and WS_POPUPWINDOW styles must be combined to make the window menu visible.
        /// </summary>
        static long WS_POPUPWINDOW = (0x80000000u | 0x800000 | 0x80000);
        /// <summary>
        /// The window has a sizing border.
        /// </summary>
        static long WS_SIZEFRAME = 0x40000;
        /// <summary>
        /// The window has a window menu on its title bar. The WS_CAPTION style must also be specified.
        /// </summary>
        static long WS_SYSMENU = 0x80000;
        /// <summary>
        /// The window is a control that can receive the keyboard focus when the user presses the TAB key.
        /// Pressing the TAB key changes the keyboard focus to the next control with the WS_TABSTOP style.  
        /// You can turn this style on and off to change dialog box navigation. To change this style after a window has been created; use the SetWindowLong function.
        /// For user-created windows and modeless dialogs to work with tab stops; alter the message loop to call the IsDialogMessage function.
        /// </summary>
        static long WS_TABSTOP = 0x10000;
        /// <summary>
        /// The window is initially visible. This style can be turned on and off by using the ShowWindow or SetWindowPos function.
        /// </summary>
        static long WS_VISIBLE = 0x10000000;
        /// <summary>
        /// The window has a vertical scroll bar.
        /// </summary>
        static long WS_VSCROLL = 0x200000;

        static long WS_THICKFRAME = (0x40000);
        static long WS_TILED = WS_OVERLAPPED;
        static long WS_ICONIC = WS_MINIMIZE;
        static long WS_SIZEBOX = WS_THICKFRAME;

        //Common Window Styles 
        static long WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW;
        static long WS_CHILDWINDOW = (WS_CHILD);

        /// <summary>
        /// If the calling thread and the thread that owns the window are attached to different input queues; 
        /// the system posts the request to the thread that owns the window. This prevents the calling thread from 
        /// blocking its execution while other threads process the request.
        /// </summary>
        /// <remarks>
        /// SWP_ASYNCWINDOWPOS
        /// </remarks>
        static long AsynchronousWindowPosition = 0x4000;
        /// <summary>
        /// Prevents generation of the WM_SYNCPAINT message.
        /// </summary>
        /// <remarks>
        /// SWP_DEFERERASE
        /// </remarks>
        static long DeferErase = 0x2000;
        /// <summary>Draws a frame (defined in the window's class description) around the window.</summary>
        /// <remarks>SWP_DRAWFRAME</remarks>
        static long DrawFrame = 0x0020;
        /// <summary>Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to 
        /// the window; even if the window's size is not being changed. If this flag is not specified; WM_NCCALCSIZE 
        /// is sent only when the window's size is being changed.</summary>
        /// <remarks>SWP_FRAMECHANGED</remarks>
        static long FrameChanged = 0x0020;
        /// <summary>Does not activate the window. If this flag is not set; the window is activated and moved to the 
        /// top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter 
        /// parameter).</summary>
        /// <remarks>SWP_NOACTIVATE</remarks>
        static long DoNotActivate = 0x0010;
        /// <summary>
        /// Discards the entire contents of the client area. If this flag is not specified; the valid 
        /// contents of the client area are saved and copied back into the client area after the window is sized or 
        /// repositioned.
        /// </summary>
        /// <remarks>
        /// SWP_NOCOPYBITS
        /// </remarks>
        static long DoNotCopyBits = 0x0100;
        /// <summary>
        /// Retains the current position (ignores X and Y parameters).
        /// </summary>
        /// <remarks>
        /// SWP_NOMOVE
        /// </remarks>
        static long IgnoreMove = 0x0002;
        /// <summary>
        /// Does not change the owner window's position in the Z order.
        /// </summary>
        /// <remarks>
        /// SWP_NOOWNERZORDER
        /// </remarks>
        static long DoNotChangeOwnerZOrder = 0x0200;
        /// <summary>Does not redraw changes. If this flag is set; no repainting of any kind occurs. This applies to 
        /// the client area; the nonclient area (including the title bar and scroll bars); and any part of the parent 
        /// window uncovered as a result of the window being moved. When this flag is set; the application must 
        /// explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</summary>
        /// <remarks>SWP_NOREDRAW</remarks>
        static long DoNotRedraw = 0x0008;
        /// <summary>Same as the SWP_NOOWNERZORDER flag.</summary>
        /// <remarks>SWP_NOREPOSITION</remarks>
        static long DoNotReposition = 0x0200;
        /// <summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</summary>
        /// <remarks>SWP_NOSENDCHANGING</remarks>
        static long DoNotSendChangingEvent = 0x0400;
        /// <summary>Retains the current size (ignores the cx and cy parameters).</summary>
        /// <remarks>SWP_NOSIZE</remarks>
        static long IgnoreResize = 0x0001;
        /// <summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</summary>
        /// <remarks>SWP_NOZORDER</remarks>
        static long IgnoreZOrder = 0x0004;
        /// <summary>
        /// Retrieves the address of the menu name string. The string identifies the menu resource associated with the class.
        /// </summary>
        static long GCLP_MENUNAME = -8;
        /// <summary>
        /// Retrieves a handle to the background brush associated with the class.
        /// </summary>
        static long GCLP_HBRBACKGROUND = -10;
        /// <summary>
        /// Retrieves a handle to the cursor associated with the class.
        /// </summary>
        static long GCLP_HCURSOR = -12;
        /// <summary>
        /// Retrieves a handle to the icon associated with the class.
        /// </summary>
        static long GCLP_HICON = -14;
        /// <summary>
        /// Retrieves a handle to the module that registered the class.
        /// </summary>
        static long GCLP_HMODULE = -16;
        /// <summary>
        /// Retrieves the size; in bytes; of the extra window memory associated with each window in the class. For information on how to access this memory; see GetWindowLong.
        /// </summary>
        static long GCL_CBWNDEXTRA = -18;
        /// <summary>
        /// Retrieves the size; in bytes; of the extra memory associated with the class.
        /// </summary>
        static long GCL_CBCLSEXTRA = -20;
        /// <summary>
        /// Retrieves the address of the window procedure; or a handle representing the address of the window procedure. You must use the CallWindowProc function to call the window procedure.
        /// </summary>
        static long GCLP_WNDPROC = -24;
        /// <summary>
        /// Retrieves the window-class style bits.
        /// </summary>
        static long GCL_STYLE = -26;
        /// <summary>
        /// Retrieves a handle to the small icon associated with the class.
        /// </summary>
        static long GCLP_HICONSM = -34;
        /// <summary>
        /// Retrieves an ATOM value that uniquely identifies the window class. This is the same atom that the RegisterClassEx function returns.
        /// </summary>
        static long GCW_ATOM = -32;
        /// <summary>
        /// Hides the window and activates another window.
        /// </summary>
        static long Hide = 0;
        /// <summary>
        /// Activates and displays a window. If the window is minimized or
        /// maximized; the system restores it to its original size and position.
        /// An application should specify this flag when displaying the window
        /// for the first time.
        /// </summary>
        static long Normal = 1;
        /// <summary>
        /// Activates the window and displays it as a minimized window.
        /// </summary>
        static long ShowMinimized = 2;
        /// <summary>
        /// Maximizes the specified window.
        /// </summary>
        static long Maximize = 3; // is this the right value?
        /// <summary>
        /// Activates the window and displays it as a maximized window.
        /// </summary>      
        static long ShowMaximized = 3;
        /// <summary>
        /// Displays a window in its most recent size and position. This value
        /// is similar to <see cref="Win32.ShowWindowCommand.Normal"/>; except
        /// the window is not activated.
        /// </summary>
        static long ShowNoActivate = 4;
        /// <summary>
        /// Activates the window and displays it in its current size and position.
        /// </summary>
        static long Show = 5;
        /// <summary>
        /// Minimizes the specified window and activates the next top-level
        /// window in the Z order.
        /// </summary>
        static long Minimize = 6;
        /// <summary>
        /// Displays the window as a minimized window. This value is similar to
        /// <see cref="Win32.ShowWindowCommand.ShowMinimized"/>; except the
        /// window is not activated.
        /// </summary>
        static long ShowMinNoActive = 7;
        /// <summary>
        /// Displays the window in its current size and position. This value is
        /// similar to <see cref="Win32.ShowWindowCommand.Show"/>; except the
        /// window is not activated.
        /// </summary>
        static long ShowNA = 8;
        /// <summary>
        /// Activates and displays the window. If the window is minimized or
        /// maximized; the system restores it to its original size and position.
        /// An application should specify this flag when restoring a minimized window.
        /// </summary>
        static long Restore = 9;
        /// <summary>
        /// Sets the show state based on the SW_* value specified in the
        /// STARTUPINFO structure passed to the CreateProcess function by the
        /// program that started the application.
        /// </summary>
        static long ShowDefault = 10;
        /// <summary>
        ///  <b>Windows 2000/XP:</b> Minimizes a window; even if the thread
        /// that owns the window is not responding. This flag should only be
        /// used when minimizing windows from a different thread.
        /// </summary>
        static long ForceMinimize = 11;

        /// <summary>
        /// The WM_NULL message performs no operation. An application sends the WM_NULL message if it wants to post a message that the recipient window will ignore.
        /// </summary>
        static long NULL = 0x0000;
        /// <summary>
        /// The WM_CREATE message is sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. (The message is sent before the function returns.) The window procedure of the new window receives this message after the window is created; but before the window becomes visible.
        /// </summary>
        static long CREATE = 0x0001;
        /// <summary>
        /// The WM_DESTROY message is sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window is removed from the screen.
        /// This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. During the processing of the message; it can be assumed that all child windows still exist.
        /// /// </summary>
        static long DESTROY = 0x0002;
        /// <summary>
        /// The WM_MOVE message is sent after a window has been moved.
        /// </summary>
        static long MOVE = 0x0003;
        /// <summary>
        /// The WM_SIZE message is sent to a window after its size has changed.
        /// </summary>
        static long SIZE = 0x0005;
        /// <summary>
        /// The WM_ACTIVATE message is sent to both the window being activated and the window being deactivated. If the windows use the same input queue; the message is sent synchronously; first to the window procedure of the top-level window being deactivated; then to the window procedure of the top-level window being activated. If the windows use different input queues; the message is sent asynchronously; so the window is activated immediately.
        /// </summary>
        static long ACTIVATE = 0x0006;
        /// <summary>
        /// The WM_SETFOCUS message is sent to a window after it has gained the keyboard focus.
        /// </summary>
        static long SETFOCUS = 0x0007;
        /// <summary>
        /// The WM_KILLFOCUS message is sent to a window immediately before it loses the keyboard focus.
        /// </summary>
        static long KILLFOCUS = 0x0008;
        /// <summary>
        /// The WM_ENABLE message is sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. This message is sent before the EnableWindow function returns; but after the enabled state (WS_DISABLED style bit) of the window has changed.
        /// </summary>
        static long ENABLE = 0x000A;
        /// <summary>
        /// An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes in that window from being redrawn.
        /// </summary>
        static long SETREDRAW = 0x000B;
        /// <summary>
        /// An application sends a WM_SETTEXT message to set the text of a window.
        /// </summary>
        static long SETTEXT = 0x000C;
        /// <summary>
        /// An application sends a WM_GETTEXT message to copy the text that corresponds to a window into a buffer provided by the caller.
        /// </summary>
        static long GETTEXT = 0x000D;
        /// <summary>
        /// An application sends a WM_GETTEXTLENGTH message to determine the length; in characters; of the text associated with a window.
        /// </summary>
        static long GETTEXTLENGTH = 0x000E;
        /// <summary>
        /// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. The message is sent when the UpdateWindow or RedrawWindow function is called; or by the DispatchMessage function when the application obtains a WM_PAINT message by using the GetMessage or PeekMessage function.
        /// </summary>
        static long PAINT = 0x000F;
        /// <summary>
        /// The WM_CLOSE message is sent as a signal that a window or an application should terminate.
        /// </summary>
        static long CLOSE = 0x0010;
        /// <summary>
        /// The WM_QUERYENDSESSION message is sent when the user chooses to end the session or when an application calls one of the system shutdown functions. If any application returns zero; the session is not ended. The system stops sending WM_QUERYENDSESSION messages as soon as one application returns zero.
        /// After processing this message; the system sends the WM_ENDSESSION message with the wParam parameter set to the results of the WM_QUERYENDSESSION message.
        /// </summary>
        static long QUERYENDSESSION = 0x0011;
        /// <summary>
        /// The WM_QUERYOPEN message is sent to an icon when the user requests that the window be restored to its previous size and position.
        /// </summary>
        static long QUERYOPEN = 0x0013;
        /// <summary>
        /// The WM_ENDSESSION message is sent to an application after the system processes the results of the WM_QUERYENDSESSION message. The WM_ENDSESSION message informs the application whether the session is ending.
        /// </summary>
        static long ENDSESSION = 0x0016;
        /// <summary>
        /// The WM_QUIT message indicates a request to terminate an application and is generated when the application calls the PostQuitMessage function. It causes the GetMessage function to return zero.
        /// </summary>
        static long QUIT = 0x0012;
        /// <summary>
        /// The WM_ERASEBKGND message is sent when the window background must be erased (for example; when a window is resized). The message is sent to prepare an invalidated portion of a window for painting.
        /// </summary>
        static long ERASEBKGND = 0x0014;
        /// <summary>
        /// This message is sent to all top-level windows when a change is made to a system color setting.
        /// </summary>
        static long SYSCOLORCHANGE = 0x0015;
        /// <summary>
        /// The WM_SHOWWINDOW message is sent to a window when the window is about to be hidden or shown.
        /// </summary>
        static long SHOWWINDOW = 0x0018;
        /// <summary>
        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo function sends this message after an application uses the function to change a setting in WIN.INI.
        /// Note  The WM_WININICHANGE message is provided only for compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
        /// </summary>
        static long WININICHANGE = 0x001A;
        /// <summary>
        /// An application sends the WM_WININICHANGE message to all top-level windows after making a change to the WIN.INI file. The SystemParametersInfo function sends this message after an application uses the function to change a setting in WIN.INI.
        /// Note  The WM_WININICHANGE message is provided only for compatibility with earlier versions of the system. Applications should use the WM_SETTINGCHANGE message.
        /// </summary>
        static long SETTINGCHANGE = 0x001A;
        /// <summary>
        /// The WM_DEVMODECHANGE message is sent to all top-level windows whenever the user changes device-mode settings.
        /// </summary>
        static long DEVMODECHANGE = 0x001B;
        /// <summary>
        /// The WM_ACTIVATEAPP message is sent when a window belonging to a different application than the active window is about to be activated. The message is sent to the application whose window is being activated and to the application whose window is being deactivated.
        /// </summary>
        static long ACTIVATEAPP = 0x001C;
        /// <summary>
        /// An application sends the WM_FONTCHANGE message to all top-level windows in the system after changing the pool of font resources.
        /// </summary>
        static long FONTCHANGE = 0x001D;
        /// <summary>
        /// A message that is sent whenever there is a change in the system time.
        /// </summary>
        static long TIMECHANGE = 0x001E;
        /// <summary>
        /// The WM_CANCELMODE message is sent to cancel certain modes; such as mouse capture. For example; the system sends this message to the active window when a dialog box or message box is displayed. Certain functions also send this message explicitly to the specified window regardless of whether it is the active window. For example; the EnableWindow function sends this message when disabling the specified window.
        /// </summary>
        static long CANCELMODE = 0x001F;
        /// <summary>
        /// The WM_SETCURSOR message is sent to a window if the mouse causes the cursor to move within a window and mouse input is not captured.
        /// </summary>
        static long SETCURSOR = 0x0020;
        /// <summary>
        /// The WM_MOUSEACTIVATE message is sent when the cursor is in an inactive window and the user presses a mouse button. The parent window receives this message only if the child window passes it to the DefWindowProc function.
        /// </summary>
        static long MOUSEACTIVATE = 0x0021;
        /// <summary>
        /// The WM_CHILDACTIVATE message is sent to a child window when the user clicks the window's title bar or when the window is activated; moved; or sized.
        /// </summary>
        static long CHILDACTIVATE = 0x0022;
        /// <summary>
        /// The WM_QUEUESYNC message is sent by a computer-based training (CBT) application to separate user-input messages from other messages sent through the WH_JOURNALPLAYBACK Hook procedure.
        /// </summary>
        static long QUEUESYNC = 0x0023;
        /// <summary>
        /// The WM_GETMINMAXINFO message is sent to a window when the size or position of the window is about to change. An application can use this message to override the window's default maximized size and position; or its default minimum or maximum tracking size.
        /// </summary>
        static long GETMINMAXINFO = 0x0024;
        /// <summary>
        /// Windows NT 3.51 and earlier: The WM_PAINTICON message is sent to a minimized window when the icon is to be painted. This message is not sent by newer versions of Microsoft Windows; except in unusual circumstances explained in the Remarks.
        /// </summary>
        static long PAINTICON = 0x0026;
        /// <summary>
        /// Windows NT 3.51 and earlier: The WM_ICONERASEBKGND message is sent to a minimized window when the background of the icon must be filled before painting the icon. A window receives this message only if a class icon is defined for the window; otherwise; WM_ERASEBKGND is sent. This message is not sent by newer versions of Windows.
        /// </summary>
        static long ICONERASEBKGND = 0x0027;
        /// <summary>
        /// The WM_NEXTDLGCTL message is sent to a dialog box procedure to set the keyboard focus to a different control in the dialog box.
        /// </summary>
        static long NEXTDLGCTL = 0x0028;
        /// <summary>
        /// The WM_SPOOLERSTATUS message is sent from Print Manager whenever a job is added to or removed from the Print Manager queue.
        /// </summary>
        static long SPOOLERSTATUS = 0x002A;
        /// <summary>
        /// The WM_DRAWITEM message is sent to the parent window of an owner-drawn button; combo box; list box; or menu when a visual aspect of the button; combo box; list box; or menu has changed.
        /// </summary>
        static long DRAWITEM = 0x002B;
        /// <summary>
        /// The WM_MEASUREITEM message is sent to the owner window of a combo box; list box; list view control; or menu item when the control or menu is created.
        /// </summary>
        static long MEASUREITEM = 0x002C;
        /// <summary>
        /// Sent to the owner of a list box or combo box when the list box or combo box is destroyed or when items are removed by the LB_DELETESTRING; LB_RESETCONTENT; CB_DELETESTRING; or CB_RESETCONTENT message. The system sends a WM_DELETEITEM message for each deleted item. The system sends the WM_DELETEITEM message for any deleted list box or combo box item with nonzero item data.
        /// </summary>
        static long DELETEITEM = 0x002D;
        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_KEYDOWN message.
        /// </summary>
        static long VKEYTOITEM = 0x002E;
        /// <summary>
        /// Sent by a list box with the LBS_WANTKEYBOARDINPUT style to its owner in response to a WM_CHAR message.
        /// </summary>
        static long CHARTOITEM = 0x002F;
        /// <summary>
        /// An application sends a WM_SETFONT message to specify the font that a control is to use when drawing text.
        /// </summary>
        static long SETFONT = 0x0030;
        /// <summary>
        /// An application sends a WM_GETFONT message to a control to retrieve the font with which the control is currently drawing its text.
        /// </summary>
        static long GETFONT = 0x0031;
        /// <summary>
        /// An application sends a WM_SETHOTKEY message to a window to associate a hot key with the window. When the user presses the hot key; the system activates the window.
        /// </summary>
        static long SETHOTKEY = 0x0032;
        /// <summary>
        /// An application sends a WM_GETHOTKEY message to determine the hot key associated with a window.
        /// </summary>
        static long GETHOTKEY = 0x0033;
        /// <summary>
        /// The WM_QUERYDRAGICON message is sent to a minimized (iconic) window. The window is about to be dragged by the user but does not have an icon defined for its class. An application can return a handle to an icon or cursor. The system displays this cursor or icon while the user drags the icon.
        /// </summary>
        static long QUERYDRAGICON = 0x0037;
        /// <summary>
        /// The system sends the WM_COMPAREITEM message to determine the relative position of a new item in the sorted list of an owner-drawn combo box or list box. Whenever the application adds a new item; the system sends this message to the owner of a combo box or list box created with the CBS_SORT or LBS_SORT style.
        /// </summary>
        static long COMPAREITEM = 0x0039;
        /// <summary>
        /// Active Accessibility sends the WM_GETOBJECT message to obtain information about an accessible object contained in a server application.
        /// Applications never send this message directly. It is sent only by Active Accessibility in response to calls to AccessibleObjectFromPoint; AccessibleObjectFromEvent; or AccessibleObjectFromWindow. However; server applications handle this message.
        /// </summary>
        static long GETOBJECT = 0x003D;
        /// <summary>
        /// The WM_COMPACTING message is sent to all top-level windows when the system detects more than 12.5 percent of system time over a 30- to 60-second interval is being spent compacting memory. This indicates that system memory is low.
        /// </summary>
        static long COMPACTING = 0x0041;
        /// <summary>
        /// WM_COMMNOTIFY is Obsolete for Win32-Based Applications
        /// </summary>
        static long COMMNOTIFY = 0x0044;
        /// <summary>
        /// The WM_WINDOWPOSCHANGING message is sent to a window whose size; position; or place in the Z order is about to change as a result of a call to the SetWindowPos function or another window-management function.
        /// </summary>
        static long WINDOWPOSCHANGING = 0x0046;
        /// <summary>
        /// The WM_WINDOWPOSCHANGED message is sent to a window whose size; position; or place in the Z order has changed as a result of a call to the SetWindowPos function or another window-management function.
        /// </summary>
        static long WINDOWPOSCHANGED = 0x0047;
        /// <summary>
        /// Notifies applications that the system; typically a battery-powered personal computer; is about to enter a suspended mode.
        /// Use: POWERBROADCAST
        /// </summary>
        static long POWER = 0x0048;
        /// <summary>
        /// An application sends the WM_COPYDATA message to pass data to another application.
        /// </summary>
        static long COPYDATA = 0x004A;
        /// <summary>
        /// The WM_CANCELJOURNAL message is posted to an application when a user cancels the application's journaling activities. The message is posted with a NULL window handle.
        /// </summary>
        static long CANCELJOURNAL = 0x004B;
        /// <summary>
        /// Sent by a common control to its parent window when an event has occurred or the control requires some information.
        /// </summary>
        static long NOTIFY = 0x004E;
        /// <summary>
        /// The WM_INPUTLANGCHANGEREQUEST message is posted to the window with the focus when the user chooses a new input language; either with the hotkey (specified in the Keyboard control panel application) or from the indicator on the system taskbar. An application can accept the change by passing the message to the DefWindowProc function or reject the change (and prevent it from taking place) by returning immediately.
        /// </summary>
        static long INPUTLANGCHANGEREQUEST = 0x0050;
        /// <summary>
        /// The WM_INPUTLANGCHANGE message is sent to the topmost affected window after an application's input language has been changed. You should make any application-specific settings and pass the message to the DefWindowProc function; which passes the message to all first-level child windows. These child windows can pass the message to DefWindowProc to have it pass the message to their child windows; and so on.
        /// </summary>
        static long INPUTLANGCHANGE = 0x0051;
        /// <summary>
        /// Sent to an application that has initiated a training card with Microsoft Windows Help. The message informs the application when the user clicks an authorable button. An application initiates a training card by specifying the HELP_TCARD command in a call to the WinHelp function.
        /// </summary>
        static long TCARD = 0x0052;
        /// <summary>
        /// Indicates that the user pressed the F1 key. If a menu is active when F1 is pressed; WM_HELP is sent to the window associated with the menu; otherwise; WM_HELP is sent to the window that has the keyboard focus. If no window has the keyboard focus; WM_HELP is sent to the currently active window.
        /// </summary>
        static long HELP = 0x0053;
        /// <summary>
        /// The WM_USERCHANGED message is sent to all windows after the user has logged on or off. When the user logs on or off; the system updates the user-specific settings. The system sends this message immediately after updating the settings.
        /// </summary>
        static long USERCHANGED = 0x0054;
        /// <summary>
        /// Determines if a window accepts ANSI or Unicode structures in the WM_NOTIFY notification message. WM_NOTIFYFORMAT messages are sent from a common control to its parent window and from the parent window to the common control.
        /// </summary>
        static long NOTIFYFORMAT = 0x0055;
        /// <summary>
        /// The WM_CONTEXTMENU message notifies a window that the user clicked the right mouse button (right-clicked) in the window.
        /// </summary>
        static long CONTEXTMENU = 0x007B;
        /// <summary>
        /// The WM_STYLECHANGING message is sent to a window when the SetWindowLong function is about to change one or more of the window's styles.
        /// </summary>
        static long STYLECHANGING = 0x007C;
        /// <summary>
        /// The WM_STYLECHANGED message is sent to a window after the SetWindowLong function has changed one or more of the window's styles
        /// </summary>
        static long STYLECHANGED = 0x007D;
        /// <summary>
        /// The WM_DISPLAYCHANGE message is sent to all windows when the display resolution has changed.
        /// </summary>
        static long DISPLAYCHANGE = 0x007E;
        /// <summary>
        /// The WM_GETICON message is sent to a window to retrieve a handle to the large or small icon associated with a window. The system displays the large icon in the ALT+TAB dialog; and the small icon in the window caption.
        /// </summary>
        static long GETICON = 0x007F;
        /// <summary>
        /// An application sends the WM_SETICON message to associate a new large or small icon with a window. The system displays the large icon in the ALT+TAB dialog box; and the small icon in the window caption.
        /// </summary>
        static long SETICON = 0x0080;
        /// <summary>
        /// The WM_NCCREATE message is sent prior to the WM_CREATE message when a window is first created.
        /// </summary>
        static long NCCREATE = 0x0081;
        /// <summary>
        /// The WM_NCDESTROY message informs a window that its nonclient area is being destroyed. The DestroyWindow function sends the WM_NCDESTROY message to the window following the WM_DESTROY message. WM_DESTROY is used to free the allocated memory object associated with the window.
        /// The WM_NCDESTROY message is sent after the child windows have been destroyed. In contrast; WM_DESTROY is sent before the child windows are destroyed.
        /// </summary>
        static long NCDESTROY = 0x0082;
        /// <summary>
        /// The WM_NCCALCSIZE message is sent when the size and position of a window's client area must be calculated. By processing this message; an application can control the content of the window's client area when the size or position of the window changes.
        /// </summary>
        static long NCCALCSIZE = 0x0083;
        /// <summary>
        /// The WM_NCHITTEST message is sent to a window when the cursor moves; or when a mouse button is pressed or released. If the mouse is not captured; the message is sent to the window beneath the cursor. Otherwise; the message is sent to the window that has captured the mouse.
        /// </summary>
        static long NCHITTEST = 0x0084;
        /// <summary>
        /// The WM_NCPAINT message is sent to a window when its frame must be painted.
        /// </summary>
        static long NCPAINT = 0x0085;
        /// <summary>
        /// The WM_NCACTIVATE message is sent to a window when its nonclient area needs to be changed to indicate an active or inactive state.
        /// </summary>
        static long NCACTIVATE = 0x0086;
        /// <summary>
        /// The WM_GETDLGCODE message is sent to the window procedure associated with a control. By default; the system handles all keyboard input to the control; the system interprets certain types of keyboard input as dialog box navigation keys. To override this default behavior; the control can respond to the WM_GETDLGCODE message to indicate the types of input it wants to process itself.
        /// </summary>
        static long GETDLGCODE = 0x0087;
        /// <summary>
        /// The WM_SYNCPAINT message is used to synchronize painting while avoiding linking independent GUI threads.
        /// </summary>
        static long SYNCPAINT = 0x0088;
        /// <summary>
        /// The WM_NCMOUSEMOVE message is posted to a window when the cursor is moved within the nonclient area of the window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCMOUSEMOVE = 0x00A0;
        /// <summary>
        /// The WM_NCLBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCLBUTTONDOWN = 0x00A1;
        /// <summary>
        /// The WM_NCLBUTTONUP message is posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCLBUTTONUP = 0x00A2;
        /// <summary>
        /// The WM_NCLBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCLBUTTONDBLCLK = 0x00A3;
        /// <summary>
        /// The WM_NCRBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCRBUTTONDOWN = 0x00A4;
        /// <summary>
        /// The WM_NCRBUTTONUP message is posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCRBUTTONUP = 0x00A5;
        /// <summary>
        /// The WM_NCRBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCRBUTTONDBLCLK = 0x00A6;
        /// <summary>
        /// The WM_NCMBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCMBUTTONDOWN = 0x00A7;
        /// <summary>
        /// The WM_NCMBUTTONUP message is posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCMBUTTONUP = 0x00A8;
        /// <summary>
        /// The WM_NCMBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCMBUTTONDBLCLK = 0x00A9;
        /// <summary>
        /// The WM_NCXBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCXBUTTONDOWN = 0x00AB;
        /// <summary>
        /// The WM_NCXBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCXBUTTONUP = 0x00AC;
        /// <summary>
        /// The WM_NCXBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse; this message is not posted.
        /// </summary>
        static long NCXBUTTONDBLCLK = 0x00AD;
        /// <summary>
        /// The WM_INPUT_DEVICE_CHANGE message is sent to the window that registered to receive raw input. A window receives this message through its WindowProc function.
        /// </summary>
        static long INPUT_DEVICE_CHANGE = 0x00FE;
        /// <summary>
        /// The WM_INPUT message is sent to the window that is getting raw input.
        /// </summary>
        static long INPUT = 0x00FF;
        /// <summary>
        /// This message filters for keyboard messages.
        /// </summary>
        static long KEYFIRST = 0x0100;
        /// <summary>
        /// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed.
        /// </summary>
        static long KEYDOWN = 0x0100;
        /// <summary>
        /// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed; or a keyboard key that is pressed when a window has the keyboard focus.
        /// </summary>
        static long KEYUP = 0x0101;
        /// <summary>
        /// The WM_CHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The WM_CHAR message contains the character code of the key that was pressed.
        /// </summary>
        static long CHAR = 0x0102;
        /// <summary>
        /// The WM_DEADCHAR message is posted to the window with the keyboard focus when a WM_KEYUP message is translated by the TranslateMessage function. WM_DEADCHAR specifies a character code generated by a dead key. A dead key is a key that generates a character; such as the umlaut (double-dot); that is combined with another character to form a composite character. For example; the umlaut-O character (Ö) is generated by typing the dead key for the umlaut character; and then typing the O key.
        /// </summary>
        static long DEADCHAR = 0x0103;
        /// <summary>
        /// The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user presses the F10 key (which activates the menu bar) or holds down the ALT key and then presses another key. It also occurs when no window currently has the keyboard focus; in this case; the WM_SYSKEYDOWN message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter.
        /// </summary>
        static long SYSKEYDOWN = 0x0104;
        /// <summary>
        /// The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user releases a key that was pressed while the ALT key was held down. It also occurs when no window currently has the keyboard focus; in this case; the WM_SYSKEYUP message is sent to the active window. The window that receives the message can distinguish between these two contexts by checking the context code in the lParam parameter.
        /// </summary>
        static long SYSKEYUP = 0x0105;
        /// <summary>
        /// The WM_SYSCHAR message is posted to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. It specifies the character code of a system character key — that is; a character key that is pressed while the ALT key is down.
        /// </summary>
        static long SYSCHAR = 0x0106;
        /// <summary>
        /// The WM_SYSDEADCHAR message is sent to the window with the keyboard focus when a WM_SYSKEYDOWN message is translated by the TranslateMessage function. WM_SYSDEADCHAR specifies the character code of a system dead key — that is; a dead key that is pressed while holding down the ALT key.
        /// </summary>
        static long SYSDEADCHAR = 0x0107;
        /// <summary>
        /// The WM_UNICHAR message is posted to the window with the keyboard focus when a WM_KEYDOWN message is translated by the TranslateMessage function. The WM_UNICHAR message contains the character code of the key that was pressed.
        /// The WM_UNICHAR message is equivalent to WM_CHAR; but it uses Unicode Transformation Format (UTF)-32; whereas WM_CHAR uses UTF-16. It is designed to send or post Unicode characters to ANSI windows and it can can handle Unicode Supplementary Plane characters.
        /// </summary>
        static long UNICHAR = 0x0109;
        /// <summary>
        /// This message filters for keyboard messages.
        /// </summary>
        static long KEYLAST = 0x0108;
        /// <summary>
        /// Sent immediately before the IME generates the composition string as a result of a keystroke. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_STARTCOMPOSITION = 0x010D;
        /// <summary>
        /// Sent to an application when the IME ends composition. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_ENDCOMPOSITION = 0x010E;
        /// <summary>
        /// Sent to an application when the IME changes composition status as a result of a keystroke. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_COMPOSITION = 0x010F;
        static long IME_KEYLAST = 0x010F;
        /// <summary>
        /// The WM_INITDIALOG message is sent to the dialog box procedure immediately before a dialog box is displayed. Dialog box procedures typically use this message to initialize controls and carry out any other initialization tasks that affect the appearance of the dialog box.
        /// </summary>
        static long INITDIALOG = 0x0110;
        /// <summary>
        /// The WM_COMMAND message is sent when the user selects a command item from a menu; when a control sends a notification message to its parent window; or when an accelerator keystroke is translated.
        /// </summary>
        static long COMMAND = 0x0111;
        /// <summary>
        /// A window receives this message when the user chooses a command from the Window menu; clicks the maximize button; minimize button; restore button; close button; or moves the form. You can stop the form from moving by filtering this out.
        /// </summary>
        static long SYSCOMMAND = 0x0112;
        /// <summary>
        /// The WM_TIMER message is posted to the installing thread's message queue when a timer expires. The message is posted by the GetMessage or PeekMessage function.
        /// </summary>
        static long TIMER = 0x0113;
        /// <summary>
        /// The WM_HSCROLL message is sent to a window when a scroll event occurs in the window's standard horizontal scroll bar. This message is also sent to the owner of a horizontal scroll bar control when a scroll event occurs in the control.
        /// </summary>
        static long HSCROLL = 0x0114;
        /// <summary>
        /// The WM_VSCROLL message is sent to a window when a scroll event occurs in the window's standard vertical scroll bar. This message is also sent to the owner of a vertical scroll bar control when a scroll event occurs in the control.
        /// </summary>
        static long VSCROLL = 0x0115;
        /// <summary>
        /// The WM_INITMENU message is sent when a menu is about to become active. It occurs when the user clicks an item on the menu bar or presses a menu key. This allows the application to modify the menu before it is displayed.
        /// </summary>
        static long INITMENU = 0x0116;
        /// <summary>
        /// The WM_INITMENUPOPUP message is sent when a drop-down menu or submenu is about to become active. This allows an application to modify the menu before it is displayed; without changing the entire menu.
        /// </summary>
        static long INITMENUPOPUP = 0x0117;
        /// <summary>
        /// The WM_MENUSELECT message is sent to a menu's owner window when the user selects a menu item.
        /// </summary>
        static long MENUSELECT = 0x011F;
        /// <summary>
        /// The WM_MENUCHAR message is sent when a menu is active and the user presses a key that does not correspond to any mnemonic or accelerator key. This message is sent to the window that owns the menu.
        /// </summary>
        static long MENUCHAR = 0x0120;
        /// <summary>
        /// The WM_ENTERIDLE message is sent to the owner window of a modal dialog box or menu that is entering an idle state. A modal dialog box or menu enters an idle state when no messages are waiting in its queue after it has processed one or more previous messages.
        /// </summary>
        static long ENTERIDLE = 0x0121;
        /// <summary>
        /// The WM_MENURBUTTONUP message is sent when the user releases the right mouse button while the cursor is on a menu item.
        /// </summary>
        static long MENURBUTTONUP = 0x0122;
        /// <summary>
        /// The WM_MENUDRAG message is sent to the owner of a drag-and-drop menu when the user drags a menu item.
        /// </summary>
        static long MENUDRAG = 0x0123;
        /// <summary>
        /// The WM_MENUGETOBJECT message is sent to the owner of a drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the item to the top or bottom of the item.
        /// </summary>
        static long MENUGETOBJECT = 0x0124;
        /// <summary>
        /// The WM_UNINITMENUPOPUP message is sent when a drop-down menu or submenu has been destroyed.
        /// </summary>
        static long UNINITMENUPOPUP = 0x0125;
        /// <summary>
        /// The WM_MENUCOMMAND message is sent when the user makes a selection from a menu.
        /// </summary>
        static long MENUCOMMAND = 0x0126;
        /// <summary>
        /// An application sends the WM_CHANGEUISTATE message to indicate that the user interface (UI) state should be changed.
        /// </summary>
        static long CHANGEUISTATE = 0x0127;
        /// <summary>
        /// An application sends the WM_UPDATEUISTATE message to change the user interface (UI) state for the specified window and all its child windows.
        /// </summary>
        static long UPDATEUISTATE = 0x0128;
        /// <summary>
        /// An application sends the WM_QUERYUISTATE message to retrieve the user interface (UI) state for a window.
        /// </summary>
        static long QUERYUISTATE = 0x0129;
        /// <summary>
        /// The WM_CTLCOLORMSGBOX message is sent to the owner window of a message box before Windows draws the message box. By responding to this message; the owner window can set the text and background colors of the message box by using the given display device context handle.
        /// </summary>
        static long CTLCOLORMSGBOX = 0x0132;
        /// <summary>
        /// An edit control that is not read-only or disabled sends the WM_CTLCOLOREDIT message to its parent window when the control is about to be drawn. By responding to this message; the parent window can use the specified device context handle to set the text and background colors of the edit control.
        /// </summary>
        static long CTLCOLOREDIT = 0x0133;
        /// <summary>
        /// Sent to the parent window of a list box before the system draws the list box. By responding to this message; the parent window can set the text and background colors of the list box by using the specified display device context handle.
        /// </summary>
        static long CTLCOLORLISTBOX = 0x0134;
        /// <summary>
        /// The WM_CTLCOLORBTN message is sent to the parent window of a button before drawing the button. The parent window can change the button's text and background colors. However; only owner-drawn buttons respond to the parent window processing this message.
        /// </summary>
        static long CTLCOLORBTN = 0x0135;
        /// <summary>
        /// The WM_CTLCOLORDLG message is sent to a dialog box before the system draws the dialog box. By responding to this message; the dialog box can set its text and background colors using the specified display device context handle.
        /// </summary>
        static long CTLCOLORDLG = 0x0136;
        /// <summary>
        /// The WM_CTLCOLORSCROLLBAR message is sent to the parent window of a scroll bar control when the control is about to be drawn. By responding to this message; the parent window can use the display context handle to set the background color of the scroll bar control.
        /// </summary>
        static long CTLCOLORSCROLLBAR = 0x0137;
        /// <summary>
        /// A static control; or an edit control that is read-only or disabled; sends the WM_CTLCOLORSTATIC message to its parent window when the control is about to be drawn. By responding to this message; the parent window can use the specified device context handle to set the text and background colors of the static control.
        /// </summary>
        static long CTLCOLORSTATIC = 0x0138;
        /// <summary>
        /// Use WM_MOUSEFIRST to specify the first mouse message. Use the PeekMessage() Function.
        /// </summary>
        static long MOUSEFIRST = 0x0200;
        /// <summary>
        /// The WM_MOUSEMOVE message is posted to a window when the cursor moves. If the mouse is not captured; the message is posted to the window that contains the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long MOUSEMOVE = 0x0200;
        /// <summary>
        /// The WM_LBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long LBUTTONDOWN = 0x0201;
        /// <summary>
        /// The WM_LBUTTONUP message is posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long LBUTTONUP = 0x0202;
        /// <summary>
        /// The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long LBUTTONDBLCLK = 0x0203;
        /// <summary>
        /// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long RBUTTONDOWN = 0x0204;
        /// <summary>
        /// The WM_RBUTTONUP message is posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long RBUTTONUP = 0x0205;
        /// <summary>
        /// The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long RBUTTONDBLCLK = 0x0206;
        /// <summary>
        /// The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long MBUTTONDOWN = 0x0207;
        /// <summary>
        /// The WM_MBUTTONUP message is posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long MBUTTONUP = 0x0208;
        /// <summary>
        /// The WM_MBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long MBUTTONDBLCLK = 0x0209;
        /// <summary>
        /// The WM_MOUSEWHEEL message is sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message; since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        static long MOUSEWHEEL = 0x020A;
        /// <summary>
        /// The WM_XBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long XBUTTONDOWN = 0x020B;
        /// <summary>
        /// The WM_XBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long XBUTTONUP = 0x020C;
        /// <summary>
        /// The WM_XBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. If the mouse is not captured; the message is posted to the window beneath the cursor. Otherwise; the message is posted to the window that has captured the mouse.
        /// </summary>
        static long XBUTTONDBLCLK = 0x020D;
        /// <summary>
        /// The WM_MOUSEHWHEEL message is sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message; since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        static long MOUSEHWHEEL = 0x020E;
        /// <summary>
        /// Use WM_MOUSELAST to specify the last mouse message. Used with PeekMessage() Function.
        /// </summary>
        static long MOUSELAST = 0x020E;
        /// <summary>
        /// The WM_PARENTNOTIFY message is sent to the parent of a child window when the child window is created or destroyed; or when the user clicks a mouse button while the cursor is over the child window. When the child window is being created; the system sends WM_PARENTNOTIFY just before the CreateWindow or CreateWindowEx function that creates the window returns. When the child window is being destroyed; the system sends the message before any processing to destroy the window takes place.
        /// </summary>
        static long PARENTNOTIFY = 0x0210;
        /// <summary>
        /// The WM_ENTERMENULOOP message informs an application's main window procedure that a menu modal loop has been entered.
        /// </summary>
        static long ENTERMENULOOP = 0x0211;
        /// <summary>
        /// The WM_EXITMENULOOP message informs an application's main window procedure that a menu modal loop has been exited.
        /// </summary>
        static long EXITMENULOOP = 0x0212;
        /// <summary>
        /// The WM_NEXTMENU message is sent to an application when the right or left arrow key is used to switch between the menu bar and the system menu.
        /// </summary>
        static long NEXTMENU = 0x0213;
        /// <summary>
        /// The WM_SIZING message is sent to a window that the user is resizing. By processing this message; an application can monitor the size and position of the drag rectangle and; if needed; change its size or position.
        /// </summary>
        static long SIZING = 0x0214;
        /// <summary>
        /// The WM_CAPTURECHANGED message is sent to the window that is losing the mouse capture.
        /// </summary>
        static long CAPTURECHANGED = 0x0215;
        /// <summary>
        /// The WM_MOVING message is sent to a window that the user is moving. By processing this message; an application can monitor the position of the drag rectangle and; if needed; change its position.
        /// </summary>
        static long MOVING = 0x0216;
        /// <summary>
        /// Notifies applications that a power-management event has occurred.
        /// </summary>
        static long POWERBROADCAST = 0x0218;
        /// <summary>
        /// Notifies an application of a change to the hardware configuration of a device or the computer.
        /// </summary>
        static long DEVICECHANGE = 0x0219;
        /// <summary>
        /// An application sends the WM_MDICREATE message to a multiple-document interface (MDI) client window to create an MDI child window.
        /// </summary>
        static long MDICREATE = 0x0220;
        /// <summary>
        /// An application sends the WM_MDIDESTROY message to a multiple-document interface (MDI) client window to close an MDI child window.
        /// </summary>
        static long MDIDESTROY = 0x0221;
        /// <summary>
        /// An application sends the WM_MDIACTIVATE message to a multiple-document interface (MDI) client window to instruct the client window to activate a different MDI child window.
        /// </summary>
        static long MDIACTIVATE = 0x0222;
        /// <summary>
        /// An application sends the WM_MDIRESTORE message to a multiple-document interface (MDI) client window to restore an MDI child window from maximized or minimized size.
        /// </summary>
        static long MDIRESTORE = 0x0223;
        /// <summary>
        /// An application sends the WM_MDINEXT message to a multiple-document interface (MDI) client window to activate the next or previous child window.
        /// </summary>
        static long MDINEXT = 0x0224;
        /// <summary>
        /// An application sends the WM_MDIMAXIMIZE message to a multiple-document interface (MDI) client window to maximize an MDI child window. The system resizes the child window to make its client area fill the client window. The system places the child window's window menu icon in the rightmost position of the frame window's menu bar; and places the child window's restore icon in the leftmost position. The system also appends the title bar text of the child window to that of the frame window.
        /// </summary>
        static long MDIMAXIMIZE = 0x0225;
        /// <summary>
        /// An application sends the WM_MDITILE message to a multiple-document interface (MDI) client window to arrange all of its MDI child windows in a tile format.
        /// </summary>
        static long MDITILE = 0x0226;
        /// <summary>
        /// An application sends the WM_MDICASCADE message to a multiple-document interface (MDI) client window to arrange all its child windows in a cascade format.
        /// </summary>
        static long MDICASCADE = 0x0227;
        /// <summary>
        /// An application sends the WM_MDIICONARRANGE message to a multiple-document interface (MDI) client window to arrange all minimized MDI child windows. It does not affect child windows that are not minimized.
        /// </summary>
        static long MDIICONARRANGE = 0x0228;
        /// <summary>
        /// An application sends the WM_MDIGETACTIVE message to a multiple-document interface (MDI) client window to retrieve the handle to the active MDI child window.
        /// </summary>
        static long MDIGETACTIVE = 0x0229;
        /// <summary>
        /// An application sends the WM_MDISETMENU message to a multiple-document interface (MDI) client window to replace the entire menu of an MDI frame window; to replace the window menu of the frame window; or both.
        /// </summary>
        static long MDISETMENU = 0x0230;
        /// <summary>
        /// The WM_ENTERSIZEMOVE message is sent one time to a window after it enters the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border; or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns.
        /// The system sends the WM_ENTERSIZEMOVE message regardless of whether the dragging of full windows is enabled.
        /// </summary>
        static long ENTERSIZEMOVE = 0x0231;
        /// <summary>
        /// The WM_EXITSIZEMOVE message is sent one time to a window; after it has exited the moving or sizing modal loop. The window enters the moving or sizing modal loop when the user clicks the window's title bar or sizing border; or when the window passes the WM_SYSCOMMAND message to the DefWindowProc function and the wParam parameter of the message specifies the SC_MOVE or SC_SIZE value. The operation is complete when DefWindowProc returns.
        /// </summary>
        static long EXITSIZEMOVE = 0x0232;
        /// <summary>
        /// Sent when the user drops a file on the window of an application that has registered itself as a recipient of dropped files.
        /// </summary>
        static long DROPFILES = 0x0233;
        /// <summary>
        /// An application sends the WM_MDIREFRESHMENU message to a multiple-document interface (MDI) client window to refresh the window menu of the MDI frame window.
        /// </summary>
        static long MDIREFRESHMENU = 0x0234;
        /// <summary>
        /// Sent to an application when a window is activated. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_SETCONTEXT = 0x0281;
        /// <summary>
        /// Sent to an application to notify it of changes to the IME window. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_NOTIFY = 0x0282;
        /// <summary>
        /// Sent by an application to direct the IME window to carry out the requested command. The application uses this message to control the IME window that it has created. To send this message; the application calls the SendMessage function with the following parameters.
        /// </summary>
        static long IME_CONTROL = 0x0283;
        /// <summary>
        /// Sent to an application when the IME window finds no space to extend the area for the composition window. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_COMPOSITIONFULL = 0x0284;
        /// <summary>
        /// Sent to an application when the operating system is about to change the current IME. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_SELECT = 0x0285;
        /// <summary>
        /// Sent to an application when the IME gets a character of the conversion result. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_CHAR = 0x0286;
        /// <summary>
        /// Sent to an application to provide commands and request information. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_REQUEST = 0x0288;
        /// <summary>
        /// Sent to an application by the IME to notify the application of a key press and to keep message order. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_KEYDOWN = 0x0290;
        /// <summary>
        /// Sent to an application by the IME to notify the application of a key release and to keep message order. A window receives this message through its WindowProc function.
        /// </summary>
        static long IME_KEYUP = 0x0291;
        /// <summary>
        /// The WM_MOUSEHOVER message is posted to a window when the cursor hovers over the client area of the window for the period of time specified in a prior call to TrackMouseEvent.
        /// </summary>
        static long MOUSEHOVER = 0x02A1;
        /// <summary>
        /// The WM_MOUSELEAVE message is posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
        /// </summary>
        static long MOUSELEAVE = 0x02A3;
        /// <summary>
        /// The WM_NCMOUSEHOVER message is posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in a prior call to TrackMouseEvent.
        /// </summary>
        static long NCMOUSEHOVER = 0x02A0;
        /// <summary>
        /// The WM_NCMOUSELEAVE message is posted to a window when the cursor leaves the nonclient area of the window specified in a prior call to TrackMouseEvent.
        /// </summary>
        static long NCMOUSELEAVE = 0x02A2;
        /// <summary>
        /// The WM_WTSSESSION_CHANGE message notifies applications of changes in session state.
        /// </summary>
        static long WTSSESSION_CHANGE = 0x02B1;
        static long TABLET_FIRST = 0x02c0;
        static long TABLET_LAST = 0x02df;
        /// <summary>
        /// An application sends a WM_CUT message to an edit control or combo box to delete (cut) the current selection; if any; in the edit control and copy the deleted text to the clipboard in CF_TEXT format.
        /// </summary>
        static long CUT = 0x0300;
        /// <summary>
        /// An application sends the WM_COPY message to an edit control or combo box to copy the current selection to the clipboard in CF_TEXT format.
        /// </summary>
        static long COPY = 0x0301;
        /// <summary>
        /// An application sends a WM_PASTE message to an edit control or combo box to copy the current content of the clipboard to the edit control at the current caret position. Data is inserted only if the clipboard contains data in CF_TEXT format.
        /// </summary>
        static long PASTE = 0x0302;
        /// <summary>
        /// An application sends a WM_CLEAR message to an edit control or combo box to delete (clear) the current selection; if any; from the edit control.
        /// </summary>
        static long CLEAR = 0x0303;
        /// <summary>
        /// An application sends a WM_UNDO message to an edit control to undo the last operation. When this message is sent to an edit control; the previously deleted text is restored or the previously added text is deleted.
        /// </summary>
        static long UNDO = 0x0304;
        /// <summary>
        /// The WM_RENDERFORMAT message is sent to the clipboard owner if it has delayed rendering a specific clipboard format and if an application has requested data in that format. The clipboard owner must render data in the specified format and place it on the clipboard by calling the SetClipboardData function.
        /// </summary>
        static long RENDERFORMAT = 0x0305;
        /// <summary>
        /// The WM_RENDERALLFORMATS message is sent to the clipboard owner before it is destroyed; if the clipboard owner has delayed rendering one or more clipboard formats. For the content of the clipboard to remain available to other applications; the clipboard owner must render data in all the formats it is capable of generating; and place the data on the clipboard by calling the SetClipboardData function.
        /// </summary>
        static long RENDERALLFORMATS = 0x0306;
        /// <summary>
        /// The WM_DESTROYCLIPBOARD message is sent to the clipboard owner when a call to the EmptyClipboard function empties the clipboard.
        /// </summary>
        static long DESTROYCLIPBOARD = 0x0307;
        /// <summary>
        /// The WM_DRAWCLIPBOARD message is sent to the first window in the clipboard viewer chain when the content of the clipboard changes. This enables a clipboard viewer window to display the new content of the clipboard.
        /// </summary>
        static long DRAWCLIPBOARD = 0x0308;
        /// <summary>
        /// The WM_PAINTCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and the clipboard viewer's client area needs repainting.
        /// </summary>
        static long PAINTCLIPBOARD = 0x0309;
        /// <summary>
        /// The WM_VSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's vertical scroll bar. The owner should scroll the clipboard image and update the scroll bar values.
        /// </summary>
        static long VSCROLLCLIPBOARD = 0x030A;
        /// <summary>
        /// The WM_SIZECLIPBOARD message is sent to the clipboard owner by a clipboard viewer window when the clipboard contains data in the CF_OWNERDISPLAY format and the clipboard viewer's client area has changed size.
        /// </summary>
        static long SIZECLIPBOARD = 0x030B;
        /// <summary>
        /// The WM_ASKCBFORMATNAME message is sent to the clipboard owner by a clipboard viewer window to request the name of a CF_OWNERDISPLAY clipboard format.
        /// </summary>
        static long ASKCBFORMATNAME = 0x030C;
        /// <summary>
        /// The WM_CHANGECBCHAIN message is sent to the first window in the clipboard viewer chain when a window is being removed from the chain.
        /// </summary>
        static long CHANGECBCHAIN = 0x030D;
        /// <summary>
        /// The WM_HSCROLLCLIPBOARD message is sent to the clipboard owner by a clipboard viewer window. This occurs when the clipboard contains data in the CF_OWNERDISPLAY format and an event occurs in the clipboard viewer's horizontal scroll bar. The owner should scroll the clipboard image and update the scroll bar values.
        /// </summary>
        static long HSCROLLCLIPBOARD = 0x030E;
        /// <summary>
        /// This message informs a window that it is about to receive the keyboard focus; giving the window the opportunity to realize its logical palette when it receives the focus.
        /// </summary>
        static long QUERYNEWPALETTE = 0x030F;
        /// <summary>
        /// The WM_PALETTEISCHANGING message informs applications that an application is going to realize its logical palette.
        /// </summary>
        static long PALETTEISCHANGING = 0x0310;
        /// <summary>
        /// This message is sent by the OS to all top-level and overlapped windows after the window with the keyboard focus realizes its logical palette.
        /// This message enables windows that do not have the keyboard focus to realize their logical palettes and update their client areas.
        /// </summary>
        static long PALETTECHANGED = 0x0311;
        /// <summary>
        /// The WM_HOTKEY message is posted when the user presses a hot key registered by the RegisterHotKey function. The message is placed at the top of the message queue associated with the thread that registered the hot key.
        /// </summary>
        static long HOTKEY = 0x0312;
        /// <summary>
        /// The WM_PRINT message is sent to a window to request that it draw itself in the specified device context; most commonly in a printer device context.
        /// </summary>
        static long PRINT = 0x0317;
        /// <summary>
        /// The WM_PRINTCLIENT message is sent to a window to request that it draw its client area in the specified device context; most commonly in a printer device context.
        /// </summary>
        static long PRINTCLIENT = 0x0318;
        /// <summary>
        /// The WM_APPCOMMAND message notifies a window that the user generated an application command event; for example; by clicking an application command button using the mouse or typing an application command key on the keyboard.
        /// </summary>
        static long APPCOMMAND = 0x0319;
        /// <summary>
        /// The WM_THEMECHANGED message is broadcast to every window following a theme change event. Examples of theme change events are the activation of a theme; the deactivation of a theme; or a transition from one theme to another.
        /// </summary>
        static long THEMECHANGED = 0x031A;
        /// <summary>
        /// Sent when the contents of the clipboard have changed.
        /// </summary>
        static long CLIPBOARDUPDATE = 0x031D;
        /// <summary>
        /// The system will send a window the WM_DWMCOMPOSITIONCHANGED message to indicate that the availability of desktop composition has changed.
        /// </summary>
        static long DWMCOMPOSITIONCHANGED = 0x031E;
        /// <summary>
        /// WM_DWMNCRENDERINGCHANGED is called when the non-client area rendering status of a window has changed. Only windows that have set the flag DWM_BLURBEHIND.fTransitionOnMaximized to true will get this message.
        /// </summary>
        static long DWMNCRENDERINGCHANGED = 0x031F;
        /// <summary>
        /// Sent to all top-level windows when the colorization color has changed.
        /// </summary>
        static long DWMCOLORIZATIONCOLORCHANGED = 0x0320;
        /// <summary>
        /// WM_DWMWINDOWMAXIMIZEDCHANGE will let you know when a DWM composed window is maximized. You also have to register for this message as well. You'd have other windowd go opaque when this message is sent.
        /// </summary>
        static long DWMWINDOWMAXIMIZEDCHANGE = 0x0321;
        /// <summary>
        /// Sent to request extended title bar information. A window receives this message through its WindowProc function.
        /// </summary>
        static long GETTITLEBARINFOEX = 0x033F;
        static long HANDHELDFIRST = 0x0358;
        static long HANDHELDLAST = 0x035F;
        static long AFXFIRST = 0x0360;
        static long AFXLAST = 0x037F;
        static long PENWINFIRST = 0x0380;
        static long PENWINLAST = 0x038F;
        /// <summary>
        /// The WM_APP constant is used by applications to help define private messages; usually of the form WM_APP+X; where X is an integer value.
        /// </summary>
        static long APP = 0x8000;
        /// <summary>
        /// The WM_USER constant is used by applications to help define private messages for use by private window classes; usually of the form WM_USER+X; where X is an integer value.
        /// </summary>
        static long USER = 0x0400;
        /// <summary>
        /// An application sends the WM_CPL_LAUNCH message to Windows Control Panel to request that a Control Panel application be started.
        /// </summary>
        static long CPL_LAUNCH = 0x0400 + 0x1000;
        /// <summary>
        /// The WM_CPL_LAUNCHED message is sent when a Control Panel application; started by the WM_CPL_LAUNCH message; has closed. The WM_CPL_LAUNCHED message is sent to the window identified by the wParam parameter of the WM_CPL_LAUNCH message that started the application.
        /// </summary>
        static long CPL_LAUNCHED = 0x0400 + 0x1001;
        /// <summary>
        /// WM_SYSTIMER is a well-known yet still undocumented message. Windows uses WM_SYSTIMER for internal actions like scrolling.
        /// </summary>
        static long SYSTIMER = 0x118;
        /// <summary>
        /// The accessibility state has changed.
        /// </summary>
        static long HSHELL_ACCESSIBILITYSTATE = 11;
        /// <summary>
        /// The shell should activate its main window.
        /// </summary>
        static long HSHELL_ACTIVATESHELLWINDOW = 3;
        /// <summary>
        /// The user completed an input event (for example; pressed an application command button on the mouse or an application command key on the keyboard); and the application did not handle the WM_APPCOMMAND message generated by that input.
        /// If the Shell procedure handles the WM_COMMAND message; it should not call CallNextHookEx. See the Return Value section for more information.
        /// </summary>
        static long HSHELL_APPCOMMAND = 12;
        /// <summary>
        /// A window is being minimized or maximized. The system needs the coordinates of the minimized rectangle for the window.
        /// </summary>
        static long HSHELL_GETMINRECT = 5;
        /// <summary>
        /// Keyboard language was changed or a new keyboard layout was loaded.
        /// </summary>
        static long HSHELL_LANGUAGE = 8;
        /// <summary>
        /// The title of a window in the task bar has been redrawn.
        /// </summary>
        static long HSHELL_REDRAW = 6;
        /// <summary>
        /// The user has selected the task list. A shell application that provides a task list should return TRUE to prevent Windows from starting its task list.
        /// </summary>
        static long HSHELL_TASKMAN = 7;
        /// <summary>
        /// A top-level; unowned window has been created. The window exists when the system calls this hook.
        /// </summary>
        static long HSHELL_WINDOWCREATED = 1;
        /// <summary>
        /// A top-level; unowned window is about to be destroyed. The window still exists when the system calls this hook.
        /// </summary>
        static long HSHELL_WINDOWDESTROYED = 2;
        /// <summary>
        /// The activation has changed to a different top-level; unowned window.
        /// </summary>
        static long HSHELL_WINDOWACTIVATED = 4;
        /// <summary>
        /// A top-level window is being replaced. The window exists when the system calls this hook.
        /// </summary>
        static long HSHELL_WINDOWREPLACED = 13;

        // Combobox
        static long CB_GETEDITSEL = 0x0140,
        CB_LIMITTEXT = 0x0141,
        CB_SETEDITSEL = 0x0142,
        CB_ADDSTRING = 0x0143,
        CB_DELETESTRING = 0x0144,
        CB_GETCURSEL = 0x0147,
        CB_GETLBTEXT = 0x0148,
        CB_GETLBTEXTLEN = 0x0149,
        CB_INSERTSTRING = 0x014A,
        CB_RESETCONTENT = 0x014B,
        CB_FINDSTRING = 0x014C,
        CB_SETCURSEL = 0x014E,
        CB_SHOWDROPDOWN = 0x014F,
        CB_GETITEMDATA = 0x0150,
        CB_SETITEMHEIGHT = 0x0153,
        CB_GETITEMHEIGHT = 0x0154,
        CB_GETDROPPEDSTATE = 0x0157,
        CB_FINDSTRINGEXACT = 0x0158,
        CB_GETDROPPEDWIDTH = 0x015F,
        CB_SETDROPPEDWIDTH = 0x0160;

        // Date/Time picker
        static long DTM_FIRST = 0x1000;
        static long DTM_GETSYSTEMTIME = (DTM_FIRST + 1);
        static long DTM_SETSYSTEMTIME = (DTM_FIRST + 2);
        static long DTM_GETRANGE = (DTM_FIRST + 3);
        static long DTM_SETRANGE = (DTM_FIRST + 4);
        static long DTM_SETFORMATA = (DTM_FIRST + 5);
        static long DTM_SETMCCOLOR = (DTM_FIRST + 6);
        static long DTM_GETMCCOLOR = (DTM_FIRST + 7);
        static long DTM_GETMONTHCAL = (DTM_FIRST + 8);
        static long DTM_SETMCFONT = (DTM_FIRST + 9);
        static long DTM_GETMCFONT = (DTM_FIRST + 10);
        static long DTM_SETMCSTYLE = (DTM_FIRST + 11);
        static long DTM_GETMCSTYLE = (DTM_FIRST + 12);
        static long DTM_CLOSEMONTHCAL = (DTM_FIRST + 13);
        static long DTM_GETDATETIMEPICKERINFO = (DTM_FIRST + 14);
        static long DTM_GETIDEALSIZE = (DTM_FIRST + 15);
        static long DTM_SETFORMATW = (DTM_FIRST + 50);

        // SysHeader
        static long HDM_FIRST = 0x1200;
        static long HDM_GETITEMCOUNT = HDM_FIRST + 0;
        static long HDM_INSERTITEMA = HDM_FIRST + 1;
        static long HDM_DELETEITEM = HDM_FIRST + 2;
        static long HDM_GETITEMA = HDM_FIRST + 3;
        static long HDM_SETITEMA = HDM_FIRST + 4;
        static long HDM_LAYOUT = HDM_FIRST + 5;
        static long HDM_HITTEST = HDM_FIRST + 6;
        static long HDM_GETITEMRECT = HDM_FIRST + 7;
        static long HDM_SETIMAGELIST = HDM_FIRST + 8;
        static long HDM_GETIMAGELIST = HDM_FIRST + 9;
        static long HDM_INSERTITEMW = HDM_FIRST + 10;
        static long HDM_GETITEMW = HDM_FIRST + 11;
        static long HDM_SETITEMW = HDM_FIRST + 12;
        static long HDM_ORDERTOINDEX = HDM_FIRST + 15;
        static long HDM_CREATEDRAGIMAGE = HDM_FIRST + 16;
        static long HDM_GETORDERARRAY = HDM_FIRST + 17;
        static long HDM_SETORDERARRAY = HDM_FIRST + 18;
        static long HDM_SETHOTDIVIDER = HDM_FIRST + 19;
        static long HDM_SETBITMAPMARGIN = HDM_FIRST + 20;
        static long HDM_GETBITMAPMARGIN = HDM_FIRST + 21;
        static long HDM_SETFILTERCHANGETIMEOUT = HDM_FIRST + 22;
        static long HDM_EDITFILTER = HDM_FIRST + 23;
        static long HDM_CLEARFILTER = HDM_FIRST + 24;
        static long HDM_GETITEMDROPDOWNRECT = HDM_FIRST + 25;
        static long HDM_GETOVERFLOWRECT = HDM_FIRST + 26;
        static long HDM_GETFOCUSEDITEM = HDM_FIRST + 27;
        static long HDM_SETFOCUSEDITEM = HDM_FIRST + 28;
        static long HDM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long HDM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        //static long HDM_TRANSLATEACCELERATOR = CCM_TRANSLATEACCELERATOR;

        // List-view messages
        static long LVM_FIRST = 0x1000;
        static long LVM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long LVM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long LVM_GETBKCOLOR = (LVM_FIRST + 0);
        static long LVM_SETBKCOLOR = (LVM_FIRST + 1);
        static long LVM_GETIMAGELIST = (LVM_FIRST + 2);
        static long LVM_SETIMAGELIST = (LVM_FIRST + 3);
        static long LVM_GETITEMCOUNT = (LVM_FIRST + 4);
        static long LVM_GETITEMA = (LVM_FIRST + 5);
        static long LVM_SETITEMA = (LVM_FIRST + 6);
        static long LVM_INSERTITEMA = (LVM_FIRST + 7);
        static long LVM_DELETEITEM = (LVM_FIRST + 8);
        static long LVM_DELETEALLITEMS = (LVM_FIRST + 9);
        static long LVM_GETCALLBACKMASK = (LVM_FIRST + 10);
        static long LVM_SETCALLBACKMASK = (LVM_FIRST + 11);
        static long LVM_GETNEXTITEM = (LVM_FIRST + 12);
        static long LVM_FINDITEMA = (LVM_FIRST + 13);
        static long LVM_GETITEMRECT = (LVM_FIRST + 14);
        static long LVM_SETITEMPOSITION = (LVM_FIRST + 15);
        static long LVM_GETITEMPOSITION = (LVM_FIRST + 16);
        static long LVM_GETSTRINGWIDTHA = (LVM_FIRST + 17);
        static long LVM_HITTEST = (LVM_FIRST + 18);
        static long LVM_ENSUREVISIBLE = (LVM_FIRST + 19);
        static long LVM_SCROLL = (LVM_FIRST + 20);
        static long LVM_REDRAWITEMS = (LVM_FIRST + 21);
        static long LVM_ARRANGE = (LVM_FIRST + 22);
        static long LVM_EDITLABELA = (LVM_FIRST + 23);
        static long LVM_GETEDITCONTROL = (LVM_FIRST + 24);
        static long LVM_GETCOLUMNA = (LVM_FIRST + 25);
        static long LVM_SETCOLUMNA = (LVM_FIRST + 26);
        static long LVM_INSERTCOLUMNA = (LVM_FIRST + 27);
        static long LVM_DELETECOLUMN = (LVM_FIRST + 28);
        static long LVM_GETCOLUMNWIDTH = (LVM_FIRST + 29);
        static long LVM_SETCOLUMNWIDTH = (LVM_FIRST + 30);
        static long LVM_GETHEADER = (LVM_FIRST + 31);
        static long LVM_CREATEDRAGIMAGE = (LVM_FIRST + 33);
        static long LVM_GETVIEWRECT = (LVM_FIRST + 34);
        static long LVM_GETTEXTCOLOR = (LVM_FIRST + 35);
        static long LVM_SETTEXTCOLOR = (LVM_FIRST + 36);
        static long LVM_GETTEXTBKCOLOR = (LVM_FIRST + 37);
        static long LVM_SETTEXTBKCOLOR = (LVM_FIRST + 38);
        static long LVM_GETTOPINDEX = (LVM_FIRST + 39);
        static long LVM_GETCOUNTPERPAGE = (LVM_FIRST + 40);
        static long LVM_GETORIGIN = (LVM_FIRST + 41);
        static long LVM_UPDATE = (LVM_FIRST + 42);
        static long LVM_SETITEMSTATE = (LVM_FIRST + 43);
        static long LVM_GETITEMSTATE = (LVM_FIRST + 44);
        static long LVM_GETITEMTEXTA = (LVM_FIRST + 45);
        static long LVM_SETITEMTEXTA = (LVM_FIRST + 46);
        static long LVM_SETITEMCOUNT = (LVM_FIRST + 47);
        static long LVM_SORTITEMS = (LVM_FIRST + 48);
        static long LVM_SETITEMPOSITION32 = (LVM_FIRST + 49);
        static long LVM_GETSELECTEDCOUNT = (LVM_FIRST + 50);
        static long LVM_GETITEMSPACING = (LVM_FIRST + 51);
        static long LVM_GETISEARCHSTRINGA = (LVM_FIRST + 52);
        static long LVM_SETICONSPACING = (LVM_FIRST + 53);
        static long LVM_GETEXTENDEDLISTVIEWSTYLE = LVM_FIRST + 55;
        static long LVM_GETSUBITEMRECT = (LVM_FIRST + 56);
        static long LVM_SUBITEMHITTEST = (LVM_FIRST + 57);
        static long LVM_SETCOLUMNORDERARRAY = (LVM_FIRST + 58);
        static long LVM_GETCOLUMNORDERARRAY = (LVM_FIRST + 59);
        static long LVM_SETHOTITEM = (LVM_FIRST + 60);
        static long LVM_GETHOTITEM = (LVM_FIRST + 61);
        static long LVM_SETHOTCURSOR = (LVM_FIRST + 62);
        static long LVM_GETHOTCURSOR = (LVM_FIRST + 63);
        static long LVM_APPROXIMATEVIEWRECT = (LVM_FIRST + 64);
        static long LVM_SETWORKAREAS = (LVM_FIRST + 65);
        static long LVM_GETSELECTIONMARK = (LVM_FIRST + 66);
        static long LVM_SETSELECTIONMARK = (LVM_FIRST + 67);
        static long LVM_SETBKIMAGEA = (LVM_FIRST + 68);
        static long LVM_GETBKIMAGEA = (LVM_FIRST + 69);
        static long LVM_GETWORKAREAS = (LVM_FIRST + 70);
        static long LVM_SETHOVERTIME = (LVM_FIRST + 71);
        static long LVM_GETHOVERTIME = (LVM_FIRST + 72);
        static long LVM_GETNUMBEROFWORKAREAS = (LVM_FIRST + 73);
        static long LVM_SETTOOLTIPS = (LVM_FIRST + 74);
        static long LVM_GETITEMW = (LVM_FIRST + 75);
        static long LVM_SETITEMW = (LVM_FIRST + 76);
        static long LVM_INSERTITEMW = (LVM_FIRST + 77);
        static long LVM_GETTOOLTIPS = (LVM_FIRST + 78);
        static long LVM_SORTITEMSEX = (LVM_FIRST + 81);
        static long LVM_FINDITEMW = (LVM_FIRST + 83);
        static long LVM_GETSTRINGWIDTHW = (LVM_FIRST + 87);
        static long LVM_GETGROUPSTATE = (LVM_FIRST + 92);
        static long LVM_GETFOCUSEDGROUP = (LVM_FIRST + 93);
        static long LVM_GETCOLUMNW = (LVM_FIRST + 95);
        static long LVM_SETCOLUMNW = (LVM_FIRST + 96);
        static long LVM_INSERTCOLUMNW = (LVM_FIRST + 97);
        static long LVM_GETGROUPRECT = (LVM_FIRST + 98);
        static long LVM_GETITEMTEXTW = (LVM_FIRST + 115);
        static long LVM_SETITEMTEXTW = (LVM_FIRST + 116);
        static long LVM_GETISEARCHSTRINGW = (LVM_FIRST + 117);
        static long LVM_EDITLABELW = (LVM_FIRST + 118);
        static long LVM_SETBKIMAGEW = (LVM_FIRST + 138);
        static long LVM_GETBKIMAGEW = (LVM_FIRST + 139);
        static long LVM_SETSELECTEDCOLUMN = (LVM_FIRST + 140);
        static long LVM_SETVIEW = (LVM_FIRST + 142);
        static long LVM_GETVIEW = (LVM_FIRST + 143);
        static long LVM_INSERTGROUP = (LVM_FIRST + 145);
        static long LVM_SETGROUPINFO = (LVM_FIRST + 147);
        static long LVM_GETGROUPINFO = (LVM_FIRST + 149);
        static long LVM_REMOVEGROUP = (LVM_FIRST + 150);
        static long LVM_MOVEGROUP = (LVM_FIRST + 151);
        static long LVM_GETGROUPCOUNT = (LVM_FIRST + 152);
        static long LVM_GETGROUPINFOBYINDEX = (LVM_FIRST + 153);
        static long LVM_MOVEITEMTOGROUP = (LVM_FIRST + 154);
        static long LVM_SETGROUPMETRICS = (LVM_FIRST + 155);
        static long LVM_GETGROUPMETRICS = (LVM_FIRST + 156);
        static long LVM_ENABLEGROUPVIEW = (LVM_FIRST + 157);
        static long LVM_SORTGROUPS = (LVM_FIRST + 158);
        static long LVM_INSERTGROUPSORTED = (LVM_FIRST + 159);
        static long LVM_REMOVEALLGROUPS = (LVM_FIRST + 160);
        static long LVM_HASGROUP = (LVM_FIRST + 161);
        static long LVM_SETTILEVIEWINFO = (LVM_FIRST + 162);
        static long LVM_GETTILEVIEWINFO = (LVM_FIRST + 163);
        static long LVM_SETTILEINFO = (LVM_FIRST + 164);
        static long LVM_GETTILEINFO = (LVM_FIRST + 165);
        static long LVM_SETINSERTMARK = (LVM_FIRST + 166);
        static long LVM_GETINSERTMARK = (LVM_FIRST + 167);
        static long LVM_INSERTMARKHITTEST = (LVM_FIRST + 168);
        static long LVM_GETINSERTMARKRECT = (LVM_FIRST + 169);
        static long LVM_SETINSERTMARKCOLOR = (LVM_FIRST + 170);
        static long LVM_GETINSERTMARKCOLOR = (LVM_FIRST + 171);
        static long LVM_SETINFOTIP = (LVM_FIRST + 173);
        static long LVM_GETSELECTEDCOLUMN = (LVM_FIRST + 174);
        static long LVM_ISGROUPVIEWENABLED = (LVM_FIRST + 175);
        static long LVM_GETOUTLINECOLOR = (LVM_FIRST + 176);
        static long LVM_SETOUTLINECOLOR = (LVM_FIRST + 177);
        static long LVM_CANCELEDITLABEL = (LVM_FIRST + 179);
        static long LVM_MAPINDEXTOID = (LVM_FIRST + 180);
        static long LVM_MAPIDTOINDEX = (LVM_FIRST + 181);
        static long LVM_ISITEMVISIBLE = (LVM_FIRST + 182);
        static long LVM_GETFOCUSEDCOLUMN = LVM_FIRST + 186;
        static long LVM_GETEMPTYTEXT = (LVM_FIRST + 204);
        static long LVM_GETFOOTERRECT = (LVM_FIRST + 205);
        static long LVM_GETFOOTERINFO = (LVM_FIRST + 206);
        static long LVM_GETFOOTERITEMRECT = (LVM_FIRST + 207);
        static long LVM_GETFOOTERITEM = (LVM_FIRST + 208);
        static long LVM_GETITEMINDEXRECT = (LVM_FIRST + 209);
        static long LVM_SETITEMINDEXSTATE = (LVM_FIRST + 210);
        static long LVM_GETNEXTITEMINDEX = (LVM_FIRST + 211);

        // calendar control specific constants taken from commctrl.h
        // commctrl MONTHCAL CONTROL win messages
        static long MCM_FIRST = 0x1000;
        static long MCM_GETCURSEL = (MCM_FIRST + 1);
        static long MCM_SETCURSEL = (MCM_FIRST + 2);
        static long MCM_GETMAXSELCOUNT = (MCM_FIRST + 3);
        static long MCM_SETMAXSELCOUNT = (MCM_FIRST + 4);
        static long MCM_GETSELRANGE = (MCM_FIRST + 5);
        static long MCM_SETSELRANGE = (MCM_FIRST + 6);
        static long MCM_GETMONTHRANGE = (MCM_FIRST + 7);
        static long MCM_SETDAYSTATE = (MCM_FIRST + 8);
        static long MCM_GETMINREQRECT = (MCM_FIRST + 9);
        static long MCM_SETCOLOR = (MCM_FIRST + 10);
        static long MCM_GETCOLOR = (MCM_FIRST + 11);
        static long MCM_SETTODAY = (MCM_FIRST + 12);
        static long MCM_GETTODAY = (MCM_FIRST + 13);
        static long MCM_HITTEST = (MCM_FIRST + 14);
        static long MCM_SETFIRSTDAYOFWEEK = (MCM_FIRST + 15);
        static long MCM_GETFIRSTDAYOFWEEK = (MCM_FIRST + 16);
        static long MCM_GETRANGE = (MCM_FIRST + 17);
        static long MCM_SETRANGE = (MCM_FIRST + 18);
        static long MCM_GETMONTHDELTA = (MCM_FIRST + 19);
        static long MCM_SETMONTHDELTA = (MCM_FIRST + 20);
        static long MCM_GETMAXTODAYWIDTH = (MCM_FIRST + 21);
        static long MCM_GETCURRENTVIEW = (MCM_FIRST + 22);
        static long MCM_GETCALENDARCOUNT = (MCM_FIRST + 23);
        static long MCM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long MCM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long MCM_GETCALENDARGRIDINFO = (MCM_FIRST + 24);
        static long MCM_GETCALID = (MCM_FIRST + 27);
        static long MCM_SETCALID = (MCM_FIRST + 28);
        static long MCM_SIZERECTTOMIN = (MCM_FIRST + 29);
        static long MCM_SETCALENDARBORDER = (MCM_FIRST + 30);
        static long MCM_GETCALENDARBORDER = (MCM_FIRST + 31);
        static long MCM_SETCURRENTVIEW = (MCM_FIRST + 32);

        // PAGER CONTROL from commctrl.h 
        static long PGM_FIRST = 0x1400;
        static long PGM_SETCHILD = (PGM_FIRST + 1);
        static long PGM_RECALCSIZE = (PGM_FIRST + 2);
        static long PGM_FORWARDMOUSE = (PGM_FIRST + 3);
        static long PGM_SETBKCOLOR = (PGM_FIRST + 4);
        static long PGM_GETBKCOLOR = (PGM_FIRST + 5);
        static long PGM_SETBORDER = (PGM_FIRST + 6);
        static long PGM_GETBORDER = (PGM_FIRST + 7);
        static long PGM_SETPOS = (PGM_FIRST + 8);
        static long PGM_GETPOS = (PGM_FIRST + 9);
        static long PGM_SETBUTTONSIZE = (PGM_FIRST + 10);
        static long PGM_GETBUTTONSIZE = (PGM_FIRST + 11);
        static long PGM_GETBUTTONSTATE = (PGM_FIRST + 12);
        static long PGM_SETSCROLLINFO = (PGM_FIRST + 13);
        static long PGM_GETDROPTARGET = CCM_GETDROPTARGET;

        // SysTabControl32
        static long TCM_FIRST = 0x1300;
        static long TCM_GETIMAGELIST = (TCM_FIRST + 2);
        static long TCM_SETIMAGELIST = (TCM_FIRST + 3);
        static long TCM_GETITEMCOUNT = TCM_FIRST + 4;
        static long TCM_GETITEMA = (TCM_FIRST + 5);
        static long TCM_SETITEMA = (TCM_FIRST + 6);
        static long TCM_INSERTITEMA = (TCM_FIRST + 7);
        static long TCM_DELETEITEM = (TCM_FIRST + 8);
        static long TCM_DELETEALLITEMS = (TCM_FIRST + 9);
        static long TCM_GETITEMRECT = TCM_FIRST + 10;
        static long TCM_GETCURSEL = TCM_FIRST + 11;
        static long TCM_SETCURSEL = TCM_FIRST + 12;
        static long TCM_HITTEST = TCM_FIRST + 13;
        static long TCM_SETITEMEXTRA = (TCM_FIRST + 14);
        static long TCM_ADJUSTRECT = (TCM_FIRST + 40);
        static long TCM_SETITEMSIZE = (TCM_FIRST + 41);
        static long TCM_REMOVEIMAGE = (TCM_FIRST + 42);
        static long TCM_SETPADDING = (TCM_FIRST + 43);
        static long TCM_GETROWCOUNT = (TCM_FIRST + 44);
        static long TCM_GETTOOLTIPS = TCM_FIRST + 45;
        static long TCM_SETTOOLTIPS = (TCM_FIRST + 46);
        static long TCM_GETCURFOCUS = TCM_FIRST + 47;
        static long TCM_SETCURFOCUS = TCM_FIRST + 48;
        static long TCM_SETMINTABWIDTH = (TCM_FIRST + 49);
        static long TCM_DESELECTALL = TCM_FIRST + 50;
        static long TCM_HIGHLIGHTITEM = (TCM_FIRST + 51);
        static long TCM_SETEXTENDEDSTYLE = (TCM_FIRST + 52);
        static long TCM_GETEXTENDEDSTYLE = (TCM_FIRST + 53);
        static long TCM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long TCM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long TCM_GETITEMW = TCM_FIRST + 60;
        static long TCM_SETITEMW = (TCM_FIRST + 61);
        static long TCM_INSERTITEMW = (TCM_FIRST + 62);


        // TreeView 
        static long TVM_INSERTITEMA = (TV_FIRST + 0);
        static long TVM_DELETEITEM = (TV_FIRST + 1);
        static long TVM_EXPAND = (TV_FIRST + 2);
        static long TVM_GETITEMRECT = (TV_FIRST + 4);
        static long TVM_GETCOUNT = (TV_FIRST + 5);
        static long TVM_GETINDENT = (TV_FIRST + 6);
        static long TVM_SETINDENT = (TV_FIRST + 7);
        static long TVM_GETIMAGELIST = (TV_FIRST + 8);
        static long TVM_SETIMAGELIST = (TV_FIRST + 9);
        static long TVM_GETNEXTITEM = (TV_FIRST + 10);
        static long TVM_GETITEMA = (TV_FIRST + 12);
        static long TVM_SETITEMA = (TV_FIRST + 13);
        static long TVM_EDITLABELA = (TV_FIRST + 14);
        static long TVM_GETEDITCONTROL = (TV_FIRST + 15);
        static long TVM_GETVISIBLECOUNT = (TV_FIRST + 16);
        static long TVM_HITTEST = (TV_FIRST + 17);
        static long TVM_CREATEDRAGIMAGE = (TV_FIRST + 18);
        static long TVM_SORTCHILDREN = (TV_FIRST + 19);
        static long TVM_ENSUREVISIBLE = (TV_FIRST + 20);
        static long TVM_SORTCHILDRENCB = (TV_FIRST + 21);
        static long TVM_ENDEDITLABELNOW = (TV_FIRST + 22);
        static long TVM_GETISEARCHSTRINGA = (TV_FIRST + 23);
        static long TVM_SETTOOLTIPS = (TV_FIRST + 24);
        static long TVM_GETTOOLTIPS = (TV_FIRST + 25);
        static long TVM_SETINSERTMARK = (TV_FIRST + 26);
        static long TVM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long TVM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long TVM_SETITEMHEIGHT = (TV_FIRST + 27);
        static long TVM_GETITEMHEIGHT = (TV_FIRST + 28);
        static long TVM_SETBKCOLOR = (TV_FIRST + 29);
        static long TVM_SETTEXTCOLOR = (TV_FIRST + 30);
        static long TVM_GETBKCOLOR = (TV_FIRST + 31);
        static long TVM_GETTEXTCOLOR = (TV_FIRST + 32);
        static long TVM_SETSCROLLTIME = (TV_FIRST + 33);
        static long TVM_GETSCROLLTIME = (TV_FIRST + 34);
        static long TVM_SETBORDER = (TV_FIRST + 35);
        static long TVM_SETINSERTMARKCOLOR = (TV_FIRST + 37);
        static long TVM_GETINSERTMARKCOLOR = (TV_FIRST + 38);
        static long TVM_GETITEMSTATE = (TV_FIRST + 39);
        static long TVM_SETLINECOLOR = (TV_FIRST + 40);
        static long TVM_GETLINECOLOR = (TV_FIRST + 41);
        static long TVM_MAPACCIDTOHTREEITEM = (TV_FIRST + 42);
        static long TVM_MAPHTREEITEMTOACCID = (TV_FIRST + 43);
        static long TVM_SETEXTENDEDSTYLE = (TV_FIRST + 44);
        static long TVM_GETEXTENDEDSTYLE = (TV_FIRST + 45);
        static long TVM_INSERTITEMW = (TV_FIRST + 50);
        static long TVM_SETAUTOSCROLLINFO = (TV_FIRST + 59);
        static long TVM_SETHOT = (TV_FIRST + 58);
        static long TVM_GETITEMW = (TV_FIRST + 62);
        static long TVM_SETITEMW = (TV_FIRST + 63);
        static long TVM_GETISEARCHSTRINGW = (TV_FIRST + 64);
        static long TVM_EDITLABELW = (TV_FIRST + 65);
        static long TVM_GETSELECTEDCOUNT = (TV_FIRST + 70);
        static long TVM_SHOWINFOTIP = (TV_FIRST + 71);
        static long TVM_GETITEMPARTRECT = (TV_FIRST + 72);
        static long TV_FIRST = 0x1100;


        // Window
        static long WM_SETTEXT = 0x000C;
        static long WM_GETTEXT = 0x000D;
        static long WM_GETTEXTLENGTH = 0x000E;
        static long WM_QUIT = 0x0012;
        static long WM_GETFONT = 0x0031;
        static long WM_GETOBJECT = 0x003D;
        static long WM_NCHITTEST = 0x0084;
        static long WM_KEYDOWN = 0x0100;
        static long WM_KEYUP = 0x0101;
        static long WM_COMMAND = 0x0111;
        static long WM_SYSCOMMAND = 0x0112;
        static long WM_HSCROLL = 0x0114;
        static long WM_VSCROLL = 0x0115;
        static long WM_LBUTTONDOWN = 0x0201;
        static long WM_LBUTTONUP = 0x0202;
        static long WM_RBUTTONDOWN = 0x0204;
        static long WM_RBUTTONUP = 0x0205;
        static long WM_MDITILE = 0x0226;
        static long WM_MDICASCADE = 0x0227;
        static long WM_HOTKEY = 0x0312;
        static long WM_GETTITLEBARINFOEX = 0x033F;
        static long WM_USER = 0x0400;

        // Dialog Codes
        static long WM_GETDLGCODE = 0x0087;
        static long DLGC_STATIC = 0x0100;

        // Slider
        static long TBM_GETPOS = WM_USER;
        static long TBM_GETRANGEMIN = (WM_USER + 1);
        static long TBM_GETRANGEMAX = (WM_USER + 2);
        static long TBM_GETTIC = (WM_USER + 3);
        static long TBM_SETTIC = (WM_USER + 4);
        static long TBM_SETPOS = (WM_USER + 5);
        static long TBM_SETRANGE = (WM_USER + 6);
        static long TBM_SETRANGEMIN = (WM_USER + 7);
        static long TBM_SETRANGEMAX = (WM_USER + 8);
        static long TBM_CLEARTICS = (WM_USER + 9);
        static long TBM_SETSEL = (WM_USER + 10);
        static long TBM_SETSELSTART = (WM_USER + 11);
        static long TBM_SETSELEND = (WM_USER + 12);
        static long TBM_GETPTICS = (WM_USER + 14);
        static long TBM_GETTICPOS = (WM_USER + 15);
        static long TBM_GETNUMTICS = (WM_USER + 16);
        static long TBM_GETSELSTART = (WM_USER + 17);
        static long TBM_GETSELEND = (WM_USER + 18);
        static long TBM_CLEARSEL = (WM_USER + 19);
        static long TBM_SETTICFREQ = (WM_USER + 20);
        static long TBM_SETPAGESIZE = (WM_USER + 21);
        static long TBM_GETPAGESIZE = (WM_USER + 22);
        static long TBM_SETLINESIZE = (WM_USER + 23);
        static long TBM_GETLINESIZE = (WM_USER + 24);
        static long TBM_GETTHUMBRECT = (WM_USER + 25);
        static long TBM_GETCHANNELRECT = (WM_USER + 26);
        static long TBM_SETTHUMBLENGTH = (WM_USER + 27);
        static long TBM_GETTHUMBLENGTH = (WM_USER + 28);
        static long TBM_SETTOOLTIPS = (WM_USER + 29);
        static long TBM_GETTOOLTIPS = (WM_USER + 30);
        static long TBM_SETTIPSIDE = (WM_USER + 31);
        static long TBM_SETBUDDY = (WM_USER + 32);
        static long TBM_GETBUDDY = (WM_USER + 33);
        static long TBM_SETPOSNOTIFY = (WM_USER + 34);
        static long TBM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long TBM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;

        // Progress Bar

        static long PBM_SETRANGE = (WM_USER + 1);
        static long PBM_SETPOS = (WM_USER + 2);
        static long PBM_DELTAPOS = (WM_USER + 3);
        static long PBM_SETSTEP = (WM_USER + 4);
        static long PBM_STEPIT = (WM_USER + 5);
        static long PBM_SETRANGE32 = (WM_USER + 6);
        static long PBM_GETRANGE = (WM_USER + 7);
        static long PBM_GETPOS = (WM_USER + 8);
        static long PBM_SETBARCOLOR = (WM_USER + 9);
        static long PBM_SETMARQUEE = (WM_USER + 10);
        static long PBM_GETSTEP = (WM_USER + 13);
        static long PBM_GETBKCOLOR = (WM_USER + 14);
        static long PBM_GETBARCOLOR = (WM_USER + 15);
        static long PBM_SETSTATE = (WM_USER + 16);
        static long PBM_GETSTATE = (WM_USER + 17);
        static long PBM_SETBKCOLOR = CCM_SETBKCOLOR;

        // Status Bar

        static long SB_SETTEXTA = WM_USER + 1;
        static long SB_GETTEXTA = WM_USER + 2;
        static long SB_GETTEXTLENGTHA = WM_USER + 3;
        static long SB_SETPARTS = WM_USER + 4;
        static long SB_GETPARTS = WM_USER + 6;
        static long SB_GETBORDERS = WM_USER + 7;
        static long SB_SETMINHEIGHT = WM_USER + 8;
        static long SB_SIMPLE = WM_USER + 9;
        static long SB_GETRECT = WM_USER + 10;
        static long SB_SETTEXTW = WM_USER + 11;
        static long SB_GETTEXTLENGTHW = WM_USER + 12;
        static long SB_GETTEXTW = WM_USER + 13;
        static long SB_ISSIMPLE = WM_USER + 14;
        static long SB_SETICON = WM_USER + 15;
        static long SB_SETTIPTEXTA = WM_USER + 16;
        static long SB_SETTIPTEXTW = WM_USER + 17;
        static long SB_GETTIPTEXTA = WM_USER + 18;
        static long SB_GETTIPTEXTW = WM_USER + 19;
        static long SB_GETICON = WM_USER + 20;
        static long SB_GETTEXTLENGTH = SB_GETTEXTLENGTHW;
        static long SB_SETTIPTEXT = SB_SETTIPTEXTW;
        static long SB_GETTIPTEXT = SB_GETTIPTEXTW;
        static long SB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long SB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long SBT_OWNERDRAW = 0x1000;
        static long SBT_NOBORDERS = 0x0100;
        static long SBT_POPOUT = 0x0200;
        static long SBT_RTLREADING = 0x0400;
        static long SBT_NOTABPARSING = 0x0800;
        static long SB_SETBKCOLOR = CCM_SETBKCOLOR;
        static long SBN_SIMPLEMODECHANGE = SBN_FIRST - 0;
        static long SB_SIMPLEID = 0x00ff;

        // Rebar
        static long RB_INSERTBANDA = WM_USER + 1;
        static long RB_DELETEBAND = WM_USER + 2;
        static long RB_GETBARINFO = WM_USER + 3;
        static long RB_SETBARINFO = WM_USER + 4;
        static long RB_SETBANDINFOA = WM_USER + 6;
        static long RB_SETPARENT = WM_USER + 7;
        static long RB_HITTEST = WM_USER + 8;
        static long RB_GETRECT = WM_USER + 9;
        static long RB_INSERTBANDW = WM_USER + 10;
        static long RB_SETBANDINFOW = WM_USER + 11;
        static long RB_GETBANDCOUNT = WM_USER + 12;
        static long RB_GETROWCOUNT = WM_USER + 13;
        static long RB_GETROWHEIGHT = WM_USER + 14;
        static long RB_IDTOINDEX = WM_USER + 16;
        static long RB_GETTOOLTIPS = WM_USER + 17;
        static long RB_SETTOOLTIPS = WM_USER + 18;
        static long RB_SETBKCOLOR = WM_USER + 19;
        static long RB_GETBKCOLOR = WM_USER + 20;
        static long RB_SETTEXTCOLOR = WM_USER + 21;
        static long RB_GETTEXTCOLOR = WM_USER + 22;
        static long RB_SIZETORECT = WM_USER + 23;
        static long RB_BEGINDRAG = WM_USER + 24;
        static long RB_ENDDRAG = WM_USER + 25;
        static long RB_DRAGMOVE = WM_USER + 26;
        static long RB_GETBARHEIGHT = WM_USER + 27;
        static long RB_GETBANDINFOW = WM_USER + 28;
        static long RB_GETBANDINFOA = WM_USER + 29;
        static long RB_MINIMIZEBAND = WM_USER + 30;
        static long RB_MAXIMIZEBAND = WM_USER + 31;
        static long RB_GETBANDBORDERS = WM_USER + 34;
        static long RB_SHOWBAND = WM_USER + 35;
        static long RB_SETPALETTE = WM_USER + 37;
        static long RB_GETPALETTE = WM_USER + 38;
        static long RB_MOVEBAND = WM_USER + 39;
        static long RB_GETBANDMARGINS = WM_USER + 40;
        static long RB_SETEXTENDEDSTYLE = WM_USER + 41;
        static long RB_GETEXTENDEDSTYLE = WM_USER + 42;
        static long RB_PUSHCHEVRON = WM_USER + 43;
        static long RB_SETBANDWIDTH = WM_USER + 44;
        static long RB_SETCOLORSCHEME = CCM_SETCOLORSCHEME;
        static long RB_GETCOLORSCHEME = CCM_GETCOLORSCHEME;
        static long RB_INSERTBAND = RB_INSERTBANDW;
        static long RB_SETBANDINFO = RB_SETBANDINFOW;
        static long RB_GETDROPTARGET = CCM_GETDROPTARGET;
        static long RB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long RB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long RB_SETWINDOWTHEME = CCM_SETWINDOWTHEME;
        static long RBSTR_CHANGERECT = 0x0001;

        // ToolBar
        static long TB_ENABLEBUTTON = WM_USER + 1;
        static long TB_CHECKBUTTON = WM_USER + 2;
        static long TB_PRESSBUTTON = WM_USER + 3;
        static long TB_HIDEBUTTON = WM_USER + 4;
        static long TB_INDETERMINATE = WM_USER + 5;
        static long TB_MARKBUTTON = WM_USER + 6;
        static long TB_ISBUTTONENABLED = WM_USER + 9;
        static long TB_ISBUTTONCHECKED = WM_USER + 10;
        static long TB_ISBUTTONPRESSED = WM_USER + 11;
        static long TB_ISBUTTONHIDDEN = WM_USER + 12;
        static long TB_ISBUTTONINDETERMINATE = WM_USER + 13;
        static long TB_ISBUTTONHIGHLIGHTED = WM_USER + 14;
        static long TB_SETSTATE = WM_USER + 17;
        static long TB_GETSTATE = WM_USER + 18;
        static long TB_ADDBITMAP = WM_USER + 19;
        static long TB_ADDBUTTONSA = WM_USER + 20;
        static long TB_INSERTBUTTONA = WM_USER + 21;
        static long TB_DELETEBUTTON = WM_USER + 22;
        static long TB_GETBUTTON = WM_USER + 23;
        static long TB_BUTTONCOUNT = WM_USER + 24;
        static long TB_COMMANDTOINDEX = WM_USER + 25;
        static long TB_SAVERESTOREA = WM_USER + 26;
        static long TB_CUSTOMIZE = WM_USER + 27;
        static long TB_ADDSTRINGA = WM_USER + 28;
        static long TB_GETITEMRECT = WM_USER + 29;
        static long TB_BUTTONSTRUCTSIZE = WM_USER + 30;
        static long TB_SETBUTTONSIZE = WM_USER + 31;
        static long TB_SETBITMAPSIZE = WM_USER + 32;
        static long TB_AUTOSIZE = WM_USER + 33;
        static long TB_GETTOOLTIPS = WM_USER + 35;
        static long TB_SETTOOLTIPS = WM_USER + 36;
        static long TB_SETPARENT = WM_USER + 37;
        static long TB_SETROWS = WM_USER + 39;
        static long TB_GETROWS = WM_USER + 40;
        static long TB_GETBITMAPFLAGS = WM_USER + 41;
        static long TB_SETCMDID = WM_USER + 42;
        static long TB_CHANGEBITMAP = WM_USER + 43;
        static long TB_GETBITMAP = WM_USER + 44;
        static long TB_GETBUTTONTEXT = WM_USER + 45;
        static long TB_REPLACEBITMAP = WM_USER + 46;
        static long TB_SETINDENT = WM_USER + 47;
        static long TB_SETIMAGELIST = WM_USER + 48;
        static long TB_GETIMAGELIST = WM_USER + 49;
        static long TB_LOADIMAGES = WM_USER + 50;
        static long TB_GETRECT = WM_USER + 51;
        static long TB_SETHOTIMAGELIST = WM_USER + 52;
        static long TB_GETHOTIMAGELIST = WM_USER + 53;
        static long TB_SETDISABLEDIMAGELIST = WM_USER + 54;
        static long TB_GETDISABLEDIMAGELIST = WM_USER + 55;
        static long TB_SETSTYLE = WM_USER + 56;
        static long TB_GETSTYLE = WM_USER + 57;
        static long TB_GETBUTTONSIZE = WM_USER + 58;
        static long TB_SETBUTTONWIDTH = WM_USER + 59;
        static long TB_SETMAXTEXTROWS = WM_USER + 60;
        static long TB_GETTEXTROWS = WM_USER + 61;
        static long TB_GETOBJECT = WM_USER + 62;
        static long TB_GETBUTTONINFOW = WM_USER + 63;
        static long TB_SETBUTTONINFOW = WM_USER + 64;
        static long TB_GETBUTTONINFOA = WM_USER + 65;
        static long TB_SETBUTTONINFOA = WM_USER + 66;
        static long TB_INSERTBUTTONW = WM_USER + 67;
        static long TB_ADDBUTTONSW = WM_USER + 68;
        static long TB_HITTEST = WM_USER + 69;
        static long TB_SETDRAWTEXTFLAGS = WM_USER + 70;
        static long TB_GETHOTITEM = WM_USER + 71;
        static long TB_SETHOTITEM = WM_USER + 72;
        static long TB_SETANCHORHIGHLIGHT = WM_USER + 73;
        static long TB_GETANCHORHIGHLIGHT = WM_USER + 74;
        //static long TB_GETBUTTONTEXT = WM_USER + 75;
        static long TB_SAVERESTORE = WM_USER + 76;
        static long TB_ADDSTRING = WM_USER + 77;
        static long TB_MAPACCELERATORA = WM_USER + 78;
        static long TB_GETINSERTMARK = WM_USER + 79;
        static long TB_SETINSERTMARK = WM_USER + 80;
        static long TB_INSERTMARKHITTEST = WM_USER + 81;
        static long TB_MOVEBUTTON = WM_USER + 82;
        static long TB_GETMAXSIZE = WM_USER + 83;
        static long TB_SETEXTENDEDSTYLE = WM_USER + 84;
        static long TB_GETEXTENDEDSTYLE = WM_USER + 85;
        static long TB_GETPADDING = WM_USER + 86;
        static long TB_SETPADDING = WM_USER + 87;
        static long TB_SETINSERTMARKCOLOR = WM_USER + 88;
        static long TB_GETINSERTMARKCOLOR = WM_USER + 89;
        static long TB_MAPACCELERATOR = WM_USER + 90;
        static long TB_GETSTRINGW = WM_USER + 91;
        static long TB_GETSTRING = WM_USER + 92;
        static long TB_SETBOUNDINGSIZE = WM_USER + 93;
        static long TB_SETHOTITEM2 = WM_USER + 94;
        static long TB_HASACCELERATOR = WM_USER + 95;
        static long TB_SETLISTGAP = WM_USER + 96;
        static long TB_GETIMAGELISTCOUNT = WM_USER + 98;
        static long TB_GETIDEALSIZE = WM_USER + 99;
        static long TB_GETMETRICS = WM_USER + 101;
        static long TB_SETMETRICS = WM_USER + 102;
        static long TB_GETITEMDROPDOWNRECT = WM_USER + 103;
        static long TB_SETPRESSEDIMAGELIST = WM_USER + 104;
        static long TB_GETPRESSEDIMAGELIST = WM_USER + 105;

        static long TBIMHT_AFTER = 0x00000001;
        static long TBIMHT_BACKGROUND = 0x00000002;
        static long TB_SETCOLORSCHEME = CCM_SETCOLORSCHEME;
        static long TB_GETCOLORSCHEME = CCM_GETCOLORSCHEME;
        static long TB_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long TB_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long TBBF_LARGE = 0x0001;
        static long TBIF_IMAGE = 0x00000001;
        static long TBIF_TEXT = 0x00000002;
        static long TBIF_STATE = 0x00000004;
        static long TBIF_STYLE = 0x00000008;
        static long TBIF_LPARAM = 0x00000010;
        static long TBIF_COMMAND = 0x00000020;
        static long TBIF_SIZE = 0x00000040;
        static long TBIF_BYINDEX = 0x80000000;
        static long TBMF_PAD = 0x00000001;
        static long TBMF_BARPAD = 0x00000002;
        static long TBMF_BUTTONSPACING = 0x00000004;
        static long TB_SETWINDOWTHEME = CCM_SETWINDOWTHEME;

        // Tooltip
        static long TTM_ACTIVATE = (WM_USER + 1);
        static long TTM_SETDELAYTIME = (WM_USER + 3);
        static long TTM_ADDTOOLA = (WM_USER + 4);
        static long TTM_DELTOOLA = (WM_USER + 5);
        static long TTM_NEWTOOLRECTA = (WM_USER + 6);
        static long TTM_RELAYEVENT = (WM_USER + 7);
        static long TTM_GETTOOLINFOA = (WM_USER + 8);
        static long TTM_SETTOOLINFOA = (WM_USER + 9);
        static long TTM_HITTESTA = (WM_USER + 10);
        static long TTM_GETTEXTA = (WM_USER + 11);
        static long TTM_UPDATETIPTEXTA = (WM_USER + 12);
        static long TTM_GETTOOLCOUNT = (WM_USER + 13);
        static long TTM_ENUMTOOLSA = (WM_USER + 14);
        static long TTM_GETCURRENTTOOLA = (WM_USER + 15);
        static long TTM_WINDOWFROMPOINT = (WM_USER + 16);
        static long TTM_TRACKACTIVATE = (WM_USER + 17);
        static long TTM_TRACKPOSITION = (WM_USER + 18);
        static long TTM_SETTIPBKCOLOR = (WM_USER + 19);
        static long TTM_SETTIPTEXTCOLOR = (WM_USER + 20);
        static long TTM_GETDELAYTIME = (WM_USER + 21);
        static long TTM_GETTIPBKCOLOR = (WM_USER + 22);
        static long TTM_GETTIPTEXTCOLOR = (WM_USER + 23);
        static long TTM_SETMAXTIPWIDTH = (WM_USER + 24);
        static long TTM_GETMAXTIPWIDTH = (WM_USER + 25);
        static long TTM_SETMARGIN = (WM_USER + 26);
        static long TTM_GETMARGIN = (WM_USER + 27);
        static long TTM_POP = (WM_USER + 28);
        static long TTM_UPDATE = (WM_USER + 29);
        static long TTM_GETBUBBLESIZE = (WM_USER + 30);
        static long TTM_ADJUSTRECT = (WM_USER + 31);
        static long TTM_SETTITLEA = (WM_USER + 32);
        static long TTM_SETTITLEW = (WM_USER + 33);
        static long TTM_POPUP = (WM_USER + 34);
        static long TTM_GETTITLE = (WM_USER + 35);
        static long TTM_ADDTOOLW = (WM_USER + 50);
        static long TTM_DELTOOLW = (WM_USER + 51);
        static long TTM_NEWTOOLRECTW = (WM_USER + 52);
        static long TTM_GETTOOLINFOW = (WM_USER + 53);
        static long TTM_SETTOOLINFOW = (WM_USER + 54);
        static long TTM_HITTESTW = (WM_USER + 55);
        static long TTM_GETTEXTW = (WM_USER + 56);
        static long TTM_UPDATETIPTEXTW = (WM_USER + 57);
        static long TTM_ENUMTOOLSW = (WM_USER + 58);
        static long TTM_GETCURRENTTOOLW = (WM_USER + 59);
        static long TTM_SETWINDOWTHEME = CCM_SETWINDOWTHEME;

        // IPAddress
        static long IPM_CLEARADDRESS = (WM_USER + 100);
        static long IPM_SETADDRESS = (WM_USER + 101);
        static long IPM_GETADDRESS = (WM_USER + 102);
        static long IPM_SETRANGE = (WM_USER + 103);
        static long IPM_SETFOCUS = (WM_USER + 104);
        static long IPM_ISBLANK = (WM_USER + 105);

        //  SpinControl
        static long UDM_SETRANGE = (WM_USER + 101);
        static long UDM_GETRANGE = (WM_USER + 102);
        static long UDM_SETPOS = (WM_USER + 103);
        static long UDM_GETPOS = (WM_USER + 104);
        static long UDM_SETBUDDY = (WM_USER + 105);
        static long UDM_GETBUDDY = (WM_USER + 106);
        static long UDM_SETACCEL = (WM_USER + 107);
        static long UDM_GETACCEL = (WM_USER + 108);
        static long UDM_SETBASE = (WM_USER + 109);
        static long UDM_GETBASE = (WM_USER + 110);
        static long UDM_SETRANGE32 = (WM_USER + 111);
        static long UDM_GETRANGE32 = (WM_USER + 112);
        static long UDM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long UDM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long UDM_SETPOS32 = (WM_USER + 113);
        static long UDM_GETPOS32 = (WM_USER + 114);

        // Hyperlink
        static long LM_FIRST = (WM_USER + 0x300);
        static long LM_HITTEST = (WM_USER + 0x300);
        static long LM_GETIDEALHEIGHT = (WM_USER + 0x301);
        static long LM_SETITEM = (WM_USER + 0x302);
        static long LM_GETITEM = (WM_USER + 0x303);
        static long LM_GETIDEALSIZE = (LM_GETIDEALHEIGHT);

        // Date/Time picker styles

        static long DTS_UPDOWN = 0x0001;
        static long DTS_SHOWNONE = 0x0002;
        static long DTS_SHORTDATEFORMAT = 0x0000;
        static long DTS_LONGDATEFORMAT = 0x0004;
        static long DTS_SHORTDATECENTURYFORMAT = 0x000C;
        static long DTS_TIMEFORMAT = 0x0009;
        static long DTS_APPCANPARSE = 0x0010;
        static long DTS_RIGHTALIGN = 0x0020;
        // DTS_TIMEFORMAT is wrongly defined in the common control include file with a value of 9
        // TIME_FORMAT + DTS_UPDOWN. 
        // Removes the UPDOWN bit. Use this const to check for TIMEFORMAT
        static long DTS_TIMEFORMATONLY = DTS_TIMEFORMAT & ~DTS_UPDOWN;

        // Dialogbox Styles
        static long DS_CONTROL = 0x00000400;


        //Listbox style 
        static long LBS_NOTIFY = 0x0001;
        static long LBS_SORT = 0x0002;
        static long LBS_NOREDRAW = 0x0004;
        static long LBS_MULTIPLESEL = 0x0008;
        static long LBS_OWNERDRAWFIXED = 0x0010;
        static long LBS_OWNERDRAWVARIABLE = 0x0020;
        static long LBS_HASSTRINGS = 0x0040;
        static long LBS_USETABSTOPS = 0x0080;
        static long LBS_NOINTEGRALHEIGHT = 0x0100;
        static long LBS_MULTICOLUMN = 0x0200;
        static long LBS_WANTKEYBOARDINPUT = 0x0400;
        static long LBS_EXTENDEDSEL = 0x0800;
        static long LBS_DISABLENOSCROLL = 0x1000;
        static long LBS_NODATA = 0x2000;
        static long LBS_NOSEL = 0x4000;
        static long LBS_STANDARD = 0xA00003;
        static long LBS_COMBOBOX = 0x8000;

        static long LB_CTLCODE = 0L;
        static int LB_OKAY = 0;
        static int LB_ERR = (-1);
        static int LB_ERRSPACE = (-2);

        // Listbox notification message
        static int LBN_ERRSPACE = (-2);
        static int LBN_SELCHANGE = 1;
        static int LBN_DBLCLK = 2;
        static int LBN_SELCANCEL = 3;
        static int LBN_SETFOCUS = 4;
        static int LBN_KILLFOCUS = 5;

        // Listbox messages
        static int LB_ADDSTRING = 0x0180;
        static int LB_INSERTSTRING = 0x0181;
        static int LB_DELETESTRING = 0x0182;
        static int LB_SELITEMRANGEEX = 0x0183;
        static int LB_RESETCONTENT = 0x0184;
        static int LB_SETSEL = 0x0185;
        static int LB_SETCURSEL = 0x0186;
        static int LB_GETSEL = 0x0187;
        static int LB_GETCURSEL = 0x0188;
        static int LB_GETTEXT = 0x0189;
        static int LB_GETTEXTLEN = 0x018A;
        static int LB_GETCOUNT = 0x018B;
        static int LB_SELECTSTRING = 0x018C;
        static int LB_DIR = 0x018D;
        static int LB_GETTOPINDEX = 0x018E;
        static int LB_FINDSTRING = 0x018F;
        static int LB_GETSELCOUNT = 0x0190;
        static int LB_GETSELITEMS = 0x0191;
        static int LB_SETTABSTOPS = 0x0192;
        static int LB_GETHORIZONTALEXTENT = 0x0193;
        static int LB_SETHORIZONTALEXTENT = 0x0194;
        static int LB_SETCOLUMNWIDTH = 0x0195;
        static int LB_ADDFILE = 0x0196;
        static int LB_SETTOPINDEX = 0x0197;
        static int LB_GETITEMRECT = 0x0198;
        static int LB_GETITEMDATA = 0x0199;
        static int LB_SETITEMDATA = 0x019A;
        static int LB_SELITEMRANGE = 0x019B;
        static int LB_SETANCHORINDEX = 0x019C;
        static int LB_GETANCHORINDEX = 0x019D;
        static int LB_SETCARETINDEX = 0x019E;
        static int LB_GETCARETINDEX = 0x019F;
        static int LB_SETITEMHEIGHT = 0x01A0;
        static int LB_GETITEMHEIGHT = 0x01A1;
        static int LB_FINDSTRINGEXACT = 0x01A2;
        static int LB_SETLOCALE = 0x01A5;
        static int LB_GETLOCALE = 0x01A6;
        static int LB_SETCOUNT = 0x01A7;
        static int LB_INITSTORAGE = 0x01A8;
        static int LB_ITEMFROMPOINT = 0x01A9;

        // Listview styles
        static long LVS_ICON = 0x0000;
        static long LVS_REPORT = 0x0001;
        static long LVS_SMALLICON = 0x0002;
        static long LVS_LIST = 0x0003;
        static long LVS_TYPEMASK = 0x0003;
        static long LVS_SINGLESEL = 0x0004;
        static long LVS_SHOWSELALWAYS = 0x0008;
        static long LVS_SORTASCENDING = 0x0010;
        static long LVS_SORTDESCENDING = 0x0020;
        static long LVS_SHAREIMAGELISTS = 0x0040;
        static long LVS_NOLABELWRAP = 0x0080;
        static long LVS_AUTOARRANGE = 0x0100;
        static long LVS_EDITLABELS = 0x0200;
        static long LVS_OWNERDATA = 0x1000;
        static long LVS_NOSCROLL = 0x2000;
        static long LVS_TYPESTYLEMASK = 0xfc00;
        static long LVS_ALIGNTOP = 0x0000;
        static long LVS_ALIGNLEFT = 0x0800;
        static long LVS_ALIGNMASK = 0x0c00;
        static long LVS_OWNERDRAWFIXED = 0x0400;
        static long LVS_NOCOLUMNHEADER = 0x4000;
        static long LVS_NOSORTHEADER = 0x8000;



        // Listview extended styles
        static long LVS_EX_GRIDLINES = 0x00000001;
        static long LVS_EX_SUBITEMIMAGES = 0x00000002;
        static long LVS_EX_CHECKBOXES = 0x00000004;
        static long LVS_EX_TRACKSELECT = 0x00000008;
        static long LVS_EX_HEADERDRAGDROP = 0x00000010;
        static long LVS_EX_FULLROWSELECT = 0x00000020;
        static long LVS_EX_ONECLICKACTIVATE = 0x00000040;
        static long LVS_EX_TWOCLICKACTIVATE = 0x00000080;
        static long LVS_EX_FLATSB = 0x00000100;
        static long LVS_EX_REGIONAL = 0x00000200;
        static long LVS_EX_INFOTIP = 0x00000400;
        static long LVS_EX_UNDERLINEHOT = 0x00000800;
        static long LVS_EX_UNDERLINECOLD = 0x00001000;
        static long LVS_EX_MULTIWORKAREAS = 0x00002000;
        static long LVS_EX_LABELTIP = 0x00004000;
        static long LVS_EX_BORDERSELECT = 0x00008000;
        static long LVS_EX_DOUBLEBUFFER = 0x00010000;
        static long LVS_EX_HIDELABELS = 0x00020000;
        static long LVS_EX_SINGLEROW = 0x00040000;
        static long LVS_EX_SNAPTOGRID = 0x00080000;
        static long LVS_EX_SIMPLESELECT = 0x00100000;
        static long LVS_EX_JUSTIFYCOLUMNS = 0x00200000;  // Icons are lined up in columns that use up the whole view area
        static long LVS_EX_TRANSPARENTBKGND = 0x00400000;
        static long LVS_EX_TRANSPARENTSHADOWTEXT = 0x00800000;
        static long LVS_EX_AUTOAUTOARRANGE = 0x01000000;
        static long LVS_EX_HEADERINALLVIEWS = 0x02000000;
        static long LVS_EX_AUTOCHECKSELECT = 0x08000000;
        static long LVS_EX_AUTOSIZECOLUMNS = 0x10000000;
        static long LVS_EX_COLUMNSNAPPOINTS = 0x40000000;
        static long LVS_EX_COLUMNOVERFLOW = 0x80000000;

        // Listview item states
        static long LVIS_FOCUSED = 0x0001;
        static long LVIS_SELECTED = 0x0002;
        static long LVIS_CUT = 0x0004;
        static long LVIS_DROPHILITED = 0x0008;
        static long LVIS_GLOW = 0x0010;
        static long LVIS_ACTIVATING = 0x0020;
        static long LVIS_OVERLAYMASK = 0x0F00;
        static long LVIS_STATEIMAGEMASK = 0xF000;

        // commctrl MONTHCAL CONTROL style constants
        static long MCS_DAYSTATE = 0x0001;
        static long MCS_MULTISELECT = 0x0002;
        static long MCS_WEEKNUMBERS = 0x0004;
        static long MCS_NOTODAYCIRCLE = 0x0008;
        static long MCS_NOTODAY = 0x0010;
        static long MCS_NOTRAILINGDATES = 0x0040;
        static long MCS_SHORTDAYSOFWEEK = 0x0080;
        static long MCS_NOSELCHANGEONNAV = 0x0100;

        // PAGER CONTROL styles from commctrl.h
        static long PGS_VERT = 0x00000000;
        static long PGS_HORZ = 0x00000001;
        static long PGS_AUTOSCROLL = 0x00000002;
        static long PGS_DRAGNDROP = 0x00000004;
        static long PGB_TOPORLEFT = 0;
        static long PGB_BOTTOMORRIGHT = 1;

        // Scrollbar style
        static long SBS_HORZ = 0;
        static long SBS_VERT = 1;
        static long SBS_TOPALIGN = 2;
        static long SBS_LEFTALIGN = 2;
        static long SBS_BOTTOMALIGN = 4;
        static long SBS_RIGHTALIGN = 4;
        static long SBS_SIZEBOXTOPLEFTALIGN = 2;
        static long SBS_SIZEBOXBOTTOMRIGHTALIGN = 4;
        static long SBS_SIZEBOX = 8;
        static long SBS_SIZEGRIP = 0x10;

        // Slider style
        static long TBS_VERT = 0x0002;
        static long TBS_AUTOTICKS = 0x0001;
        static long TBS_HORZ = 0x0000;
        static long TBS_TOP = 0x0004;
        static long TBS_BOTTOM = 0x0000;
        static long TBS_LEFT = 0x0004;
        static long TBS_RIGHT = 0x0000;
        static long TBS_BOTH = 0x0008;
        static long TBS_NOTICKS = 0x0010;
        static long TBS_ENABLESELRANGE = 0x0020;
        static long TBS_FIXEDLENGTH = 0x0040;
        static long TBS_NOTHUMB = 0x0080;
        static long TBS_TOOLTIPS = 0x0100;
        static long TBS_REVERSED = 0x0200;
        static long TBS_DOWNISLEFT = 0x0400;
        static long TBS_NOTIFYBEFOREMOVE = 0x0800;
        static long TBS_TRANSPARENTBKGND = 0x1000;


        // SysHeader32 styles
        //static long HDS_HORZ = 0x0000;
        static long HDS_VERT = 0x0001;

        // Toolbar styles
        static long TBSTYLE_BUTTON = 0x0000;
        static long TBSTYLE_SEP = 0x0001;
        static long TBSTYLE_CHECK = 0x0002;
        static long TBSTYLE_GROUP = 0x0004;
        static long TBSTYLE_CHECKGROUP = (TBSTYLE_GROUP | TBSTYLE_CHECK);
        static long TBSTYLE_DROPDOWN = 0x0008;
        static long TBSTYLE_AUTOSIZE = 0x0010;
        static long TBSTYLE_NOPREFIX = 0x0020;
        static long TBSTYLE_TOOLTIPS = 0x0100;
        static long TBSTYLE_WRAPABLE = 0x0200;
        static long TBSTYLE_ALTDRAG = 0x0400;
        static long TBSTYLE_FLAT = 0x0800;
        static long TBSTYLE_LIST = 0x1000;
        static long TBSTYLE_CUSTOMERASE = 0x2000;
        static long TBSTYLE_REGISTERDROP = 0x4000;
        static long TBSTYLE_TRANSPARENT = 0x8000;
        static long TBSTYLE_EX_DRAWDDARROWS = 0x00000001;
        static long TBSTYLE_EX_MIXEDBUTTONS = 0x00000008;
        static long TBSTYLE_EX_HIDECLIPPEDBUTTONS = 0x00000010;
        static long TBSTYLE_EX_MULTICOLUMN = 0x00000002;
        static long TBSTYLE_EX_VERTICAL = 0x00000004;
        static long TBSTYLE_EX_DOUBLEBUFFER = 0x00000080;

        // Toolbar button styles
        static long BTNS_BUTTON = TBSTYLE_BUTTON;
        static long BTNS_SEP = TBSTYLE_SEP;
        static long BTNS_CHECK = TBSTYLE_CHECK;
        static long BTNS_GROUP = TBSTYLE_GROUP;
        static long BTNS_CHECKGROUP = TBSTYLE_CHECKGROUP | TBSTYLE_CHECK;
        static long BTNS_DROPDOWN = TBSTYLE_DROPDOWN;
        static long BTNS_AUTOSIZE = TBSTYLE_AUTOSIZE;
        static long BTNS_NOPREFIX = TBSTYLE_NOPREFIX;
        static long BTNS_SHOWTEXT = 0x0040;
        static long BTNS_WHOLEDROPDOWN = 0x0080;

        // Image list constants
        static long I_IMAGENONE = -2;
        static long I_INDENTCALLBACK = (-1);
        static long I_GROUPIDCALLBACK = (-1);
        static long I_GROUPIDNONE = (-2);
        static long I_IMAGECALLBACK = (-1);
        static long I_COLUMNSCALLBACK = (-1);

        // GetWindow()
        static long GW_HWNDFIRST = 0;
        static long GW_HWNDLAST = 1;
        static long GW_HWNDNEXT = 2;
        static long GW_HWNDPREV = 3;
        static long GW_OWNER = 4;
        static long GW_CHILD = 5;
        static long GW_ENABLEDPOPUP = 6;

        //==============================================
        //GetWindowLong()
        //==============================================
        static long GWL_WNDPROC = -4;
        /// <summary>
        /// Sets a new application instance handle.
        /// </summary>
        static long GWL_HINSTANCE = -6;
        static long GWL_HWNDPARENT = -8;
        /// <summary>
        /// Sets a new identifier of the child window. The window cannot be a top-level window.
        /// </summary>
        static long GWL_ID = -12;
        /// <summary>
        /// Sets a new window style.
        /// </summary>
        static long GWL_STYLE = -16;
        /// <summary>
        /// Sets a new extended window style.
        /// </summary>
        static long GWL_EXSTYLE = -20;
        /// <summary>
        /// Sets the user data associated with the window. This data is intended for use by the application that created the window. Its value is initially zero.
        /// </summary>
        static long GWL_USERDATA = -21;
        static long GCL_WNDPROC = -24;
        static long SORT_DEFAULT = 0x0;
        static long SUBLANG_DEFAULT = 0x01;

        static long SC_TASKLIST = 0xF130;

        //WMWindowPosChanged message constants
        static long SWP_NOSIZE = 0x00001;
        static long SWP_NOMOVE = 0x00002;
        static long SWP_NOZORDER = 0x00004;
        static long SWP_NOREDRAW = 0x00008;
        static long SWP_NOACTIVATE = 0x00010;
        static long SWP_DRAWFRAME = 0x00020;
        static long SWP_FRAMECHANGED = 0x00020;
        /// <summary>
        /// Displays the window.
        /// </summary>
        /// <remarks>
        /// SWP_SHOWWINDOW
        /// </remarks>
        static long SWP_SHOWWINDOW = 0x0040;
        /// <summary>
        /// Hides the window.
        /// </summary>
        /// <remarks>
        /// SWP_HIDEWINDOW
        /// </remarks>
        static long SWP_HIDEWINDOW = 0x0080;
        static long SWP_NOCOPYBITS = 0x00100;
        static long SWP_NOOWNERZORDER = 0x00200;
        static long SWP_NOREPOSITION = 0x00200;
        static long SWP_NOSENDCHANGING = 0x00400;
        static long SWP_DEFERERASE = 0x02000;
        static long SWP_ASYNCWINDOWPOS = 0x04000;
        static long SWP_STATECHANGED = 0x08000; //used by windows but not documented (used even in wine)
        static long SWP_SourceIsInterface = 0x10000; //this flag can be combined with the above

        //--------------
        //Font Weights
        //--------------
        static long FW_DONTCARE = 0;
        static long FW_THIN = 100;
        static long FW_EXTRALIGHT = 200;
        static long FW_LIGHT = 300;
        static long FW_NORMAL = 400;
        static long FW_MEDIUM = 500;
        static long FW_SEMIBOLD = 600;
        static long FW_BOLD = 700;
        static long FW_EXTRABOLD = 800;
        static long FW_HEAVY = 900;
        static long FW_ULTRALIGHT = FW_EXTRALIGHT;
        static long FW_REGULAR = FW_NORMAL;
        static long FW_DEMIBOLD = FW_SEMIBOLD;
        static long FW_ULTRABOLD = FW_EXTRABOLD;
        static long FW_BLACK = FW_HEAVY;

        static long FOUNDRYCHAR_OPEN = '[';  //added for support foundry encoded in family name
        static long FOUNDRYCHAR_CLOSE = ']';  //also needed to drop foundry when creating font in windows


        //==============================================
        //SystemMetrics constants
        //==============================================
        static long SM_CXSCREEN = 0;
        static long SM_CYSCREEN = 1;
        static long SM_CXVSCROLL = 2;
        static long SM_CYHSCROLL = 3;
        static long SM_CYCAPTION = 4;
        static long SM_CXBORDER = 5;
        static long SM_CYBORDER = 6;
        static long SM_CXDLGFRAME = 7;
        static long SM_CYDLGFRAME = 8;
        static long SM_CYVTHUMB = 9;
        static long SM_CXHTHUMB = 10;
        static long SM_CXICON = 11;
        static long SM_CYICON = 12;
        static long SM_CXCURSOR = 13;
        static long SM_CYCURSOR = 14;
        static long SM_CYMENU = 15;
        static long SM_CXFULLSCREEN = 16;
        static long SM_CYFULLSCREEN = 17;
        static long SM_CYKANJIWINDOW = 18;
        static long SM_MOUSEPRESENT = 19;
        static long SM_CYVSCROLL = 20;
        static long SM_CXHSCROLL = 21;
        static long SM_DEBUG = 22;
        static long SM_SWAPBUTTON = 23;
        static long SM_RESERVED1 = 24;
        static long SM_RESERVED2 = 25;
        static long SM_RESERVED3 = 26;
        static long SM_RESERVED4 = 27;
        static long SM_CXMIN = 28;
        static long SM_CYMIN = 29;
        static long SM_CXSIZE = 30;
        static long SM_CYSIZE = 31;
        static long SM_CXFRAME = 32;
        static long SM_CYFRAME = 33;
        static long SM_CXMINTRACK = 34;
        static long SM_CYMINTRACK = 35;
        static long SM_CXDOUBLECLK = 36;
        static long SM_CYDOUBLECLK = 37;
        static long SM_CXICONSPACING = 38;
        static long SM_CYICONSPACING = 39;
        static long SM_MENUDROPALIGNMENT = 40;
        static long SM_PENWINDOWS = 41;
        static long SM_DBCSENABLED = 42;
        static long SM_CMOUSEBUTTONS = 43;
        static long SM_SECURE = 44;
        static long SM_CXEDGE = 45;
        static long SM_CYEDGE = 46;
        static long SM_CXMINSPACING = 47;
        static long SM_CYMINSPACING = 48;
        static long SM_CXSMICON = 49;
        static long SM_CYSMICON = 50;
        static long SM_CYSMCAPTION = 51;
        static long SM_CXSMSIZE = 52;
        static long SM_CYSMSIZE = 53;
        static long SM_CXMENUSIZE = 54;
        static long SM_CYMENUSIZE = 55;
        static long SM_ARRANGE = 56;
        static long SM_CXMINIMIZED = 57;
        static long SM_CYMINIMIZED = 58;
        static long SM_CXMAXTRACK = 59;
        static long SM_CYMAXTRACK = 60;
        static long SM_CXMAXIMIZED = 61;
        static long SM_CYMAXIMIZED = 62;
        static long SM_NETWORK = 63;
        static long SM_CLEANBOOT = 67;
        static long SM_CXDRAG = 68;
        static long SM_CYDRAG = 69;
        static long SM_SHOWSOUNDS = 70;
        static long SM_CXMENUCHECK = 71;
        static long SM_CYMENUCHECK = 72;
        static long SM_SLOWMACHINE = 73;
        static long SM_MIDEASTENABLED = 74;
        static long SM_MOUSEWHEELPRESENT = 75;
        static long SM_CMETRICS = 76;
        static long SM_XVIRTUALSCREEN = 76;
        // Stock Logical Objects
        static long SM_YVIRTUALSCREEN = 77;
        static long SM_CXVIRTUALSCREEN = 78;
        static long SM_CYVIRTUALSCREEN = 79;
        static long SM_CMONITORS = 80;
        static long SM_SAMEDISPLAYFORMAT = 81;


        //listview
        static long LVN_FIRST = -100;
        static long LVN_LAST = -199;
        //header
        static long HDN_FIRST = -300;
        static long HDN_LAST = -399;
        //treeview
        static long TVN_FIRST = -400;
        static long TVN_LAST = -499;
        //tooltips
        static long TTN_FIRST = -520;
        static long TTN_LAST = -549;
        //tab control
        static long TCN_FIRST = -550;
        static long TCN_LAST = -580;

        /*
        static long LVN_FIRST = (100U);
        static long LVN_LAST = (199U);
        static long HDN_FIRST = (300U);
        static long HDN_LAST = (399U);
        static long TVN_FIRST = (400U);
        static long TVN_LAST = (499U);
        static long TTN_FIRST = (520U);
        static long TTN_LAST = (549U);
        static long TCN_FIRST = (550U);
        static long TCN_LAST = (580U);
        */

        static long SM_SWSCROLLBARSPACING = 120;
        //needed for accurate maximized window size, since under X11 we cannot get it until
        //window is decorated by wm. see issue #21119.
        static long SM_LCLMAXIMIZEDWIDTH = 121;
        static long SM_LCLMAXIMIZEDHEIGHT = 122;
        static long SM_LCLHasFormAlphaBlend = 123;

        static long SM_CXFIXEDFRAME = SM_CXDLGFRAME;
        static long SM_CYFIXEDFRAME = SM_CYDLGFRAME;
        static long SM_CXSIZEFRAME = SM_CXFRAME;
        static long SM_CYSIZEFRAME = SM_CYFRAME;

        static long MAX_PATH = 260;

        static long MDITILE_VERTICAL = 0x0000;
        static long MDITILE_HORIZONTAL = 0x0001;
        static long MDITILE_SKIPDISABLED = 0x0002;

        static long S_OK = 0x00000000;
        static long S_FALSE = 0x00000001;

        static long ICC_LISTVIEW_CLASSES = 0x00000001;
        static long ICC_TREEVIEW_CLASSES = 0x00000002;
        static long ICC_BAR_CLASSES = 0x00000004;
        static long ICC_TAB_CLASSES = 0x00000008;
        static long ICC_UPDOWN_CLASS = 0x00000010;
        static long ICC_PROGRESS_CLASS = 0x00000020;
        static long ICC_HOTKEY_CLASS = 0x00000040;
        static long ICC_ANIMATE_CLASS = 0x00000080;
        static long ICC_WIN95_CLASSES = 0x000000FF;
        static long ICC_DATE_CLASSES = 0x00000100;
        static long ICC_USEREX_CLASSES = 0x00000200;
        static long ICC_COOL_CLASSES = 0x00000400;
        static long ICC_INTERNET_CLASSES = 0x00000800;
        static long ICC_PAGESCROLLER_CLASS = 0x00001000;
        static long ICC_NATIVEFNTCTL_CLASS = 0x00002000;
        static long ICC_STANDARD_CLASSES = 0x00004000;
        static long ICC_LINK_CLASS = 0x00008000;

        static long ECM_FIRST = 0x1500;

        static long BCM_FIRST = 0x1600;

        static long CBM_FIRST = 0x1700;

        static long CCM_FIRST = 0x2000;
        static long CCM_LAST = (CCM_FIRST + 0x200);
        static long CCM_SETBKCOLOR = (CCM_FIRST + 1);
        static long CCM_SETCOLORSCHEME = (CCM_FIRST + 2);
        static long CCM_GETCOLORSCHEME = (CCM_FIRST + 3);
        static long CCM_GETDROPTARGET = (CCM_FIRST + 4);
        static long CCM_SETUNICODEFORMAT = (CCM_FIRST + 5);
        static long CCM_GETUNICODEFORMAT = (CCM_FIRST + 6);
        static long CCM_SETVERSION = (CCM_FIRST + 0x7);
        static long CCM_GETVERSION = (CCM_FIRST + 0x8);
        static long CCM_SETNOTIFYWINDOW = (CCM_FIRST + 0x9);
        static long CCM_SETWINDOWTHEME = (CCM_FIRST + 0xb);
        static long CCM_DPISCALE = (CCM_FIRST + 0xc);

        static long INFOTIPSIZE = 1024;

        static long CDN_FIRST = (601U);
        static long CDN_LAST = (699U);
        static long TBN_FIRST = (700U);
        static long TBN_LAST = (720U);
        static long UDN_FIRST = (721U);
        static long UDN_LAST = (729U);
        static long DTN_FIRST = (740U);
        static long DTN_LAST = (745U);
        static long MCN_FIRST = (746U);
        static long MCN_LAST = (752U);
        static long DTN_FIRST2 = (753U);
        static long DTN_LAST2 = (799U);
        static long CBEN_FIRST = (800U);
        static long CBEN_LAST = (830U);
        static long RBN_FIRST = (831U);
        static long RBN_LAST = (859U);
        static long SBN_FIRST = (880U);
        static long SBN_LAST = (899U);
        static long PGN_FIRST = (900U);
        static long PGN_LAST = (950U);
        static long WMN_FIRST = (1000U);
        static long WMN_LAST = (1200U);
        static long BCN_FIRST = (1250U);
        static long BCN_LAST = (1350U);
        static long TRBN_FIRST = (1501U);
        static long TRBN_LAST = (1519U);
        static long IPN_FIRST = (860U);
        static long IPN_LAST = (879U);
        static long IPN_FIELDCHANGED = (IPN_FIRST - 0);

        static long MSGF_COMMCTRL_BEGINDRAG = 0x4200;
        static long MSGF_COMMCTRL_SIZEHEADER = 0x4201;
        static long MSGF_COMMCTRL_DRAGSELECT = 0x4202;
        static long MSGF_COMMCTRL_TOOLBARCUST = 0x4203;

        static long CDRF_DODEFAULT = 0x00000000;
        static long CDRF_NEWFONT = 0x00000002;
        static long CDRF_SKIPDEFAULT = 0x00000004;
        static long CDRF_DOERASE = 0x00000008;
        static long CDRF_SKIPPOSTPAINT = 0x00000100;
        static long CDRF_NOTIFYPOSTPAINT = 0x00000010;
        static long CDRF_NOTIFYITEMDRAW = 0x00000020;
        static long CDRF_NOTIFYSUBITEMDRAW = 0x00000020;
        static long CDRF_NOTIFYPOSTERASE = 0x00000040;

        static long CDDS_PREPAINT = 0x00000001;
        static long CDDS_POSTPAINT = 0x00000002;
        static long CDDS_PREERASE = 0x00000003;
        static long CDDS_POSTERASE = 0x00000004;
        static long CDDS_ITEM = 0x00010000;
        static long CDDS_ITEMPREPAINT = (CDDS_ITEM | CDDS_PREPAINT);
        static long CDDS_ITEMPOSTPAINT = (CDDS_ITEM | CDDS_POSTPAINT);
        static long CDDS_ITEMPREERASE = (CDDS_ITEM | CDDS_PREERASE);
        static long CDDS_ITEMPOSTERASE = (CDDS_ITEM | CDDS_POSTERASE);
        static long CDDS_SUBITEM = 0x00020000;

        static long CDIS_SELECTED = 0x0001;
        static long CDIS_GRAYED = 0x0002;
        static long CDIS_DISABLED = 0x0004;
        static long CDIS_CHECKED = 0x0008;
        static long CDIS_FOCUS = 0x0010;
        static long CDIS_DEFAULT = 0x0020;
        static long CDIS_HOT = 0x0040;
        static long CDIS_MARKED = 0x0080;
        static long CDIS_INDETERMINATE = 0x0100;
        static long CDIS_SHOWKEYBOARDCUES = 0x0200;
        static long CDIS_NEARHOT = 0x0400;
        static long CDIS_OTHERSIDEHOT = 0x0800;
        static long CDIS_DROPHILITED = 0x1000;

        static long NM_GETCUSTOMSPLITRECT = (BCN_FIRST + 0x0003);

        static long CLR_NONE = 0xFFFFFFFF;
        static long CLR_DEFAULT = 0xFF000000;
        static long CLR_HILIGHT = CLR_DEFAULT;
        static long CLR_INVALID = 0xFFFFFFFF;

        static long ILC_MASK = 0x00000001;
        static long ILC_COLOR = 0x00000000;
        static long ILC_COLORDDB = 0x000000FE;
        static long ILC_COLOR4 = 0x00000004;
        static long ILC_COLOR8 = 0x00000008;
        static long ILC_COLOR16 = 0x00000010;
        static long ILC_COLOR24 = 0x00000018;
        static long ILC_COLOR32 = 0x00000020;
        static long ILC_PALETTE = 0x00000800;
        static long ILC_MIRROR = 0x00002000;
        static long ILC_PERITEMMIRROR = 0x00008000;
        static long ILC_ORIGINALSIZE = 0x00010000;
        static long ILC_HIGHQUALITYSCALE = 0x00020000;

        static long ILD_NORMAL = 0x00000000;
        static long ILD_TRANSPARENT = 0x00000001;
        static long ILD_MASK = 0x00000010;
        static long ILD_IMAGE = 0x00000020;
        static long ILD_ROP = 0x00000040;
        static long ILD_BLEND25 = 0x00000002;
        static long ILD_BLEND50 = 0x00000004;
        static long ILD_OVERLAYMASK = 0x00000F00;
        static long ILD_PRESERVEALPHA = 0x00001000;
        static long ILD_SCALE = 0x00002000;
        static long ILD_DPISCALE = 0x00004000;
        static long ILD_ASYNC = 0x00008000;
        static long ILD_SELECTED = ILD_BLEND50;
        static long ILD_FOCUS = ILD_BLEND25;
        static long ILD_BLEND = ILD_BLEND50;

        static long ILS_NORMAL = 0x00000000;
        static long ILS_GLOW = 0x00000001;
        static long ILS_SHADOW = 0x00000002;
        static long ILS_SATURATE = 0x00000004;
        static long ILS_ALPHA = 0x00000008;

        static long ILGT_NORMAL = 0x00000000;
        static long ILGT_ASYNC = 0x00000001;

        static long ILCF_MOVE = (0x00000000);
        static long ILCF_SWAP = (0x00000001);

        static long ILP_NORMAL = 0;
        static long ILP_DOWNLEVEL = 1;

        static long HDS_HORZ = 0x0000;
        static long HDS_BUTTONS = 0x0002;
        static long HDS_HOTTRACK = 0x0004;
        static long HDS_HIDDEN = 0x0008;
        static long HDS_DRAGDROP = 0x0040;
        static long HDS_FULLDRAG = 0x0080;
        static long HDS_FILTERBAR = 0x0100;
        static long HDS_FLAT = 0x0200;
        static long HDS_CHECKBOXES = 0x0400;
        static long HDS_NOSIZING = 0x0800;
        static long HDS_OVERFLOW = 0x1000;

        static long HDFT_ISSTRING = 0x0000;
        static long HDFT_ISNUMBER = 0x0001;
        static long HDFT_ISDATE = 0x0002;
        static long HDFT_HASNOVALUE = 0x8000;

        static long HDI_WIDTH = 0x0001;
        static long HDI_HEIGHT = HDI_WIDTH;
        static long HDI_TEXT = 0x0002;
        static long HDI_FORMAT = 0x0004;
        static long HDI_LPARAM = 0x0008;
        static long HDI_BITMAP = 0x0010;
        static long HDI_IMAGE = 0x0020;
        static long HDI_DI_SETITEM = 0x0040;
        static long HDI_ORDER = 0x0080;
        static long HDI_FILTER = 0x0100;
        static long HDI_STATE = 0x0200;

        static long HDF_LEFT = 0x0000;
        static long HDF_RIGHT = 0x0001;
        static long HDF_CENTER = 0x0002;
        static long HDF_JUSTIFYMASK = 0x0003;
        static long HDF_RTLREADING = 0x0004;
        static long HDF_BITMAP = 0x2000;
        static long HDF_STRING = 0x4000;
        static long HDF_OWNERDRAW = 0x8000;
        static long HDF_IMAGE = 0x0800;
        static long HDF_BITMAP_ON_RIGHT = 0x1000;
        static long HDF_SORTUP = 0x0400;
        static long HDF_SORTDOWN = 0x0200;
        static long HDF_CHECKBOX = 0x0040;
        static long HDF_CHECKED = 0x0080;
        static long HDF_FIXEDWIDTH = 0x0100;
        static long HDF_SPLITBUTTON = 0x1000000;

        static long HDIS_FOCUSED = 0x00000001;

        static long HHT_NOWHERE = 0x0001;
        static long HHT_ONHEADER = 0x0002;
        static long HHT_ONDIVIDER = 0x0004;
        static long HHT_ONDIVOPEN = 0x0008;
        static long HHT_ONFILTER = 0x0010;
        static long HHT_ONFILTERBUTTON = 0x0020;
        static long HHT_ABOVE = 0x0100;
        static long HHT_BELOW = 0x0200;
        static long HHT_TORIGHT = 0x0400;
        static long HHT_TOLEFT = 0x0800;
        static long HHT_ONITEMSTATEICON = 0x1000;
        static long HHT_ONDROPDOWN = 0x2000;
        static long HHT_ONOVERFLOW = 0x4000;

        static long HDSIL_NORMAL = 0;
        static long HDSIL_STATE = 1;

        static long HDN_ITEMCHANGINGA = (HDN_FIRST - 0);
        static long HDN_ITEMCHANGINGW = (HDN_FIRST - 20);
        static long HDN_ITEMCHANGEDA = (HDN_FIRST - 1);
        static long HDN_ITEMCHANGEDW = (HDN_FIRST - 21);
        static long HDN_ITEMCLICKA = (HDN_FIRST - 2);
        static long HDN_ITEMCLICKW = (HDN_FIRST - 22);
        static long HDN_ITEMDBLCLICKA = (HDN_FIRST - 3);
        static long HDN_ITEMDBLCLICKW = (HDN_FIRST - 23);
        static long HDN_DIVIDERDBLCLICKA = (HDN_FIRST - 5);
        static long HDN_DIVIDERDBLCLICKW = (HDN_FIRST - 25);
        static long HDN_BEGINTRACKA = (HDN_FIRST - 6);
        static long HDN_BEGINTRACKW = (HDN_FIRST - 26);
        static long HDN_ENDTRACKA = (HDN_FIRST - 7);
        static long HDN_ENDTRACKW = (HDN_FIRST - 27);
        static long HDN_TRACKA = (HDN_FIRST - 8);
        static long HDN_TRACKW = (HDN_FIRST - 28);
        static long HDN_GETDISPINFOA = (HDN_FIRST - 9);
        static long HDN_GETDISPINFOW = (HDN_FIRST - 29);
        static long HDN_BEGINDRAG = (HDN_FIRST - 10);
        static long HDN_ENDDRAG = (HDN_FIRST - 11);
        static long HDN_FILTERCHANGE = (HDN_FIRST - 12);
        static long HDN_FILTERBTNCLICK = (HDN_FIRST - 13);
        static long HDN_BEGINFILTEREDIT = (HDN_FIRST - 14);
        static long HDN_ENDFILTEREDIT = (HDN_FIRST - 15);
        static long HDN_ITEMSTATEICONCLICK = (HDN_FIRST - 16);
        static long HDN_ITEMKEYDOWN = (HDN_FIRST - 17);
        static long HDN_DROPDOWN = (HDN_FIRST - 18);
        static long HDN_OVERFLOWCLICK = (HDN_FIRST - 19);

        static long CMB_MASKED = 0x02;

        static long TBSTATE_CHECKED = 0x01;
        static long TBSTATE_PRESSED = 0x02;
        static long TBSTATE_ENABLED = 0x04;
        static long TBSTATE_HIDDEN = 0x08;
        static long TBSTATE_INDETERMINATE = 0x10;
        static long TBSTATE_WRAP = 0x20;
        static long TBSTATE_ELLIPSES = 0x40;
        static long TBSTATE_MARKED = 0x80;

        static long TBCDRF_NOEDGES = 0x00010000;
        static long TBCDRF_HILITEHOTTRACK = 0x00020000;
        static long TBCDRF_NOOFFSET = 0x00040000;
        static long TBCDRF_NOMARK = 0x00080000;
        static long TBCDRF_NOETCHEDEFFECT = 0x00100000;
        static long TBCDRF_BLENDICON = 0x00200000;
        static long TBCDRF_NOBACKGROUND = 0x00400000;
        static long TBCDRF_USECDCOLORS = 0x00800000;

        static long IDB_STD_SMALL_COLOR = 0;
        static long IDB_STD_LARGE_COLOR = 1;
        static long IDB_VIEW_SMALL_COLOR = 4;
        static long IDB_VIEW_LARGE_COLOR = 5;
        static long IDB_HIST_SMALL_COLOR = 8;
        static long IDB_HIST_LARGE_COLOR = 9;
        static long IDB_HIST_NORMAL = 12;
        static long IDB_HIST_HOT = 13;
        static long IDB_HIST_DISABLED = 14;
        static long IDB_HIST_PRESSED = 15;

        static long STD_CUT = 0;
        static long STD_COPY = 1;
        static long STD_PASTE = 2;
        static long STD_UNDO = 3;
        static long STD_REDOW = 4;
        static long STD_DELETE = 5;
        static long STD_FILENEW = 6;
        static long STD_FILEOPEN = 7;
        static long STD_FILESAVE = 8;
        static long STD_PRINTPRE = 9;
        static long STD_PROPERTIES = 10;
        static long STD_HELP = 11;
        static long STD_FIND = 12;
        static long STD_REPLACE = 13;
        static long STD_PRINT = 14;

        static long VIEW_LARGEICONS = 0;
        static long VIEW_SMALLICONS = 1;
        static long VIEW_LIST = 2;
        static long VIEW_DETAILS = 3;
        static long VIEW_SORTNAME = 4;
        static long VIEW_SORTSIZE = 5;
        static long VIEW_SORTDATE = 6;
        static long VIEW_SORTTYPE = 7;
        static long VIEW_PARENTFOLDER = 8;
        static long VIEW_NETCONNECT = 9;
        static long VIEW_NETDISCONNECT = 10;
        static long VIEW_NEWFOLDER = 11;
        static long VIEW_VIEWMENU = 12;

        static long HIST_BACK = 0;
        static long HIST_FORWARD = 1;
        static long HIST_FAVORITES = 2;
        static long HIST_ADDTOFAVORITES = 3;
        static long HIST_VIEWTREE = 4;

        static long TBN_GETBUTTONINFOA = (TBN_FIRST - 0);
        static long TBN_BEGINDRAG = (TBN_FIRST - 1);
        static long TBN_ENDDRAG = (TBN_FIRST - 2);
        static long TBN_BEGINADJUST = (TBN_FIRST - 3);
        static long TBN_ENDADJUST = (TBN_FIRST - 4);
        static long TBN_RESET = (TBN_FIRST - 5);
        static long TBN_QUERYINSERT = (TBN_FIRST - 6);
        static long TBN_QUERYDELETE = (TBN_FIRST - 7);
        static long TBN_TOOLBARCHANGE = (TBN_FIRST - 8);
        static long TBN_CUSTHELP = (TBN_FIRST - 9);
        static long TBN_DROPDOWN = (TBN_FIRST - 10);
        static long TBN_GETOBJECT = (TBN_FIRST - 12);

        static long HICF_OTHER = 0x00000000;
        static long HICF_MOUSE = 0x00000001;
        static long HICF_ARROWKEYS = 0x00000002;
        static long HICF_ACCELERATOR = 0x00000004;
        static long HICF_DUPACCEL = 0x00000008;
        static long HICF_ENTERING = 0x00000010;
        static long HICF_LEAVING = 0x00000020;
        static long HICF_RESELECT = 0x00000040;
        static long HICF_LMOUSE = 0x00000080;
        static long HICF_TOGGLEDROPDOWN = 0x00000100;

        static long TBN_HOTITEMCHANGE = (TBN_FIRST - 13);
        static long TBN_DRAGOUT = (TBN_FIRST - 14);
        static long TBN_DELETINGBUTTON = (TBN_FIRST - 15);
        static long TBN_GETDISPINFOA = (TBN_FIRST - 16);
        static long TBN_GETDISPINFOW = (TBN_FIRST - 17);
        static long TBN_GETINFOTIPA = (TBN_FIRST - 18);
        static long TBN_GETINFOTIPW = (TBN_FIRST - 19);
        static long TBN_GETBUTTONINFOW = (TBN_FIRST - 20);
        static long TBN_RESTORE = (TBN_FIRST - 21);
        static long TBN_SAVE = (TBN_FIRST - 22);
        static long TBN_INITCUSTOMIZE = (TBN_FIRST - 23);
        static long TBN_WRAPHOTITEM = (TBN_FIRST - 24);
        static long TBN_DUPACCELERATOR = (TBN_FIRST - 25);
        static long TBN_WRAPACCELERATOR = (TBN_FIRST - 26);
        static long TBN_DRAGOVER = (TBN_FIRST - 27);
        static long TBN_MAPACCELERATOR = (TBN_FIRST - 28);
        static long TBN_GETINFOTIP = TBN_GETINFOTIPW;
        static long TBN_GETDISPINFO = TBN_GETDISPINFOW;

        static long TBNF_IMAGE = 0x00000001;
        static long TBNF_TEXT = 0x00000002;
        static long TBNF_DI_SETITEM = 0x10000000;

        static long TVSBF_XBORDER = 0x00000001;
        static long TVSBF_YBORDER = 0x00000002;

        static long TBDDRET_DEFAULT = 0;
        static long TBDDRET_NODEFAULT = 1;
        static long TBDDRET_TREATPRESSED = 2;

        static long RBIM_IMAGELIST = 0x00000001;

        static long RBS_TOOLTIPS = 0x00000100;
        static long RBS_VARHEIGHT = 0x00000200;
        static long RBS_BANDBORDERS = 0x00000400;
        static long RBS_FIXEDORDER = 0x00000800;
        static long RBS_REGISTERDROP = 0x00001000;
        static long RBS_AUTOSIZE = 0x00002000;
        static long RBS_VERTICALGRIPPER = 0x00004000;
        static long RBS_DBLCLKTOGGLE = 0x00008000;

        static long RBBS_BREAK = 0x00000001;
        static long RBBS_FIXEDSIZE = 0x00000002;
        static long RBBS_CHILDEDGE = 0x00000004;
        static long RBBS_HIDDEN = 0x00000008;
        static long RBBS_NOVERT = 0x00000010;
        static long RBBS_FIXEDBMP = 0x00000020;
        static long RBBS_VARIABLEHEIGHT = 0x00000040;
        static long RBBS_GRIPPERALWAYS = 0x00000080;
        static long RBBS_NOGRIPPER = 0x00000100;
        static long RBBS_USECHEVRON = 0x00000200;
        static long RBBS_HIDETITLE = 0x00000400;
        static long RBBS_TOPALIGN = 0x00000800;

        static long RBBIM_STYLE = 0x00000001;
        static long RBBIM_COLORS = 0x00000002;
        static long RBBIM_TEXT = 0x00000004;
        static long RBBIM_IMAGE = 0x00000008;
        static long RBBIM_CHILD = 0x00000010;
        static long RBBIM_CHILDSIZE = 0x00000020;
        static long RBBIM_SIZE = 0x00000040;
        static long RBBIM_BACKGROUND = 0x00000080;
        static long RBBIM_ID = 0x00000100;
        static long RBBIM_IDEALSIZE = 0x00000200;
        static long RBBIM_LPARAM = 0x00000400;
        static long RBBIM_HEADERSIZE = 0x00000800;
        static long RBBIM_CHEVRONLOCATION = 0x00001000;
        static long RBBIM_CHEVRONSTATE = 0x00002000;

        static long RBN_HEIGHTCHANGE = (RBN_FIRST - 0);
        static long RBN_GETOBJECT = (RBN_FIRST - 1);
        static long RBN_LAYOUTCHANGED = (RBN_FIRST - 2);
        static long RBN_AUTOSIZE = (RBN_FIRST - 3);
        static long RBN_BEGINDRAG = (RBN_FIRST - 4);
        static long RBN_ENDDRAG = (RBN_FIRST - 5);
        static long RBN_DELETINGBAND = (RBN_FIRST - 6);
        static long RBN_DELETEDBAND = (RBN_FIRST - 7);
        static long RBN_CHILDSIZE = (RBN_FIRST - 8);
        static long RBN_CHEVRONPUSHED = (RBN_FIRST - 10);
        static long RBN_SPLITTERDRAG = (RBN_FIRST - 11);
        static long RBN_MINMAX = (RBN_FIRST - 21);
        static long RBN_AUTOBREAK = (RBN_FIRST - 22);

        static long RBNM_ID = 0x00000001;
        static long RBNM_STYLE = 0x00000002;
        static long RBNM_LPARAM = 0x00000004;
        static long RBAB_AUTOSIZE = 0x0001;
        static long RBAB_ADDBAND = 0x0002;
        static long RBHT_NOWHERE = 0x0001;
        static long RBHT_CAPTION = 0x0002;
        static long RBHT_CLIENT = 0x0003;
        static long RBHT_GRABBER = 0x0004;
        static long RBHT_CHEVRON = 0x0008;
        static long RBHT_SPLITTER = 0x0010;

        static long TTS_ALWAYSTIP = 0x01;
        static long TTS_NOPREFIX = 0x02;
        static long TTS_NOANIMATE = 0x10;
        static long TTS_NOFADE = 0x20;
        static long TTS_BALLOON = 0x40;
        static long TTS_CLOSE = 0x80;
        static long TTS_USEVISUALSTYLE = 0x100;

        static long TTF_IDISHWND = 0x0001;
        static long TTF_CENTERTIP = 0x0002;
        static long TTF_RTLREADING = 0x0004;
        static long TTF_SUBCLASS = 0x0010;
        static long TTF_TRACK = 0x0020;
        static long TTF_ABSOLUTE = 0x0080;
        static long TTF_TRANSPARENT = 0x0100;
        static long TTF_PARSELINKS = 0x1000;
        static long TTF_DI_SETITEM = 0x8000;

        static long TTDT_AUTOMATIC = 0;
        static long TTDT_RESHOW = 1;
        static long TTDT_AUTOPOP = 2;
        static long TTDT_INITIAL = 3;

        static long TTI_NONE = 0;
        static long TTI_INFO = 1;
        static long TTI_WARNING = 2;
        static long TTI_ERROR = 3;
        static long TTI_INFO_LARGE = 4;
        static long TTI_WARNING_LARGE = 5;
        static long TTI_ERROR_LARGE = 6;

        static long TTN_GETDISPINFOA = (TTN_FIRST - 0);
        static long TTN_GETDISPINFOW = (TTN_FIRST - 10);
        static long TTN_SHOW = (TTN_FIRST - 1);
        static long TTN_POP = (TTN_FIRST - 2);
        static long TTN_LINKCLICK = (TTN_FIRST - 3);

        static long SBARS_SIZEGRIP = 0x0100;
        static long SBARS_TOOLTIPS = 0x0800;
        static long SBT_TOOLTIPS = 0x0800;

        static long TBTS_TOP = 0;
        static long TBTS_LEFT = 1;
        static long TBTS_BOTTOM = 2;
        static long TBTS_RIGHT = 3;

        static long TB_LINEUP = 0;
        static long TB_LINEDOWN = 1;
        static long TB_PAGEUP = 2;
        static long TB_PAGEDOWN = 3;
        static long TB_THUMBPOSITION = 4;
        static long TB_THUMBTRACK = 5;
        static long TB_TOP = 6;
        static long TB_BOTTOM = 7;
        static long TB_ENDTRACK = 8;

        static long TBCD_TICS = 0x0001;
        static long TBCD_THUMB = 0x0002;
        static long TBCD_CHANNEL = 0x0003;

        static long TRBN_THUMBPOSCHANGING = (TRBN_FIRST - 1);

        static long DL_BEGINDRAG = (WM_USER + 133);
        static long DL_DRAGGING = (WM_USER + 134);
        static long DL_DROPPED = (WM_USER + 135);
        static long DL_CANCELDRAG = (WM_USER + 136);
        static long DL_CURSORSET = 0;
        static long DL_STOPCURSOR = 1;
        static long DL_COPYCURSOR = 2;
        static long DL_MOVECURSOR = 3;

        static string WC_HEADER = "SysHeader";
        static string TOOLBARCLASSNAME = "ToolbarWindow";
        static string REBARCLASSNAME = "ReBarWindow";
        static string TOOLTIPS_CLASS = "tooltips_class";
        static string STATUSCLASSNAME = "msctls_statusbar32";
        static string TRACKBAR_CLASS = "msctls_trackbar32";
        static string DRAGLISTMSGSTRING = "commctrl_DragListMsg";
        static string UPDOWN_CLASS = "msctls_updown32";
        static string PROGRESS_CLASS = "msctls_progress32";
        static string HOTKEY_CLASS = "msctls_hotkey32";
        static string WC_LISTVIEW = "SysListView";
        static string WC_TREEVIEW = "SysTreeView";
        static string WC_COMBOBOXEX = "ComboBoxEx32";
        static string WC_TABCONTROL = "SysTabControl";
        static string ANIMATE_CLASS = "SysAnimate32";
        static string MONTHCAL_CLASS = "SysMonthCal32";
        static string DATETIMEPICK_CLASS = "SysDateTimePick32";
        static string WC_IPADDRESS = "SysIPAddress32";
        static string WC_PAGESCROLLER = "SysPager";
        static string WC_NATIVEFONTCTL = "NativeFontCtl";
        static string WC_BUTTON = "Button";
        static string WC_STATIC = "Static";
        static string WC_EDIT = "Edit";
        static string WC_LISTBOX = "ListBox";
        static string WC_COMBOBOX = "ComboBox";
        static string WC_SCROLLBAR = "ScrollBar";

        static long UD_MAXVAL = 0x7fff;
        static long UD_MINVAL = (-UD_MAXVAL);
        static long UDS_WRAP = 0x0001;
        static long UDS_SETBUDDYINT = 0x0002;
        static long UDS_ALIGNRIGHT = 0x0004;
        static long UDS_ALIGNLEFT = 0x0008;
        static long UDS_AUTOBUDDY = 0x0010;
        static long UDS_ARROWKEYS = 0x0020;
        static long UDS_HORZ = 0x0040;
        static long UDS_NOTHOUSANDS = 0x0080;
        static long UDS_HOTTRACK = 0x0100;
        static long UDN_DELTAPOS = (UDN_FIRST - 1);

        static long PBS_SMOOTH = 0x01;
        static long PBS_VERTICAL = 0x04;
        static long PBS_MARQUEE = 0x08;
        static long PBS_SMOOTHREVERSE = 0x10;

        static long PBST_NORMAL = 0x0001;
        static long PBST_ERROR = 0x0002;
        static long PBST_PAUSED = 0x0003;
        static long HOTKEYF_SHIFT = 0x01;
        static long HOTKEYF_CONTROL = 0x02;
        static long HOTKEYF_ALT = 0x04;
        static long HOTKEYF_EXT = 0x80;
        static long HKCOMB_NONE = 0x0001;
        static long HKCOMB_S = 0x0002;
        static long HKCOMB_C = 0x0004;
        static long HKCOMB_A = 0x0008;
        static long HKCOMB_SC = 0x0010;
        static long HKCOMB_SA = 0x0020;
        static long HKCOMB_CA = 0x0040;
        static long HKCOMB_SCA = 0x0080;
        static long HKM_SETHOTKEY = (WM_USER + 1);
        static long HKM_GETHOTKEY = (WM_USER + 2);
        static long HKM_SETRULES = (WM_USER + 3);

        static long CCS_TOP = 0x00000001L;
        static long CCS_NOMOVEY = 0x00000002L;
        static long CCS_BOTTOM = 0x00000003L;
        static long CCS_NORESIZE = 0x00000004L;
        static long CCS_NOPARENTALIGN = 0x00000008L;
        static long CCS_ADJUSTABLE = 0x00000020L;
        static long CCS_NODIVIDER = 0x00000040L;
        static long CCS_VERT = 0x00000080L;
        static long CCS_LEFT = (CCS_VERT | CCS_TOP);
        static long CCS_RIGHT = (CCS_VERT | CCS_BOTTOM);
        static long CCS_NOMOVEX = (CCS_VERT | CCS_NOMOVEY);

        static long INVALID_LINK_INDEX = (-1);
        static long MAX_LINKID_TEXT = 48;
        static long LWS_TRANSPARENT = 0x0001;
        static long LWS_IGNORERETURN = 0x0002;
        static long LWS_NOPREFIX = 0x0004;
        static long LWS_USEVISUALSTYLE = 0x0008;
        static long LWS_USECUSTOMTEXT = 0x0010;
        static long LWS_RIGHT = 0x0020;
        static long LIF_ITEMINDEX = 0x00000001;
        static long LIF_STATE = 0x00000002;
        static long LIF_ITEMID = 0x00000004;
        static long LIF_URL = 0x00000008;
        static long LIS_FOCUSED = 0x00000001;
        static long LIS_ENABLED = 0x00000002;
        static long LIS_VISITED = 0x00000004;
        static long LIS_HOTTRACK = 0x00000008;
        static long LIS_DEFAULTCOLORS = 0x00000010;

        static long LVSIL_NORMAL = 0;
        static long LVSIL_SMALL = 1;
        static long LVSIL_STATE = 2;
        static long LVSIL_GROUPHEADER = 3;

        static long LVIF_TEXT = 0x00000001;
        static long LVIF_IMAGE = 0x00000002;
        static long LVIF_PARAM = 0x00000004;
        static long LVIF_STATE = 0x00000008;
        static long LVIF_INDENT = 0x00000010;
        static long LVIF_NORECOMPUTE = 0x00000800;
        static long LVIF_GROUPID = 0x00000100;
        static long LVIF_COLUMNS = 0x00000200;
        static long LVIF_COLFMT = 0x00010000;

        static long LV_MAX_WORKAREAS = 16;
        static long LVNI_ALL = 0x0000;
        static long LVNI_FOCUSED = 0x0001;
        static long LVNI_SELECTED = 0x0002;
        static long LVNI_CUT = 0x0004;
        static long LVNI_DROPHILITED = 0x0008;
        static long LVNI_STATEMASK = (LVNI_FOCUSED | LVNI_SELECTED | LVNI_CUT | LVNI_DROPHILITED);
        static long LVNI_VISIBLEORDER = 0x0010;
        static long LVNI_PREVIOUS = 0x0020;
        static long LVNI_VISIBLEONLY = 0x0040;
        static long LVNI_SAMEGROUPONLY = 0x0080;
        static long LVNI_ABOVE = 0x0100;
        static long LVNI_BELOW = 0x0200;
        static long LVNI_TOLEFT = 0x0400;
        static long LVNI_TORIGHT = 0x0800;
        static long LVNI_DIRECTIONMASK = (LVNI_ABOVE | LVNI_BELOW | LVNI_TOLEFT | LVNI_TORIGHT);
        static long LVFI_PARAM = 0x0001;
        static long LVFI_STRING = 0x0002;
        static long LVFI_SUBSTRING = 0x0004;
        static long LVFI_PARTIAL = 0x0008;
        static long LVFI_WRAP = 0x0020;
        static long LVFI_NEARESTXY = 0x0040;
        static long LVIR_BOUNDS = 0;
        static long LVIR_ICON = 1;
        static long LVIR_LABEL = 2;
        static long LVIR_SELECTBOUNDS = 3;
        static long LVHT_NOWHERE = 0x00000001;
        static long LVHT_ONITEMICON = 0x00000002;
        static long LVHT_ONITEMLABEL = 0x00000004;
        static long LVHT_ONITEMSTATEICON = 0x00000008;
        static long LVHT_ONITEM = (LVHT_ONITEMICON | LVHT_ONITEMLABEL | LVHT_ONITEMSTATEICON);
        static long LVHT_ABOVE = 0x00000008;
        static long LVHT_BELOW = 0x00000010;
        static long LVHT_TORIGHT = 0x00000020;
        static long LVHT_TOLEFT = 0x00000040;
        static long LVHT_EX_GROUP_HEADER = 0x10000000;
        static long LVHT_EX_GROUP_FOOTER = 0x20000000;
        static long LVHT_EX_GROUP_COLLAPSE = 0x40000000;
        static long LVHT_EX_GROUP_BACKGROUND = 0x80000000;
        static long LVHT_EX_GROUP_STATEICON = 0x01000000;
        static long LVHT_EX_GROUP_SUBSETLINK = 0x02000000;
        static long LVHT_EX_GROUP = (LVHT_EX_GROUP_BACKGROUND | LVHT_EX_GROUP_COLLAPSE | LVHT_EX_GROUP_FOOTER | LVHT_EX_GROUP_HEADER | LVHT_EX_GROUP_STATEICON | LVHT_EX_GROUP_SUBSETLINK);
        static long LVHT_EX_ONCONTENTS = 0x04000000;
        static long LVHT_EX_FOOTER = 0x08000000;
        static long LVHT_RIGHT = 0x0020;
        static long LVHT_LEFT = 0x0040;
        static long LVSICF_NOINVALIDATEALL = 0x00000001;
        static long LVSICF_NOSCROLL = 0x00000002;
        static long LVA_DEFAULT = 0x0000;
        static long LVA_ALIGNLEFT = 0x0001;
        static long LVA_ALIGNTOP = 0x0002;
        static long LVA_SNAPTOGRID = 0x0005;
        static long LVCF_FMT = 0x0001;
        static long LVCF_WIDTH = 0x0002;
        static long LVCF_TEXT = 0x0004;
        static long LVCF_SUBITEM = 0x0008;
        static long LVCF_IMAGE = 0x0010;
        static long LVCF_ORDER = 0x0020;
        static long LVCF_MINWIDTH = 0x0040;
        static long LVCF_DEFAULTWIDTH = 0x0080;
        static long LVCF_IDEALWIDTH = 0x0100;
        static long LVCFMT_LEFT = 0x0000;
        static long LVCFMT_RIGHT = 0x0001;
        static long LVCFMT_CENTER = 0x0002;
        static long LVCFMT_JUSTIFYMASK = 0x0003;
        static long LVCFMT_IMAGE = 0x0800;
        static long LVCFMT_BITMAP_ON_RIGHT = 0x1000;
        static long LVCFMT_COL_HAS_IMAGES = 0x8000;
        static long LVCFMT_FIXED_WIDTH = 0x00100;
        static long LVCFMT_NO_DPI_SCALE = 0x40000;
        static long LVCFMT_FIXED_RATIO = 0x80000;
        static long LVCFMT_LINE_BREAK = 0x100000;
        static long LVCFMT_FILL = 0x200000;
        static long LVCFMT_WRAP = 0x400000;
        static long LVCFMT_NO_TITLE = 0x800000;
        static long LVCFMT_TILE_PLACEMENTMASK = (LVCFMT_LINE_BREAK | LVCFMT_FILL);
        static long LVCFMT_SPLITBUTTON = 0x1000000;
        static long LVSCW_AUTOSIZE = -1;
        static long LVSCW_AUTOSIZE_USEHEADER = -2;

        static long LVBKIF_SOURCE_NONE = 0x00000000;
        static long LVBKIF_SOURCE_HBITMAP = 0x00000001;
        static long LVBKIF_SOURCE_URL = 0x00000002;
        static long LVBKIF_SOURCE_MASK = 0x00000003;
        static long LVBKIF_STYLE_NORMAL = 0x00000000;
        static long LVBKIF_STYLE_TILE = 0x00000010;
        static long LVBKIF_STYLE_MASK = 0x00000010;
        static long LVBKIF_FLAG_TILEOFFSET = 0x00000100;
        static long LVBKIF_TYPE_WATERMARK = 0x10000000;
        static long LVBKIF_FLAG_ALPHABLEND = 0x20000000;

        static long LV_VIEW_ICON = 0x0000;
        static long LV_VIEW_DETAILS = 0x0001;
        static long LV_VIEW_SMALLICON = 0x0002;
        static long LV_VIEW_LIST = 0x0003;
        static long LV_VIEW_TILE = 0x0004;
        static long LV_VIEW_MAX = 0x0004;

        static long LVGF_NONE = 0x00000000;
        static long LVGF_HEADER = 0x00000001;
        static long LVGF_FOOTER = 0x00000002;
        static long LVGF_STATE = 0x00000004;
        static long LVGF_ALIGN = 0x00000008;
        static long LVGF_GROUPID = 0x00000010;
        static long LVGF_SUBTITLE = 0x00000100;
        static long LVGF_TASK = 0x00000200;
        static long LVGF_DESCRIPTIONTOP = 0x00000400;
        static long LVGF_DESCRIPTIONBOTTOM = 0x00000800;
        static long LVGF_TITLEIMAGE = 0x00001000;
        static long LVGF_EXTENDEDIMAGE = 0x00002000;
        static long LVGF_ITEMS = 0x00004000;
        static long LVGF_SUBSET = 0x00008000;
        static long LVGF_SUBSETITEMS = 0x00010000;

        static long LVGS_NORMAL = 0x00000000;
        static long LVGS_COLLAPSED = 0x00000001;
        static long LVGS_HIDDEN = 0x00000002;
        static long LVGS_NOHEADER = 0x00000004;
        static long LVGS_COLLAPSIBLE = 0x00000008;
        static long LVGS_FOCUSED = 0x00000010;
        static long LVGS_SELECTED = 0x00000020;
        static long LVGS_SUBSETED = 0x00000040;
        static long LVGS_SUBSETLINKFOCUSED = 0x00000080;
        static long LVGA_HEADER_LEFT = 0x00000001;
        static long LVGA_HEADER_CENTER = 0x00000002;
        static long LVGA_HEADER_RIGHT = 0x00000004;
        static long LVGA_FOOTER_LEFT = 0x00000008;
        static long LVGA_FOOTER_CENTER = 0x00000010;
        static long LVGA_FOOTER_RIGHT = 0x00000020;
        static long LVGGR_GROUP = 0;
        static long LVGGR_HEADER = 1;
        static long LVGGR_LABEL = 2;
        static long LVGGR_SUBSETLINK = 3;
        static long LVGMF_NONE = 0x00000000;
        static long LVGMF_BORDERSIZE = 0x00000001;
        static long LVGMF_BORDERCOLOR = 0x00000002;
        static long LVGMF_TEXTCOLOR = 0x00000004;

        static long LVTVIF_AUTOSIZE = 0x00000000;
        static long LVTVIF_FIXEDWIDTH = 0x00000001;
        static long LVTVIF_FIXEDHEIGHT = 0x00000002;
        static long LVTVIF_FIXEDSIZE = 0x00000003;
        static long LVTVIF_EXTENDED = 0x00000004;
        static long LVTVIM_TILESIZE = 0x00000001;
        static long LVTVIM_COLUMNS = 0x00000002;
        static long LVTVIM_LABELMARGIN = 0x00000004;
        static long LVIM_AFTER = 0x00000001;
        static long LVFF_ITEMCOUNT = 0x00000001;
        static long LVFIF_TEXT = 0x00000001;
        static long LVFIF_STATE = 0x00000002;
        static long LVFIS_FOCUSED = 0x0001;
        
        static long LVKF_ALT = 0x0001;
        static long LVKF_CONTROL = 0x0002;
        static long LVKF_SHIFT = 0x0004;
        static long LVCDI_ITEM = 0x00000000;
        static long LVCDI_GROUP = 0x00000001;
        static long LVCDI_ITEMSLIST = 0x00000002;
        static long LVCDRF_NOSELECT = 0x00010000;
        static long LVCDRF_NOGROUPFRAME = 0x00020000;

        //-------------
        //Listview
        //-------------
        static long LVN_ITEMCHANGING = (LVN_FIRST - 0);
        static long LVN_ITEMCHANGED = (LVN_FIRST - 1);
        static long LVN_INSERTITEM = (LVN_FIRST - 2);
        static long LVN_DELETEITEM = (LVN_FIRST - 3);
        static long LVN_DELETEALLITEMS = (LVN_FIRST - 4);
        static long LVN_BEGINLABELEDITA = (LVN_FIRST - 5);
        static long LVN_BEGINLABELEDITW = (LVN_FIRST - 75);
        static long LVN_ENDLABELEDITA = (LVN_FIRST - 6);
        static long LVN_ENDLABELEDITW = (LVN_FIRST - 76);
        static long LVN_COLUMNCLICK = (LVN_FIRST - 8);
        static long LVN_BEGINDRAG = (LVN_FIRST - 9);
        static long LVN_BEGINRDRAG = (LVN_FIRST - 11);
        static long LVN_ODCACHEHINT = (LVN_FIRST - 13);
        static long LVN_ODFINDITEMA = (LVN_FIRST - 52);
        static long LVN_ODFINDITEMW = (LVN_FIRST - 79);
        static long LVN_ITEMACTIVATE = (LVN_FIRST - 14);
        static long LVN_ODSTATECHANGED = (LVN_FIRST - 15);
        static long LVN_ODFINDITEM = LVN_ODFINDITEMW;
        static long LVN_HOTTRACK = (LVN_FIRST - 21);
        static long LVN_GETDISPINFOA = (LVN_FIRST - 50);
        static long LVN_SETDISPINFOA = (LVN_FIRST - 51);
        static long LVN_KEYDOWN = (LVN_FIRST - 55);
        static long LVN_MARQUEEBEGIN = (LVN_FIRST - 56);
        static long LVN_GETINFOTIPA = (LVN_FIRST - 57);
        static long LVN_GETINFOTIPW = (LVN_FIRST - 58);
        static long LVN_INCREMENTALSEARCHA = (LVN_FIRST - 62);
        static long LVN_INCREMENTALSEARCHW = (LVN_FIRST - 63);
        static long LVN_COLUMNDROPDOWN = (LVN_FIRST - 64);
        static long LVN_COLUMNOVERFLOWCLICK = (LVN_FIRST - 66);
        static long LVN_GETDISPINFOW = (LVN_FIRST - 77);
        static long LVN_SETDISPINFOW = (LVN_FIRST - 78);
        static long LVN_BEGINSCROLL = (LVN_FIRST - 80);
        static long LVN_ENDSCROLL = (LVN_FIRST - 81);
        static long LVN_LINKCLICK = (LVN_FIRST - 84);
        static long LVN_GETEMPTYMARKUP = (LVN_FIRST - 87);


        static long LVIF_DI_SETITEM = 0x1000;
        static long LVNSCH_DEFAULT = -1;
        static long LVNSCH_ERROR = -2;
        static long LVNSCH_IGNORE = -3;
        static long LVGIT_UNFOLDED = 0x0001;
        static long EMF_CENTERED = 0x00000001;


        static long TVS_HASBUTTONS = 0x0001;
        static long TVS_HASLINES = 0x0002;
        static long TVS_LINESATROOT = 0x0004;
        static long TVS_EDITLABELS = 0x0008;
        static long TVS_DISABLEDRAGDROP = 0x0010;
        static long TVS_SHOWSELALWAYS = 0x0020;
        static long TVS_RTLREADING = 0x0040;
        static long TVS_NOTOOLTIPS = 0x0080;
        static long TVS_CHECKBOXES = 0x0100;
        static long TVS_TRACKSELECT = 0x0200;
        static long TVS_SINGLEEXPAND = 0x0400;
        static long TVS_INFOTIP = 0x0800;
        static long TVS_FULLROWSELECT = 0x1000;
        static long TVS_NOSCROLL = 0x2000;
        static long TVS_NONEVENHEIGHT = 0x4000;
        static long TVS_NOHSCROLL = 0x8000;
        static long TVS_EX_NOSINGLECOLLAPSE = 0x0001;
        static long TVS_EX_MULTISELECT = 0x0002;
        static long TVS_EX_DOUBLEBUFFER = 0x0004;
        static long TVS_EX_NOINDENTSTATE = 0x0008;
        static long TVS_EX_RICHTOOLTIP = 0x0010;
        static long TVS_EX_AUTOHSCROLL = 0x0020;
        static long TVS_EX_FADEINOUTEXPANDOS = 0x0040;
        static long TVS_EX_PARTIALCHECKBOXES = 0x0080;
        static long TVS_EX_EXCLUSIONCHECKBOXES = 0x0100;
        static long TVS_EX_DIMMEDCHECKBOXES = 0x0200;
        static long TVS_EX_DRAWIMAGEASYNC = 0x0400;
        static long TVIF_TEXT = 0x0001;
        static long TVIF_IMAGE = 0x0002;
        static long TVIF_PARAM = 0x0004;
        static long TVIF_STATE = 0x0008;
        static long TVIF_HANDLE = 0x0010;
        static long TVIF_SELECTEDIMAGE = 0x0020;
        static long TVIF_CHILDREN = 0x0040;
        static long TVIF_INTEGRAL = 0x0080;
        static long TVIF_STATEEX = 0x0100;
        static long TVIF_EXPANDEDIMAGE = 0x0200;
        static long TVIS_SELECTED = 0x0002;
        static long TVIS_CUT = 0x0004;
        static long TVIS_DROPHILITED = 0x0008;
        static long TVIS_BOLD = 0x0010;
        static long TVIS_EXPANDED = 0x0020;
        static long TVIS_EXPANDEDONCE = 0x0040;
        static long TVIS_EXPANDPARTIAL = 0x0080;
        static long TVIS_OVERLAYMASK = 0x0F00;
        static long TVIS_STATEIMAGEMASK = 0xF000;
        static long TVIS_USERMASK = 0xF000;
        static long TVIS_EX_FLAT = 0x0001;
        static long TVIS_EX_DISABLED = 0x0002;
        static long TVIS_EX_ALL = 0x0002;
        static long I_CHILDRENCALLBACK = (-1);
        static long I_CHILDRENAUTO = (-2);

        static long TVE_COLLAPSE = 0x0001;
        static long TVE_EXPAND = 0x0002;
        static long TVE_TOGGLE = 0x0003;
        static long TVE_EXPANDPARTIAL = 0x4000;
        static long TVE_COLLAPSERESET = 0x8000;

        static long TVSIL_NORMAL = 0;
        static long TVSIL_STATE = 2;
        static long TVGN_ROOT = 0x0000;
        static long TVGN_NEXT = 0x0001;
        static long TVGN_PREVIOUS = 0x0002;
        static long TVGN_PARENT = 0x0003;
        static long TVGN_CHILD = 0x0004;
        static long TVGN_FIRSTVISIBLE = 0x0005;
        static long TVGN_NEXTVISIBLE = 0x0006;
        static long TVGN_PREVIOUSVISIBLE = 0x0007;
        static long TVGN_DROPHILITE = 0x0008;
        static long TVGN_CARET = 0x0009;
        static long TVGN_LASTVISIBLE = 0x000A;
        static long TVGN_NEXTSELECTED = 0x000B;
        static long TVSI_NOSINGLEEXPAND = 0x8000;
        static long TVHT_NOWHERE = 0x0001;
        static long TVHT_ONITEMICON = 0x0002;
        static long TVHT_ONITEMLABEL = 0x0004;
        static long TVHT_ONITEM = (TVHT_ONITEMICON | TVHT_ONITEMLABEL | TVHT_ONITEMSTATEICON);
        static long TVHT_ONITEMINDENT = 0x0008;
        static long TVHT_ONITEMBUTTON = 0x0010;
        static long TVHT_ONITEMRIGHT = 0x0020;
        static long TVHT_ONITEMSTATEICON = 0x0040;
        static long TVHT_ABOVE = 0x0100;
        static long TVHT_BELOW = 0x0200;
        static long TVHT_TORIGHT = 0x0400;
        static long TVHT_TOLEFT = 0x0800;

        static long TVN_SELCHANGINGA = (TVN_FIRST - 1);
        static long TVN_SELCHANGINGW = (TVN_FIRST - 50);
        static long TVN_SELCHANGEDA = (TVN_FIRST - 2);
        static long TVN_SELCHANGEDW = (TVN_FIRST - 51);
        static long TVC_UNKNOWN = 0x0000;
        static long TVC_BYMOUSE = 0x0001;
        static long TVC_BYKEYBOARD = 0x0002;
        static long TVN_GETDISPINFOA = (TVN_FIRST - 3);
        static long TVN_GETDISPINFOW = (TVN_FIRST - 52);
        static long TVN_SETDISPINFOA = (TVN_FIRST - 4);
        static long TVN_SETDISPINFOW = (TVN_FIRST - 53);
        static long TVIF_DI_SETITEM = 0x1000;
        static long TVN_ITEMEXPANDINGA = (TVN_FIRST - 5);
        static long TVN_ITEMEXPANDINGW = (TVN_FIRST - 54);
        static long TVN_ITEMEXPANDEDA = (TVN_FIRST - 6);
        static long TVN_ITEMEXPANDEDW = (TVN_FIRST - 55);
        static long TVN_BEGINDRAGA = (TVN_FIRST - 7);
        static long TVN_BEGINDRAGW = (TVN_FIRST - 56);
        static long TVN_BEGINRDRAGA = (TVN_FIRST - 8);
        static long TVN_BEGINRDRAGW = (TVN_FIRST - 57);
        static long TVN_DELETEITEMA = (TVN_FIRST - 9);
        static long TVN_DELETEITEMW = (TVN_FIRST - 58);
        static long TVN_BEGINLABELEDITA = (TVN_FIRST - 10);
        static long TVN_BEGINLABELEDITW = (TVN_FIRST - 59);
        static long TVN_ENDLABELEDITA = (TVN_FIRST - 11);
        static long TVN_ENDLABELEDITW = (TVN_FIRST - 60);
        static long TVN_KEYDOWN = (TVN_FIRST - 12);
        static long TVN_GETINFOTIPA = (TVN_FIRST - 13);
        static long TVN_GETINFOTIPW = (TVN_FIRST - 14);
        static long TVN_SINGLEEXPAND = (TVN_FIRST - 15);
        static long TVN_ITEMCHANGINGA = (TVN_FIRST - 16);
        static long TVN_ITEMCHANGINGW = (TVN_FIRST - 17);
        static long TVN_ITEMCHANGEDA = (TVN_FIRST - 18);
        static long TVN_ITEMCHANGEDW = (TVN_FIRST - 19);
        static long TVN_ASYNCDRAW = (TVN_FIRST - 20);
        static long TVNRET_DEFAULT = 0;
        static long TVNRET_SKIPOLD = 1;
        static long TVNRET_SKIPNEW = 2;
        static long TVN_SELCHANGING = TVN_SELCHANGINGW;
        static long TVN_SELCHANGED = TVN_SELCHANGEDW;
        static long TVN_GETDISPINFO = TVN_GETDISPINFOW;
        static long TVN_SETDISPINFO = TVN_SETDISPINFOW;
        static long TVN_ITEMEXPANDING = TVN_ITEMEXPANDINGW;
        static long TVN_ITEMEXPANDED = TVN_ITEMEXPANDEDW;
        static long TVN_BEGINDRAG = TVN_BEGINDRAGW;
        static long TVN_BEGINRDRAG = TVN_BEGINRDRAGW;
        static long TVN_DELETEITEM = TVN_DELETEITEMW;
        static long TVN_BEGINLABELEDIT = TVN_BEGINLABELEDITW;
        static long TVN_ENDLABELEDIT = TVN_ENDLABELEDITW;
        static long TVN_GETINFOTIP = TVN_GETINFOTIPW;
        static long TVCDRF_NOIMAGES = 0x00010000;
        static long TVN_ITEMCHANGING = TVN_ITEMCHANGINGW;
        static long TVN_ITEMCHANGED = TVN_ITEMCHANGEDW;

        static long CBEIF_TEXT = 0x00000001;
        static long CBEIF_IMAGE = 0x00000002;
        static long CBEIF_SELECTEDIMAGE = 0x00000004;
        static long CBEIF_OVERLAY = 0x00000008;
        static long CBEIF_INDENT = 0x00000010;
        static long CBEIF_LPARAM = 0x00000020;
        static long CBEIF_DI_SETITEM = 0x10000000;
        static long CBEM_INSERTITEMA = (WM_USER + 1);
        static long CBEM_SETIMAGELIST = (WM_USER + 2);
        static long CBEM_GETIMAGELIST = (WM_USER + 3);
        static long CBEM_GETITEMA = (WM_USER + 4);
        static long CBEM_SETITEMA = (WM_USER + 5);
        static long CBEM_GETCOMBOCONTROL = (WM_USER + 6);
        static long CBEM_GETEDITCONTROL = (WM_USER + 7);
        static long CBEM_SETEXSTYLE = (WM_USER + 8);
        static long CBEM_SETEXTENDEDSTYLE = (WM_USER + 14);
        static long CBEM_GETEXSTYLE = (WM_USER + 9);
        static long CBEM_GETEXTENDEDSTYLE = (WM_USER + 9);
        static long CBEM_SETUNICODEFORMAT = CCM_SETUNICODEFORMAT;
        static long CBEM_GETUNICODEFORMAT = CCM_GETUNICODEFORMAT;
        static long CBEM_HASEDITCHANGED = (WM_USER + 10);
        static long CBEM_INSERTITEMW = (WM_USER + 11);
        static long CBEM_SETITEMW = (WM_USER + 12);
        static long CBEM_GETITEMW = (WM_USER + 13);
        static long CBEM_SETWINDOWTHEME = CCM_SETWINDOWTHEME;
        static long CBES_EX_NOEDITIMAGE = 0x00000001;
        static long CBES_EX_NOEDITIMAGEINDENT = 0x00000002;
        static long CBES_EX_PATHWORDBREAKPROC = 0x00000004;
        static long CBES_EX_NOSIZELIMIT = 0x00000008;
        static long CBES_EX_CASESENSITIVE = 0x00000010;
        static long CBES_EX_TEXTENDELLIPSIS = 0x00000020;
        static long CBEN_GETDISPINFOA = (CBEN_FIRST - 0);
        static long CBEN_INSERTITEM = (CBEN_FIRST - 1);
        static long CBEN_DELETEITEM = (CBEN_FIRST - 2);
        static long CBEN_BEGINEDIT = (CBEN_FIRST - 4);
        static long CBEN_ENDEDITA = (CBEN_FIRST - 5);
        static long CBEN_ENDEDITW = (CBEN_FIRST - 6);
        static long CBEN_GETDISPINFOW = (CBEN_FIRST - 7);
        static long CBEN_DRAGBEGINA = (CBEN_FIRST - 8);
        static long CBEN_DRAGBEGINW = (CBEN_FIRST - 9);
        static long CBEN_DRAGBEGIN = CBEN_DRAGBEGINA;
        static long CBEN_ENDEDIT = CBEN_ENDEDITA;
        static long CBENF_KILLFOCUS = 1;
        static long CBENF_RETURN = 2;
        static long CBENF_ESCAPE = 3;
        static long CBENF_DROPDOWN = 4;
        static long CBEMAXSTRLEN = 260;

        static long TCS_SCROLLOPPOSITE = 0x0001;
        static long TCS_BOTTOM = 0x0002;
        static long TCS_RIGHT = 0x0002;
        static long TCS_MULTISELECT = 0x0004;
        static long TCS_FLATBUTTONS = 0x0008;
        static long TCS_FORCEICONLEFT = 0x0010;
        static long TCS_FORCELABELLEFT = 0x0020;
        static long TCS_HOTTRACK = 0x0040;
        static long TCS_VERTICAL = 0x0080;
        static long TCS_TABS = 0x0000;
        static long TCS_BUTTONS = 0x0100;
        static long TCS_SINGLELINE = 0x0000;
        static long TCS_MULTILINE = 0x0200;
        static long TCS_RIGHTJUSTIFY = 0x0000;
        static long TCS_FIXEDWIDTH = 0x0400;
        static long TCS_RAGGEDRIGHT = 0x0800;
        static long TCS_FOCUSONBUTTONDOWN = 0x1000;
        static long TCS_OWNERDRAWFIXED = 0x2000;
        static long TCS_TOOLTIPS = 0x4000;
        static long TCS_FOCUSNEVER = 0x8000;
        static long TCS_EX_FLATSEPARATORS = 0x00000001;
        static long TCS_EX_REGISTERDROP = 0x00000002;

        static long TCIF_TEXT = 0x0001;
        static long TCIF_IMAGE = 0x0002;
        static long TCIF_RTLREADING = 0x0004;
        static long TCIF_PARAM = 0x0008;
        static long TCIF_STATE = 0x0010;
        static long TCIS_BUTTONPRESSED = 0x0001;
        static long TCIS_HIGHLIGHTED = 0x0002;

        static long TCHT_NOWHERE = 0x0001;
        static long TCHT_ONITEMICON = 0x0002;
        static long TCHT_ONITEMLABEL = 0x0004;
        static long TCHT_ONITEM = (TCHT_ONITEMICON | TCHT_ONITEMLABEL);
        static long TCN_KEYDOWN = (TCN_FIRST - 0);
        static long TCN_SELCHANGE = (TCN_FIRST - 1);
        static long TCN_SELCHANGING = (TCN_FIRST - 2);
        static long TCN_GETOBJECT = (TCN_FIRST - 3);
        static long TCN_FOCUSCHANGE = (TCN_FIRST - 4);


        static long ACS_CENTER = 0x0001;
        static long ACS_TRANSPARENT = 0x0002;
        static long ACS_AUTOPLAY = 0x0004;
        static long ACS_TIMER = 0x0008;
        static long ACM_OPENA = (WM_USER + 100);
        static long ACM_PLAY = (WM_USER + 101);
        static long ACM_STOP = (WM_USER + 102);
        static long ACM_OPENW = (WM_USER + 103);
        static long ACM_ISPLAYING = (WM_USER + 104);
        static long ACN_START = 1;
        static long ACN_STOP = 2;
        static long MCSC_BACKGROUND = 0;
        static long MCSC_TEXT = 1;
        static long MCSC_TITLEBK = 2;
        static long MCSC_TITLETEXT = 3;
        static long MCSC_MONTHBK = 4;
        static long MCSC_TRAILINGTEXT = 5;


        static long MCHT_TITLE = 0x00010000;
        static long MCHT_CALENDAR = 0x00020000;
        static long MCHT_TODAYLINK = 0x00030000;
        static long MCHT_CALENDARCONTROL = 0x00100000;
        static long MCHT_NEXT = 0x01000000;
        static long MCHT_PREV = 0x02000000;
        static long MCHT_NOWHERE = 0x00000000;
        static long MCHT_TITLEBK = (MCHT_TITLE);
        static long MCHT_TITLEMONTH = (MCHT_TITLE | 0x0001);
        static long MCHT_TITLEYEAR = (MCHT_TITLE | 0x0002);
        static long MCHT_TITLEBTNNEXT = (MCHT_TITLE | MCHT_NEXT | 0x0003);
        static long MCHT_TITLEBTNPREV = (MCHT_TITLE | MCHT_PREV | 0x0003);
        static long MCHT_CALENDARBK = (MCHT_CALENDAR);
        static long MCHT_CALENDARDATE = (MCHT_CALENDAR | 0x0001);
        static long MCHT_CALENDARDATENEXT = (MCHT_CALENDARDATE | MCHT_NEXT);
        static long MCHT_CALENDARDATEPREV = (MCHT_CALENDARDATE | MCHT_PREV);
        static long MCHT_CALENDARDAY = (MCHT_CALENDAR | 0x0002);
        static long MCHT_CALENDARWEEKNUM = (MCHT_CALENDAR | 0x0003);
        static long MCHT_CALENDARDATEMIN = (MCHT_CALENDAR | 0x0004);
        static long MCHT_CALENDARDATEMAX = (MCHT_CALENDAR | 0x0005);

        static long MCMV_MONTH = 0;
        static long MCMV_YEAR = 1;
        static long MCMV_DECADE = 2;
        static long MCMV_CENTURY = 3;
        static long MCMV_MAX = MCMV_CENTURY;

        static long MCGIP_CALENDARCONTROL = 0;
        static long MCGIP_NEXT = 1;
        static long MCGIP_PREV = 2;
        static long MCGIP_FOOTER = 3;
        static long MCGIP_CALENDAR = 4;
        static long MCGIP_CALENDARHEADER = 5;
        static long MCGIP_CALENDARBODY = 6;
        static long MCGIP_CALENDARROW = 7;
        static long MCGIP_CALENDARCELL = 8;

        static long MCGIF_DATE = 0x00000001;
        static long MCGIF_RECT = 0x00000002;
        static long MCGIF_NAME = 0x00000004;

        static long MCN_SELCHANGE = (MCN_FIRST - 3);
        static long MCN_GETDAYSTATE = (MCN_FIRST - 1);
        static long MCN_SELECT = (MCN_FIRST);
        static long MCN_VIEWCHANGE = (MCN_FIRST - 4);

        static long GMR_VISIBLE = 0;
        static long GMR_DAYSTATE = 1;


        static long DTN_DATETIMECHANGE = (DTN_FIRST2 - 6);
        static long DTN_USERSTRINGA = (DTN_FIRST2 - 5);
        static long DTN_USERSTRINGW = (DTN_FIRST - 5);
        static long DTN_WMKEYDOWNA = (DTN_FIRST2 - 4);
        static long DTN_WMKEYDOWNW = (DTN_FIRST - 4);
        static long DTN_FORMATA = (DTN_FIRST2 - 3);
        static long DTN_FORMATW = (DTN_FIRST - 3);
        static long DTN_FORMATQUERYA = (DTN_FIRST2 - 2);
        static long DTN_FORMATQUERYW = (DTN_FIRST - 2);
        static long DTN_DROPDOWN = (DTN_FIRST2 - 1);
        static long DTN_CLOSEUP = (DTN_FIRST2);
        static long GDTR_MIN = 0x0001;
        static long GDTR_MAX = 0x0002;
        static long GDT_ERROR = -1;
        static long GDT_VALID = 0;
        static long GDT_NONE = 1;


        static long PGN_SCROLL = (PGN_FIRST - 1);
        static long PGN_CALCSIZE = (PGN_FIRST - 2);
        static long PGN_HOTITEMCHANGE = (PGN_FIRST - 3);

        static long PGF_SCROLLUP = 1;
        static long PGF_SCROLLDOWN = 2;
        static long PGF_SCROLLLEFT = 4;
        static long PGF_SCROLLRIGHT = 8;
        static long PGF_CALCWIDTH = 1;
        static long PGF_CALCHEIGHT = 2;

        static long PGK_SHIFT = 1;
        static long PGK_CONTROL = 2;
        static long PGK_MENU = 4;

        static long NFS_EDIT = 0x0001;
        static long NFS_STATIC = 0x0002;
        static long NFS_LISTCOMBO = 0x0004;
        static long NFS_BUTTON = 0x0008;
        static long NFS_ALL = 0x0010;
        static long NFS_USEFONTASSOC = 0x0020;

        static long BUTTON_IMAGELIST_ALIGN_LEFT = 0;
        static long BUTTON_IMAGELIST_ALIGN_RIGHT = 1;
        static long BUTTON_IMAGELIST_ALIGN_TOP = 2;
        static long BUTTON_IMAGELIST_ALIGN_BOTTOM = 3;
        static long BUTTON_IMAGELIST_ALIGN_CENTER = 4;

        static long BCM_GETIDEALSIZE = (BCM_FIRST + 0x0001);
        static long BCM_SETIMAGELIST = (BCM_FIRST + 0x0002);
        static long BCM_GETIMAGELIST = (BCM_FIRST + 0x0003);
        static long BCM_SETTEXTMARGIN = (BCM_FIRST + 0x0004);
        static long BCM_GETTEXTMARGIN = (BCM_FIRST + 0x0005);
        static long BCM_SETDROPDOWNSTATE = (BCM_FIRST + 0x0006);
        static long BCM_SETSPLITINFO = (BCM_FIRST + 0x0007);
        static long BCM_GETSPLITINFO = (BCM_FIRST + 0x0008);
        static long BCM_SETNOTE = (BCM_FIRST + 0x0009);
        static long BCM_GETNOTE = (BCM_FIRST + 0x000A);
        static long BCM_GETNOTELENGTH = (BCM_FIRST + 0x000B);
        static long BCM_SETSHIELD = (BCM_FIRST + 0x000C);

        static long BCN_HOTITEMCHANGE = (BCN_FIRST + 0x0001);
        static long BST_HOT = 0x0200;
        static long BST_DROPDOWNPUSHED = 0x0400;
        static long BCSIF_GLYPH = 0x0001;
        static long BCSIF_IMAGE = 0x0002;
        static long BCSIF_STYLE = 0x0004;
        static long BCSIF_SIZE = 0x0008;
        static long BCSS_NOSPLIT = 0x0001;
        static long BCSS_STRETCH = 0x0002;
        static long BCSS_ALIGNLEFT = 0x0004;
        static long BCSS_IMAGE = 0x0008;

        static long BCCL_NOGLYPH = (-1);
        static long BCN_DROPDOWN = (BCN_FIRST + 0x0002);

        static long EM_SETCUEBANNER = (ECM_FIRST + 1);
        static long EM_GETCUEBANNER = (ECM_FIRST + 2);
        static long EM_SHOWBALLOONTIP = (ECM_FIRST + 3);
        static long EM_HIDEBALLOONTIP = (ECM_FIRST + 4);
        static long EM_SETHILITE = (ECM_FIRST + 5);

        static long CB_SETMINVISIBLE = (CBM_FIRST + 1);
        static long CB_GETMINVISIBLE = (CBM_FIRST + 2);
        static long CB_SETCUEBANNER = (CBM_FIRST + 3);
        static long CB_GETCUEBANNER = (CBM_FIRST + 4);

        static long DA_LAST = (0x7FFFFFFF);
        static long DA_ERR = (-1);

        static long DSA_APPEND = DA_LAST;
        static long DSA_ERR = DA_ERR;

        static long DPAM_SORTED = 0x00000001;
        static long DPAM_NORMAL = 0x00000002;
        static long DPAM_UNION = 0x00000004;
        static long DPAM_INTERSECT = 0x00000008;

        static long DPAMM_MERGE = 1;
        static long DPAMM_DELETE = 2;
        static long DPAMM_INSERT = 3;

        static long DPAS_SORTED = 0x0001;
        static long DPAS_INSERTBEFORE = 0x0002;
        static long DPAS_INSERTAFTER = 0x0004;

        static long DPA_APPEND = DA_LAST;
        static long DPA_ERR = DA_ERR;

        static long WM_MOUSEHOVER = 0x02A1;
        static long WM_MOUSELEAVE = 0x02A3;

        static long TME_HOVER = 0x00000001;
        static long TME_LEAVE = 0x00000002;
        static long TME_NONCLIENT = 0x00000010;
        static long TME_QUERY = 0x40000000;
        static long TME_CANCEL = 0x80000000;

        static long HOVER_DEFAULT = 0xFFFFFFFF;

        static long WSB_PROP_CYVSCROLL = 0x00000001L;
        static long WSB_PROP_CXHSCROLL = 0x00000002L;
        static long WSB_PROP_CYHSCROLL = 0x00000004L;
        static long WSB_PROP_CXVSCROLL = 0x00000008L;
        static long WSB_PROP_CXHTHUMB = 0x00000010L;
        static long WSB_PROP_CYVTHUMB = 0x00000020L;
        static long WSB_PROP_VBKGCOLOR = 0x00000040L;
        static long WSB_PROP_HBKGCOLOR = 0x00000080L;
        static long WSB_PROP_VSTYLE = 0x00000100L;
        static long WSB_PROP_HSTYLE = 0x00000200L;
        static long WSB_PROP_WINSTYLE = 0x00000400L;
        static long WSB_PROP_PALETTE = 0x00000800L;
        static long WSB_PROP_MASK = 0x00000FFFL;

        static long FSB_FLAT_MODE = 2;
        static long FSB_ENCARTA_MODE = 1;
        static long FSB_REGULAR_MODE = 0;

        //static long INVALID_HANDLE_VALUE = HANDLE(-1); //prior to 1.1 it was 0, see for example FileOpen

        static long MAXBYTE = 0xFF;
        static long MAXWORD = 0xFFFF;
        static long MAXDWORD = 0xFFFFFFFF;

        static long MINCHAR = 0x80;
        static long MAXCHAR = 0x7F;
        static long MINSHORT = 0x8000;
        static long MAXSHORT = 0x7FFF;
        static long MINLONG = 0x80000000;
        static long MAXLONG = 0x7FFFFFFF;


        //==============================================
        //Binary raster operations
        //==============================================
        static long R2_BLACK = 1;  // 0   
        static long R2_NOTMERGEPEN = 2;  //DPon 
        static long R2_MASKNOTPEN = 3;  //DPna 
        static long R2_NOTCOPYPEN = 4;  //PN   
        static long R2_MASKPENNOT = 5;  //PDna 
        static long R2_NOT = 6;  //Dn   
        static long R2_XORPEN = 7;  //DPx  
        static long R2_NOTMASKPEN = 8;  //DPan 
        static long R2_MASKPEN = 9;  //DPa  
        static long R2_NOTXORPEN = 10; //DPxn 
        static long R2_NOP = 11; //D    
        static long R2_MERGENOTPEN = 12; //DPno 
        static long R2_COPYPEN = 13; //P    
        static long R2_MERGEPENNOT = 14; //PDno 
        static long R2_MERGEPEN = 15; //DPo  
        static long R2_WHITE = 16; //1    
        static long R2_LAST = 16;

        //==============================================
        //Ternary raster operations
        //==============================================
        static long SRCCOPY = 0x00CC0020;     //dest = source                    
        static long SRCPAINT = 0x00EE0086;     //dest = source OR dest            
        static long SRCAND = 0x008800C6;     //dest = source AND dest           
        static long SRCINVERT = 0x00660046;     //dest = source XOR dest           
        static long SRCERASE = 0x00440328;     //dest = source AND (NOT dest )    
        static long NOTSRCCOPY = 0x00330008;     //dest = (NOT source)              
        static long NOTSRCERASE = 0x001100A6;     //dest = (NOT src) AND (NOT dest)  
        static long MERGECOPY = 0x00C000CA;     //dest = (source AND pattern)      
        static long MERGEPAINT = 0x00BB0226;     //dest = (NOT source) OR dest      
        static long PATCOPY = 0x00F00021;     //dest = pattern                   
        static long PATPAINT = 0x00FB0A09;     //dest = DPSnoo                    
        static long PATINVERT = 0x005A0049;     //dest = pattern XOR dest          
        static long DSTINVERT = 0x00550009;     //dest = (NOT dest)                
        static long BLACKNESS = 0x00000042;     //dest = BLACK                     
        static long WHITENESS = 0x00FF0062;     //dest = WHITE                     

        static long CS_VREDRAW = 1;
        static long CS_HREDRAW = 2;

        //------------
        //CombineRgn Mode flags
        //------------
        static long RGN_AND = 1;
        static long RGN_OR = 2;
        static long RGN_XOR = 3;
        static long RGN_DIFF = 4;
        static long RGN_COPY = 5;

        //------------
        //DrawText flags
        //------------
        static long DT_TOP = 0x0;
        static long DT_LEFT = 0x0;
        static long DT_CENTER = 0x1;
        static long DT_RIGHT = 0x2;
        static long DT_VCENTER = 0x4;
        static long DT_BOTTOM = 0x8;
        static long DT_WORDBREAK = 0x10;
        static long DT_SINGLELINE = 0x20;
        static long DT_EXPANDTABS = 0x40;
        static long DT_NOCLIP = 0x100;
        static long DT_CALCRECT = 0x400;
        static long DT_NOPREFIX = 0x800;
        static long DT_INTERNAL = 0x1000;
        static long DT_EDITCONTROL = 0x2000;
        static long DT_END_ELLIPSIS = 0x8000;
        static long DT_MODIFYSTRING = 0x10000;
        static long DT_RTLREADING = 0x20000;

        //==============================================
        //Draw frame constants
        //==============================================

        //------------
        //Draw frame control flags
        //------------
        static long DFC_CAPTION = 0x01;
        static long DFC_MENU = 0x02;
        static long DFC_SCROLL = 0x03;
        static long DFC_BUTTON = 0x04;

        //------------
        //Draw frame control Styles
        //------------
        static long DFCS_BUTTONCHECK = 0;
        static long DFCS_BUTTONRADIOIMAGE = 1;
        static long DFCS_BUTTONRADIOMASK = 2;
        static long DFCS_BUTTONRADIO = 4;
        static long DFCS_BUTTON3STATE = 8;
        static long DFCS_BUTTONPUSH = 16;

        static long DFCS_CAPTIONCLOSE = 0;
        static long DFCS_CAPTIONMIN = 1;
        static long DFCS_CAPTIONMAX = 2;
        static long DFCS_CAPTIONRESTORE = 3;
        static long DFCS_CAPTIONHELP = 4;

        static long DFCS_MENUARROW = 0;
        static long DFCS_MENUCHECK = 1;
        static long DFCS_MENUBULLET = 2;

        static long DFCS_SCROLLDOWN = 1;
        static long DFCS_SCROLLLEFT = 2;
        static long DFCS_SCROLLRIGHT = 3;
        static long DFCS_SCROLLCOMBOBOX = 5;
        static long DFCS_SCROLLSIZEGRIP = 8;
        static long DFCS_SCROLLUP = 0;

        static long DFCS_INACTIVE = 256;
        static long DFCS_PUSHED = 512;
        static long DFCS_CHECKED = 1024;
        static long DFCS_TRANSPARENT = 2048;
        static long DFCS_HOT = 4096;
        static long DFCS_ADJUSTRECT = 8192;
        static long DFCS_FLAT = 16384;
        static long DFCS_MONO = 32768;

        static long HTERROR = -2;
        static long HTTRANSPARENT = -1;
        static long HTNOWHERE = 0;
        static long HTCLIENT = 1;
        static long HTCAPTION = 2;



        //PEEKMESSAGE stuff
        static long PM_Noremove = 0;
        static long PM_Remove = 1;

        //TShortCut additions:
        static long scMeta = 0x1000;

        //3D border styles 
        static long BDR_RAISEDOUTER = 1;
        static long BDR_SUNKENOUTER = 2;
        static long BDR_RAISEDINNER = 4;
        static long BDR_SUNKENINNER = 8;

        static long BDR_OUTER = 3;
        static long BDR_INNER = 12;
        static long BDR_RAISED = 5;
        static long BDR_SUNKEN = 10;

        static long EDGE_BUMP = (BDR_RAISEDOUTER | BDR_SUNKENINNER);
        static long EDGE_ETCHED = (BDR_SUNKENOUTER | BDR_RAISEDINNER);
        static long EDGE_RAISED = (BDR_RAISEDOUTER | BDR_RAISEDINNER);
        static long EDGE_SUNKEN = (BDR_SUNKENOUTER | BDR_SUNKENINNER);

        //Border flags 
        static long BF_LEFT = 1;
        static long BF_TOP = 2;
        static long BF_RIGHT = 4;
        static long BF_BOTTOM = 8;

        static long BF_TOPLEFT = (BF_TOP | BF_LEFT);
        static long BF_TOPRIGHT = (BF_TOP | BF_RIGHT);
        static long BF_BOTTOMLEFT = (BF_BOTTOM | BF_LEFT);
        static long BF_BOTTOMRIGHT = (BF_BOTTOM | BF_RIGHT);
        static long BF_RECT = (BF_LEFT | BF_TOP | BF_RIGHT | BF_BOTTOM);
        static long BF_DIAGONAL = 0x10;

        static long BF_DIAGONAL_ENDTOPRIGHT = (BF_DIAGONAL | BF_TOP | BF_RIGHT);
        static long BF_DIAGONAL_ENDTOPLEFT = (BF_DIAGONAL | BF_TOP | BF_LEFT);
        static long BF_DIAGONAL_ENDBOTTOMLEFT = (BF_DIAGONAL | BF_BOTTOM | BF_LEFT);
        static long BF_DIAGONAL_ENDBOTTOMRIGHT = (BF_DIAGONAL | BF_BOTTOM | BF_RIGHT);

        static long BF_MIDDLE = 0x800;   //Fill in the middle 
        static long BF_SOFT = 0x1000;    //For softer buttons.  Not sure what the use is for this 
        static long BF_ADJUST = 0x2000;  //Calculate the space left over 
        static long BF_FLAT = 0x4000;    //For flat rather than 3D borders 
        static long BF_MONO = 0x8000;    //For monochrome borders 

        //Dialog codes
        static long DLGC_WANTARROWS = 0x0001,
        DLGC_WANTTAB = 0x0002,
        DLGC_WANTALLKEYS = 0x0004,
        DLGC_WANTCHARS = 0x0080,
        DLGC_WANTMESSAGE = 0x0004,      /* Pass message to control          */
        DLGC_HASSETSEL = 0x0008;      /* Understands EM_SETSEL message    */

        //ScrollWindowEx
        static long SW_SMOOTHSCROLL = 16;
        static long SW_ERASE = 4;
        static long SW_INVALIDATE = 2;
        static long SW_SCROLLCHILDREN = 1;

        //==============================================
        //owner drawn constants
        //==============================================
        //CtlType
        //winuser.h
        static long ODT_MENU = 1;
        static long ODT_LISTBOX = 2;
        static long ODT_COMBOBOX = 3;
        static long ODT_BUTTON = 4;
        static long ODT_STATIC = 5;
        //commctrl.h
        static long ODT_HEADER = 100;
        static long ODT_TAB = 101;
        static long ODT_LISTVIEW = 102;
        //itemAction
        static long ODA_DRAWENTIRE = 1;
        static long ODA_SELECT = 2;
        static long ODA_FOCUS = 4;
        //itemState
        static long ODS_SELECTED = 0x0001;
        static long ODS_GRAYED = 0x0002;
        static long ODS_DISABLED = 0x0004;
        static long ODS_CHECKED = 0x0008;
        static long ODS_FOCUS = 0x0010;
        static long ODS_DEFAULT = 0x0020;
        static long ODS_HOTLIGHT = 0x0040;
        static long ODS_INACTIVE = 0x0080;
        static long ODS_NOACCEL = 0x0100;
        static long ODS_NOFOCUSRECT = 0x0200;
        static long ODS_COMBOBOXEDIT = 0x1000;

        static long MB_OK = 0x00000000;
        static long MB_OKCANCEL = 0x00000001;
        static long MB_ABORTRETRYIGNORE = 0x00000002;
        static long MB_YESNOCANCEL = 0x00000003;
        static long MB_YESNO = 0x00000004;
        static long MB_RETRYCANCEL = 0x00000005;
        static long MB_CANCELTRYCONTINUE = 0x00000006; //not yet supported by MessageDlg

        static long MB_HELP = 0x00004000; //not yet supported by MessageDlg

        static long MB_ICONHAND = 0x00000010;
        static long MB_ICONQUESTION = 0x00000020;
        static long MB_ICONEXCLAMATION = 0x00000030;
        static long MB_ICONASTERISK = 0x00000040;
        static long MB_ICONWARNING = MB_ICONEXCLAMATION;
        static long MB_ICONERROR = MB_ICONHAND;
        static long MB_ICONSTOP = MB_ICONHAND;
        static long MB_ICONINFORMATION = MB_ICONASTERISK;

        static long IDOK = 1;
        static long ID_OK = IDOK;
        static long IDCANCEL = 2;
        static long ID_CANCEL = IDCANCEL;
        static long IDABORT = 3;
        static long ID_ABORT = IDABORT;
        static long IDRETRY = 4;
        static long ID_RETRY = IDRETRY;
        static long IDIGNORE = 5;
        static long ID_IGNORE = IDIGNORE;
        static long IDYES = 6;
        static long ID_YES = IDYES;
        static long IDNO = 7;
        static long ID_NO = IDNO;
        static long IDCLOSE = 8;
        static long ID_CLOSE = IDCLOSE;
        static long IDHELP = 9;
        static long ID_HELP = IDHELP;

        static long MB_DEFBUTTON1 = 0x00000000;
        static long MB_DEFBUTTON2 = 0x00000100;
        static long MB_DEFBUTTON3 = 0x00000200;
        static long MB_DEFBUTTON4 = 0x00000300;

        //Region Flags
        static long Error = 0;
        static long NullRegion = 1;
        static long SimpleRegion = 2;
        static long ComplexRegion = 3;
        static long Region_Error = Error;

        static long SIF_RANGE = 1;
        static long SIF_PAGE = 2;
        static long SIF_POS = 4;
        static long SIF_DISABLENOSCROLL = 8;
        static long SIF_TRACKPOS = 0x10;
        static long SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS);
        static long SIF_UPDATEPOLICY = 0x100;

        //WMSIZE message constants
        static long SIZE_RESTORED = 0; //the default
        static long SIZE_MINIMIZED = 1;
        static long SIZE_MAXIMIZED = 2;
        static long SIZE_MAXSHOW = 3;
        static long SIZE_MAXHIDE = 4;
        static long SIZE_FULLSCREEN = 16; //non-winapi value to support wsFullScreen state
        static long Size_SourceIsInterface = 128; //this flag can be combined with the above

        static long SIZENORMAL = SIZE_RESTORED;
        static long SIZEICONIC = SIZE_MINIMIZED;
        static long SIZEFULLSCREEN = SIZE_MAXIMIZED;
        static long SIZEZOOMSHOW = SIZE_MAXSHOW;
        static long SIZEZOOMHIDE = SIZE_MAXHIDE;

        //WMMove Message Constants 
        static long Move_Default = 0;
        static long Move_SourceIsInterface = 128; //this flag can be combined with the above

        //Combobox style 
        static long CBS_SIMPLE = 0x0001;
        static long CBS_DROPDOWN = 0x0002;
        static long CBS_DROPDOWNLIST = 0x0003;
        static long CBS_OWNERDRAWFIXED = 0x0010;
        static long CBS_OWNERDRAWVARIABLE = 0x0020;
        static long CBS_AUTOHSCROLL = 0x0040;
        static long CBS_SORT = 0x0100;
        static long CBS_HASSTRINGS = 0x0200;
        static long CBS_NOINTEGRALHEIGHT = 0x0400;

        //==============================================
        //SetWindowPos Flags
        //==============================================
        static long HWND_TOP = 0;
        static long HWND_BOTTOM = 1;
        static long HWND_TOPMOST = -1;
        static long HWND_NOTOPMOST = -2;

        //==============================================
        //ShowWindow() Commands
        //==============================================
        static long SW_HIDE = 0;
        static long SW_SHOWNORMAL = 1;
        static long SW_NORMAL = 1;
        static long SW_SHOWMINIMIZED = 2;
        static long SW_SHOWMAXIMIZED = 3;
        static long SW_MAXIMIZE = 3;
        static long SW_SHOWNOACTIVATE = 4;
        static long SW_SHOW = 5;
        static long SW_MINIMIZE = 6;
        static long SW_SHOWMINNOACTIVE = 7;
        static long SW_SHOWNA = 8;
        static long SW_RESTORE = 9;
        static long SW_SHOWDEFAULT = 10;
        static long SW_MAX = 10;
        static long SW_SHOWFULLSCREEN = 11; //LCL Addition

        //==============================================
        //Redrawindow() flags
        //==============================================
        static long RDW_INVALIDATE = 0x0001;
        static long RDW_INTERNALPAINT = 0x0002;
        static long RDW_ERASE = 0x0004;
        static long RDW_VALIDATE = 0x0008;
        static long RDW_NOINTERNALPAINT = 0x0010;
        static long RDW_NOERASE = 0x0020;
        static long RDW_NOCHILDREN = 0x0040;
        static long RDW_ALLCHILDREN = 0x0080;
        static long RDW_UPDATENOW = 0x0100;
        static long RDW_ERASENOW = 0x0200;
        static long RDW_FRAME = 0x0400;
        static long RDW_NOFRAME = 0x0800;


        //DIB color table identifiers 

        static long DIB_RGB_COLORS = 0;     //color table in RGBs  
        static long DIB_PAL_COLORS = 1;     //color table in palette indices  

        //Gradient Fill Modes 
        static long GRADIENT_FILL_RECT_H = 0;
        static long GRADIENT_FILL_RECT_V = 1;
        static long GRADIENT_FILL_TRIANGLE = 2;

        //monitor support 
        static long MONITOR_UNIMPL = (-1);

        static long MONITOR_DEFAULTTONULL = 0x00000000;
        static long MONITOR_DEFAULTTOPRIMARY = 0x00000001;
        static long MONITOR_DEFAULTTONEAREST = 0x00000002;

        static long MONITORINFOF_PRIMARY = 0x00000001;
        static long CCHDEVICENAME = 32;

        static long RASTER_FONTTYPE = 1;
        static long DEVICE_FONTTYPE = 2;
        static long TRUETYPE_FONTTYPE = 4;

        static long GCP_DBCS = 1;

        //context type
        static long HELPINFO_WINDOW = 0x0001;
        static long HELPINFO_MENUITEM = 0x0002;

        //DoOnHelp commands
        static long HELP_CONTEXT = 1;
        static long HELP_COMMAND = 258;

        //==============================================
        //Background Modes
        //==============================================
        static long TRANSPARENT = 1;
        static long OPAQUE = 2;
        static long BKMODE_LAST = 2;

        //==============================================
        //Font constants
        //==============================================

        //------------
        //Font Styles
        //------------
        static long LF_FULLFACESIZE = 64;
        static long LF_FACESIZE = 32;

        static long OUT_DEFAULT_PRECIS = 0;
        static long OUT_STRING_PRECIS = 1;
        static long OUT_CHARACTER_PRECIS = 2;
        static long OUT_STROKE_PRECIS = 3;
        static long OUT_TT_PRECIS = 4;
        static long OUT_DEVICE_PRECIS = 5;
        static long OUT_RASTER_PRECIS = 6;
        static long OUT_TT_ONLY_PRECIS = 7;
        static long OUT_OUTLINE_PRECIS = 8;
        static long OUT_SCREEN_OUTLINE_PRECIS = 9;

        static long CLIP_DEFAULT_PRECIS = 0;
        static long CLIP_CHARACTER_PRECIS = 1;
        static long CLIP_STROKE_PRECIS = 2;
        static long CLIP_MASK = 15;
        static long CLIP_LH_ANGLES = (1 << 4);
        static long CLIP_TT_ALWAYS = (2 << 4);
        static long CLIP_EMBEDDED = (8 << 4);

        static long DEFAULT_QUALITY = 0;
        static long DRAFT_QUALITY = 1;
        static long PROOF_QUALITY = 2;
        static long NONANTIALIASED_QUALITY = 3;
        static long ANTIALIASED_QUALITY = 4;
        static long CLEARTYPE_QUALITY = 5;
        static long CLEARTYPE_NATURAL_QUALITY = 6;

        static long DEFAULT_PITCH = 0;
        static long FIXED_PITCH = 1;
        static long VARIABLE_PITCH = 2;
        static long MONO_FONT = 8;

        //font character sets
        static long ANSI_CHARSET = 0;
        static long DEFAULT_CHARSET = 1;
        static long SYMBOL_CHARSET = 2;
        //added for ISO_8859_2 under gtk
        static long FCS_ISO_10646_1 = 4;  //Unicode;
        static long FCS_ISO_8859_1 = 5;  // ISO Latin-1 (Western Europe);
        static long FCS_ISO_8859_2 = 6;  // ISO Latin-2 (Eastern Europe);
        static long FCS_ISO_8859_3 = 7;  // ISO Latin-3 (Southern Europe);
        static long FCS_ISO_8859_4 = 8;  // ISO Latin-4 (Northern Europe);
        static long FCS_ISO_8859_5 = 9;  // ISO Cyrillic;
        static long FCS_ISO_8859_6 = 10; // ISO Arabic;
        static long FCS_ISO_8859_7 = 11; // ISO Greek;
        static long FCS_ISO_8859_8 = 12; // ISO Hebrew;
        static long FCS_ISO_8859_9 = 13; // ISO Latin-5 (Turkish);
        static long FCS_ISO_8859_10 = 14; // ISO Latin-6 (Nordic);
        static long FCS_ISO_8859_15 = 15; // ISO Latin-9, or Latin-0 (Revised Western-European);
                  //FCS_koi8_r = 16; // KOI8 Russian;
                  //FCS_koi8_u = 17; // KOI8 Ukrainian (see RFC 2319);
                  //FCS_koi8_ru = 18; // KOI8 Russian/Ukrainian
                  //FCS_koi8_uni = 19; // KOI8 ``Unified'' (Russian, Ukrainian, and Byelorussian);
                  //FCS_koi8_e = 20; // KOI8 ``European,'' ISO-IR-111, or ECMA-Cyrillic;
        //end of our own additions
        static long MAC_CHARSET = 77;
        static long SHIFTJIS_CHARSET = 128;
        static long HANGEUL_CHARSET = 129;
        static long JOHAB_CHARSET = 130;
        static long GB2312_CHARSET = 134;
        static long CHINESEBIG5_CHARSET = 136;
        static long GREEK_CHARSET = 161;
        static long TURKISH_CHARSET = 162;
        static long VIETNAMESE_CHARSET = 163;
        static long HEBREW_CHARSET = 177;
        static long ARABIC_CHARSET = 178;
        static long BALTIC_CHARSET = 186;
        static long RUSSIAN_CHARSET = 204;
        static long THAI_CHARSET = 222;
        static long EASTEUROPE_CHARSET = 238;
        static long OEM_CHARSET = 255;
        //additional charsets

        //-----------
        //Font Sets
        //-----------
        static long FS_LATIN1 = 1;
        static long FS_LATIN2 = 2;
        static long FS_CYRILLIC = 4;
        static long FS_GREEK = 8;
        static long FS_TURKISH = 0x10;
        static long FS_HEBREW = 0x20;
        static long FS_ARABIC = 0x40;
        static long FS_BALTIC = 0x80;
        static long FS_VIETNAMESE = 0x00000100;
        static long FS_THAI = 0x10000;
        static long FS_JISJAPAN = 0x20000;
        static long FS_CHINESESIMP = 0x40000;
        static long FS_WANSUNG = 0x80000;
        static long FS_CHINESETRAD = 0x100000;
        static long FS_JOHAB = 0x200000;
        static long FS_SYMBOL = 0x80000000;

        //---------------
        //Font Families
        //---------------
        static long FF_DONTCARE = (0 << 4);
        static long FF_ROMAN = (1 << 4);
        static long FF_SWISS = (2 << 4);
        static long FF_MODERN = (3 << 4);
        static long FF_SCRIPT = (4 << 4);
        static long FF_DECORATIVE = (5 << 4);

        //--------------
        //XFLD constans
        //--------------
        static long XLFD_FONTNAME_REG = 0;
        static long XLFD_FOUNDRY = 1;
        static long XLFD_FAMILY = 2;
        static long XLFD_WEIGHTNAME = 3;
        static long XLFD_SLANT = 4;
        static long XLFD_WIDTHNAME = 5;
        static long XLFD_STYLENAME = 6;
        static long XLFD_PIXELSIZE = 7;
        static long XLFD_POINTSIZE = 8;
        static long XLFD_RESX = 9;
        static long XLFD_RESY = 10;
        static long XLFD_SPACING = 11;
        static long XLFD_AVG_WIDTH = 12;
        static long XLFD_CHARSET_REG = 13;
        static long XLFD_CHARSET_COD = 14;



        //==============================================
        //Brush constants
        //==============================================

        //--------------
        //Brush Styles
        //--------------

        static long BS_SOLID = 0;
        static long BS_NULL = 1;
        static long BS_HOLLOW = BS_NULL;
        static long BS_HATCHED = 2;
        static long BS_PATTERN = 3;
        static long BS_INDEXED = 4;
        static long BS_DIBPATTERN = 5;
        static long BS_DIBPATTERNPT = 6;
        static long BS_PATTERN8X8 = 7;
        static long BS_DIBPATTERN8X8 = 8;
        static long BS_MONOPATTERN = 9;

        //--------------
        //Hatch Styles
        //--------------

        static long HS_HORIZONTAL = 0;       //----- 
        static long HS_VERTICAL = 1;         //||||| 
        static long HS_FDIAGONAL = 2;        ///////
        static long HS_BDIAGONAL = 3;        //\\\\\ 
        static long HS_CROSS = 4;            //+++++ 
        static long HS_DIAGCROSS = 5;        //xxxxx 

        //==============================================
        //Pen constants
        //==============================================

        //------------
        //Pen Styles
        //------------

        static long PS_SOLID = 0;
        static long PS_DASH = 1;            //------- 
        static long PS_DOT = 2;             //....... 
        static long PS_DASHDOT = 3;         //_._._._ 
        static long PS_DASHDOTDOT = 4;      //_.._.._ 
        static long PS_NULL = 5;
        static long PS_INSIDEFRAME = 6; 
        static long PS_USERSTYLE = 7;
        static long PS_ALTERNATE = 8;
        static long PS_STYLE_MASK = 15;

        static long PS_ENDCAP_ROUND = 0;
        static long PS_ENDCAP_SQUARE = 0x100;
        static long PS_ENDCAP_FLAT = 0x200;
        static long PS_ENDCAP_MASK = 3840;

        static long PS_JOIN_ROUND = 0;
        static long PS_JOIN_BEVEL = 0x1000;
        static long PS_JOIN_MITER = 0x2000;
        static long PS_JOIN_MASK = 61440;

        static long PS_COSMETIC = 0;
        static long PS_GEOMETRIC = 0x10000;
        static long PS_TYPE_MASK = 0xF0000;


        //==============================================
        //Mapping modes for SetMapMode/GetMapMode
        //==============================================

        static long MM_TEXT = 1;
        static long MM_LOMETRIC = 2;
        static long MM_HIMETRIC = 3;
        static long MM_LOENGLISH = 4;
        static long MM_HIENGLISH = 5;
        static long MM_TWIPS = 6;
        static long MM_ISOTROPIC = 7;
        static long MM_ANISOTROPIC = 8;


        //==============================================
        //API system Color constants  pbd
        //note these are usually shown ORed with
        //0x80000000 as these would have interfered with
        //other MS color enumerations
        //GetSysColor and SetSysColor expects the values
        //below
        //==============================================

        static long COLOR_SCROLLBAR = 0;
        static long COLOR_BACKGROUND = 1;
        static long COLOR_ACTIVECAPTION = 2;
        static long COLOR_INACTIVECAPTION = 3;
        static long COLOR_MENU = 4;
        static long COLOR_WINDOW = 5;
        static long COLOR_WINDOWFRAME = 6;
        static long COLOR_MENUTEXT = 7;
        static long COLOR_WINDOWTEXT = 8;
        static long COLOR_CAPTIONTEXT = 9;
        static long COLOR_ACTIVEBORDER = 10;
        static long COLOR_INACTIVEBORDER = 11;
        static long COLOR_APPWORKSPACE = 12;
        static long COLOR_HIGHLIGHT = 13;
        static long COLOR_HIGHLIGHTTEXT = 14;
        static long COLOR_BTNFACE = 15;
        static long COLOR_BTNSHADOW = 16;
        static long COLOR_GRAYTEXT = 17;
        static long COLOR_BTNTEXT = 18;
        static long COLOR_INACTIVECAPTIONTEXT = 19;
        static long COLOR_BTNHIGHLIGHT = 20;
        static long COLOR_3DDKSHADOW = 21;
        static long COLOR_3DLIGHT = 22;
        static long COLOR_INFOTEXT = 23;
        static long COLOR_INFOBK = 24;
        //PBD: 25 is unassigned in all the docs I can find
        //     if someone finds what this is supposed to be then fill it in
        //     note defaults below, and cl[ColorConst] in graphics
        static long COLOR_HOTLIGHT = 26;
        static long COLOR_GRADIENTACTIVECAPTION = 27;
        static long COLOR_GRADIENTINACTIVECAPTION = 28;
        static long COLOR_MENUHILIGHT = 29;
        static long COLOR_MENUBAR = 30;
        static long COLOR_FORM = 31;
        static long COLOR_ENDCOLORS = COLOR_FORM;
        static long COLOR_DESKTOP = COLOR_BACKGROUND;
        static long COLOR_3DFACE = COLOR_BTNFACE;
        static long COLOR_3DSHADOW = COLOR_BTNSHADOW;
        static long COLOR_3DHIGHLIGHT = COLOR_BTNHIGHLIGHT;
        static long COLOR_3DHILIGHT = COLOR_BTNHIGHLIGHT;
        static long COLOR_BTNHILIGHT = COLOR_BTNHIGHLIGHT;

        static long MAX_SYS_COLORS = COLOR_ENDCOLORS;
        static long SYS_COLOR_BASE = 0x80000000;
        //!! deprecated colors !!
        //CLX base, mapped, pseudo, rgb values
        static long COLOR_clForeground = 32;
        static long COLOR_clButton = COLOR_clForeground + 1;
        static long COLOR_clLight = COLOR_clForeground + 2;
        static long COLOR_clMidlight = COLOR_clForeground + 3;
        static long COLOR_clDark = COLOR_clForeground + 4;
        static long COLOR_clMid = COLOR_clForeground + 5;
        static long COLOR_clText = COLOR_clForeground + 6;
        static long COLOR_clBrightText = COLOR_clForeground + 7;
        static long COLOR_clButtonText = COLOR_clForeground + 8;
        static long COLOR_clBase = COLOR_clForeground + 9;
        //clBackground
        static long COLOR_clShadow = COLOR_clForeground + 10;
        //clHighlight
        static long COLOR_clHighlightedText = COLOR_clForeground + 11;
        //CLX normal, mapped, pseudo, rgb values
        static long COLOR_clNormalForeground = 44;
        static long COLOR_clNormalButton = COLOR_clNormalForeground + 1;
        static long COLOR_clNormalLight = COLOR_clNormalForeground + 2;
        static long COLOR_clNormalMidlight = COLOR_clNormalForeground + 3;
        static long COLOR_clNormalDark = COLOR_clNormalForeground + 4;
        static long COLOR_clNormalMid = COLOR_clNormalForeground + 5;
        static long COLOR_clNormalText = COLOR_clNormalForeground + 6;
        static long COLOR_clNormalBrightText = COLOR_clNormalForeground + 7;
        static long COLOR_clNormalButtonText = COLOR_clNormalForeground + 8;
        static long COLOR_clNormalBase = COLOR_clNormalForeground + 9;
        static long COLOR_clNormalBackground = COLOR_clNormalForeground + 10;
        static long COLOR_clNormalShadow = COLOR_clNormalForeground + 11;
        static long COLOR_clNormalHighlight = COLOR_clNormalForeground + 12;
        static long COLOR_clNormalHighlightedText = COLOR_clNormalForeground + 13;

        //CLX disabled, mapped, pseudo, rgb values
        static long COLOR_clDisabledForeground = 58;
        static long COLOR_clDisabledButton = COLOR_clDisabledForeground + 1;
        static long COLOR_clDisabledLight = COLOR_clDisabledForeground + 2;
        static long COLOR_clDisabledMidlight = COLOR_clDisabledForeground + 3;
        static long COLOR_clDisabledDark = COLOR_clDisabledForeground + 4;
        static long COLOR_clDisabledMid = COLOR_clDisabledForeground + 5;
        static long COLOR_clDisabledText = COLOR_clDisabledForeground + 6;
        static long COLOR_clDisabledBrightText = COLOR_clDisabledForeground + 7;
        static long COLOR_clDisabledButtonText = COLOR_clDisabledForeground + 8;
        static long COLOR_clDisabledBase = COLOR_clDisabledForeground + 9;
        static long COLOR_clDisabledBackground = COLOR_clDisabledForeground + 10;
        static long COLOR_clDisabledShadow = COLOR_clDisabledForeground + 11;
        static long COLOR_clDisabledHighlight = COLOR_clDisabledForeground + 12;
        static long COLOR_clDisabledHighlightedText = COLOR_clDisabledForeground + 13;

        //CLX active, mapped, pseudo, rgb values
        static long COLOR_clActiveForeground = 72;
        static long COLOR_clActiveButton = COLOR_clActiveForeground + 1;
        static long COLOR_clActiveLight = COLOR_clActiveForeground + 2;
        static long COLOR_clActiveMidlight = COLOR_clActiveForeground + 3;
        static long COLOR_clActiveDark = COLOR_clActiveForeground + 4;
        static long COLOR_clActiveMid = COLOR_clActiveForeground + 5;
        static long COLOR_clActiveText = COLOR_clActiveForeground + 6;
        static long COLOR_clActiveBrightText = COLOR_clActiveForeground + 7;
        static long COLOR_clActiveButtonText = COLOR_clActiveForeground + 8;
        static long COLOR_clActiveBase = COLOR_clActiveForeground + 9;
        static long COLOR_clActiveBackground = COLOR_clActiveForeground + 10;
        static long COLOR_clActiveShadow = COLOR_clActiveForeground + 11;
        static long COLOR_clActiveHighlight = COLOR_clActiveForeground + 12;
        static long COLOR_clActiveHighlightedText = COLOR_clActiveForeground + 13;

        //==============================================
        //Stock Objects
        //==============================================
        static long WHITE_BRUSH = 0;
        static long LTGRAY_BRUSH = 1;
        static long GRAY_BRUSH = 2;
        static long DKGRAY_BRUSH = 3;
        static long BLACK_BRUSH = 4;
        static long NULL_BRUSH = 5;
        static long HOLLOW_BRUSH = NULL_BRUSH;
        static long WHITE_PEN = 6;
        static long BLACK_PEN = 7;
        static long NULL_PEN = 8;
        static long OEM_FIXED_FONT = 10;
        static long ANSI_FIXED_FONT = 11;
        static long ANSI_VAR_FONT = 12;
        static long SYSTEM_FONT = 13;
        static long DEVICE_DEFAULT_FONT = 14;
        static long DEFAULT_PALETTE = 15;
        static long SYSTEM_FIXED_FONT = 16;
        static long DEFAULT_GUI_FONT = 17;
        static long DC_BRUSH = 18;
        static long DC_PEN = 19;
        static long STOCK_LAST = 19;

        //==============================================
        //Stock Pixmap Types
        //==============================================
        static long idButtonBase = 0;
        static long idButtonOk = idButtonBase + 1;
        static long idButtonCancel = idButtonBase + 2;
        static long idButtonHelp = idButtonBase + 3;
        static long idButtonYes = idButtonBase + 4;
        static long idButtonNo = idButtonBase + 5;
        static long idButtonClose = idButtonBase + 6;
        static long idButtonAbort = idButtonBase + 7;
        static long idButtonRetry = idButtonBase + 8;
        static long idButtonIgnore = idButtonBase + 9;
        static long idButtonAll = idButtonBase + 10;
        static long idButtonYesToAll = idButtonBase + 11;
        static long idButtonNoToAll = idButtonBase + 12;
        static long idButtonOpen = idButtonBase + 13;
        static long idButtonSave = idButtonBase + 14;
        static long idButtonShield = idButtonBase + 15;

        static long idDialogBase = 0xFF;
        static long idDialogWarning = idDialogBase + 1;
        static long idDialogError = idDialogBase + 2;
        static long idDialogInfo = idDialogBase + 3;
        static long idDialogConfirm = idDialogBase + 4;
        static long idDialogShield = idDialogBase + 5;


        //==============================================
        //Devicecontext object types
        //==============================================
        static long OBJ_PEN = 1;
        static long OBJ_BRUSH = 2;
        static long OBJ_DC = 3;
        static long OBJ_METADC = 4;
        static long OBJ_PAL = 5;
        static long OBJ_FONT = 6;
        static long OBJ_BITMAP = 7;
        static long OBJ_REGION = 8;
        static long OBJ_METAFILE = 9;
        static long OBJ_MEMDC = 10;
        static long OBJ_EXTPEN = 11;
        static long OBJ_ENHMETADC = 12;
        static long OBJ_ENHMETAFILE = 13;
        static long OBJ_COLORSPACE = 14;

        //==============================================
        //SystemParametersInfo constants
        //==============================================
        static long SPI_GETBEEP = 1;
        static long SPI_SETBEEP = 2;
        static long SPI_GETMOUSE = 3;
        static long SPI_SETMOUSE = 4;
        static long SPI_GETBORDER = 5;
        static long SPI_SETBORDER = 6;
        static long SPI_GETKEYBOARDSPEED = 10;
        static long SPI_SETKEYBOARDSPEED = 11;
        static long SPI_LANGDRIVER = 12;
        static long SPI_ICONHORIZONTALSPACING = 13;
        static long SPI_GETSCREENSAVETIMEOUT = 14;
        static long SPI_SETSCREENSAVETIMEOUT = 15;
        static long SPI_GETSCREENSAVEACTIVE = 16;
        static long SPI_SETSCREENSAVEACTIVE = 17;
        static long SPI_GETGRIDGRANULARITY = 18;
        static long SPI_SETGRIDGRANULARITY = 19;
        static long SPI_SETDESKWALLPAPER = 20;
        static long SPI_SETDESKPATTERN = 21;
        static long SPI_GETKEYBOARDDELAY = 22;
        static long SPI_SETKEYBOARDDELAY = 23;
        static long SPI_ICONVERTICALSPACING = 24;
        static long SPI_GETICONTITLEWRAP = 25;
        static long SPI_SETICONTITLEWRAP = 26;
        static long SPI_GETMENUDROPALIGNMENT = 27;
        static long SPI_SETMENUDROPALIGNMENT = 28;
        static long SPI_SETDOUBLECLKWIDTH = 29;
        static long SPI_SETDOUBLECLKHEIGHT = 30;
        static long SPI_GETICONTITLELOGFONT = 31;
        static long SPI_SETDOUBLECLICKTIME = 32;
        static long SPI_SETMOUSEBUTTONSWAP = 33;
        static long SPI_SETICONTITLELOGFONT = 34;
        static long SPI_GETFASTTASKSWITCH = 35;
        static long SPI_SETFASTTASKSWITCH = 36;
        static long SPI_SETDRAGFULLWINDOWS = 37;
        static long SPI_GETDRAGFULLWINDOWS = 38;
        static long SPI_GETNONCLIENTMETRICS = 41;
        static long SPI_SETNONCLIENTMETRICS = 42;
        static long SPI_GETMINIMIZEDMETRICS = 43;
        static long SPI_SETMINIMIZEDMETRICS = 44;
        static long SPI_GETICONMETRICS = 45;
        static long SPI_SETICONMETRICS = 46;
        static long SPI_SETWORKAREA = 47;
        static long SPI_GETWORKAREA = 48;
        static long SPI_SETPENWINDOWS = 49;
        static long SPI_GETFILTERKEYS = 50;
        static long SPI_SETFILTERKEYS = 51;
        static long SPI_GETTOGGLEKEYS = 52;
        static long SPI_SETTOGGLEKEYS = 53;
        static long SPI_GETMOUSEKEYS = 54;
        static long SPI_SETMOUSEKEYS = 55;
        static long SPI_GETSHOWSOUNDS = 56;
        static long SPI_SETSHOWSOUNDS = 57;
        static long SPI_GETSTICKYKEYS = 58;
        static long SPI_SETSTICKYKEYS = 59;
        static long SPI_GETACCESSTIMEOUT = 60;
        static long SPI_SETACCESSTIMEOUT = 61;
        static long SPI_GETSERIALKEYS = 62;
        static long SPI_SETSERIALKEYS = 63;
        static long SPI_GETSOUNDSENTRY = 64;
        static long SPI_SETSOUNDSENTRY = 65;
        static long SPI_GETHIGHCONTRAST = 66;
        static long SPI_SETHIGHCONTRAST = 67;
        static long SPI_GETKEYBOARDPREF = 68;
        static long SPI_SETKEYBOARDPREF = 69;
        static long SPI_GETSCREENREADER = 70;
        static long SPI_SETSCREENREADER = 71;
        static long SPI_GETANIMATION = 72;
        static long SPI_SETANIMATION = 73;
        static long SPI_GETFONTSMOOTHING = 74;
        static long SPI_SETFONTSMOOTHING = 75;
        static long SPI_SETDRAGWIDTH = 76;
        static long SPI_SETDRAGHEIGHT = 77;
        static long SPI_SETHANDHELD = 78;
        static long SPI_GETLOWPOWERTIMEOUT = 79;
        static long SPI_GETPOWEROFFTIMEOUT = 80;
        static long SPI_SETLOWPOWERTIMEOUT = 81;
        static long SPI_SETPOWEROFFTIMEOUT = 82;
        static long SPI_GETLOWPOWERACTIVE = 83;
        static long SPI_GETPOWEROFFACTIVE = 84;
        static long SPI_SETLOWPOWERACTIVE = 85;
        static long SPI_SETPOWEROFFACTIVE = 86;
        static long SPI_SETCURSORS = 87;
        static long SPI_SETICONS = 88;
        static long SPI_GETDEFAULTINPUTLANG = 89;
        static long SPI_SETDEFAULTINPUTLANG = 90;
        static long SPI_SETLANGTOGGLE = 91;
        static long SPI_GETWINDOWSEXTENSION = 92;
        static long SPI_SETMOUSETRAILS = 93;
        static long SPI_GETMOUSETRAILS = 94;
        static long SPI_GETSNAPTODEFBUTTON = 95;
        static long SPI_SETSNAPTODEFBUTTON = 96;
        static long SPI_SCREENSAVERRUNNING = 97;
        static long SPI_SETSCREENSAVERRUNNING = 97;
        static long SPI_GETMOUSEHOVERWIDTH = 98;
        static long SPI_SETMOUSEHOVERWIDTH = 99;
        static long SPI_GETMOUSEHOVERHEIGHT = 100;
        static long SPI_SETMOUSEHOVERHEIGHT = 101;
        static long SPI_GETMOUSEHOVERTIME = 102;
        static long SPI_SETMOUSEHOVERTIME = 103;
        static long SPI_GETWHEELSCROLLLINES = 104;
        static long SPI_SETWHEELSCROLLLINES = 105;
        static long SPI_GETMENUSHOWDELAY = 106;
        static long SPI_SETMENUSHOWDELAY = 107;
        static long SPI_GETSHOWIMEUI = 110;
        static long SPI_SETSHOWIMEUI = 111;
        static long SPI_GETMOUSESPEED = 112;
        static long SPI_SETMOUSESPEED = 113;
        static long SPI_GETSCREENSAVERRUNNING = 114;
        static long SPI_GETDESKWALLPAPER = 115;
        static long SPI_GETACTIVEWINDOWTRACKING = 4096;
        static long SPI_SETACTIVEWINDOWTRACKING = 4097;
        static long SPI_GETMENUANIMATION = 4098;
        static long SPI_SETMENUANIMATION = 4099;
        static long SPI_GETCOMBOBOXANIMATION = 4100;
        static long SPI_SETCOMBOBOXANIMATION = 4101;
        static long SPI_GETLISTBOXSMOOTHSCROLLING = 4102;
        static long SPI_SETLISTBOXSMOOTHSCROLLING = 4103;
        static long SPI_GETGRADIENTCAPTIONS = 4104;
        static long SPI_SETGRADIENTCAPTIONS = 4105;
        static long SPI_GETKEYBOARDCUES = 4106;
        static long SPI_SETKEYBOARDCUES = 4107;
        static long SPI_GETMENUUNDERLINES = 4106;
        static long SPI_SETMENUUNDERLINES = 4107;
        static long SPI_GETACTIVEWNDTRKZORDER = 4108;
        static long SPI_SETACTIVEWNDTRKZORDER = 4109;
        static long SPI_GETHOTTRACKING = 4110;
        static long SPI_SETHOTTRACKING = 4111;
        static long SPI_GETMENUFADE = 4114;
        static long SPI_SETMENUFADE = 4115;
        static long SPI_GETSELECTIONFADE = 4116;
        static long SPI_SETSELECTIONFADE = 4117;
        static long SPI_GETTOOLTIPANIMATION = 4118;
        static long SPI_SETTOOLTIPANIMATION = 4119;
        static long SPI_GETTOOLTIPFADE = 4120;
        static long SPI_SETTOOLTIPFADE = 4121;
        static long SPI_GETCURSORSHADOW = 4122;
        static long SPI_SETCURSORSHADOW = 4123;
        static long SPI_GETUIEFFECTS = 4158;
        static long SPI_SETUIEFFECTS = 4159;
        static long SPI_GETFOREGROUNDLOCKTIMEOUT = 8192;
        static long SPI_SETFOREGROUNDLOCKTIMEOUT = 8193;
        static long SPI_GETACTIVEWNDTRKTIMEOUT = 8194;
        static long SPI_SETACTIVEWNDTRKTIMEOUT = 8195;
        static long SPI_GETFOREGROUNDFLASHCOUNT = 8196;
        static long SPI_SETFOREGROUNDFLASHCOUNT = 8197;
        static long SPI_GETCARETWIDTH = 8198;
        static long SPI_SETCARETWIDTH = 8199;
        static long SPI_GETMOUSESONAR = 4124;
        static long SPI_SETMOUSESONAR = 4125;
        static long SPI_GETMOUSECLICKLOCK = 4126;
        static long SPI_SETMOUSECLICKLOCK = 4127;
        static long SPI_GETMOUSEVANISH = 4128;
        static long SPI_SETMOUSEVANISH = 4129;
        static long SPI_GETFLATMENU = 4130;
        static long SPI_SETFLATMENU = 4131;
        static long SPI_GETDROPSHADOW = 4132;
        static long SPI_SETDROPSHADOW = 4133;
        static long SPI_GETBLOCKSENDINPUTRESETS = 4134;
        static long SPI_SETBLOCKSENDINPUTRESETS = 4135;
        static long SPI_GETMOUSECLICKLOCKTIME = 8200;
        static long SPI_SETMOUSECLICKLOCKTIME = 8201;
        static long SPI_GETFONTSMOOTHINGTYPE = 8202;
        static long SPI_SETFONTSMOOTHINGTYPE = 8203;
        static long SPI_GETFONTSMOOTHINGCONTRAST = 8204;
        static long SPI_SETFONTSMOOTHINGCONTRAST = 8205;
        static long SPI_GETFOCUSBORDERWIDTH = 8206;
        static long SPI_SETFOCUSBORDERWIDTH = 8207;
        static long SPI_GETFOCUSBORDERHEIGHT = 8208;
        static long SPI_SETFOCUSBORDERHEIGHT = 8209;
        static long SPI_GETFONTSMOOTHINGORIENTATION = 8210;
        static long SPI_SETFONTSMOOTHINGORIENTATION = 8211;

        //==============================================
        //GetDeviceCaps constants
        //==============================================
        static long BI_RGB = 0;
        static long BI_RLE8 = 1;
        static long BI_RLE4 = 2;
        static long BI_BITFIELDS = 3;


        static long HORZSIZE = 4;   //Horizontal size in millimeters           
        static long VERTSIZE = 6;   //Vertical size in millimeters             
        static long HORZRES = 8;   //Horizontal width in pixels               
        static long VERTRES = 10;  //Vertical height in pixels                
        static long BITSPIXEL = 12;  //Number of bits per pixel                 
        static long PLANES = 14;  //Number of planes                         
        static long NUMCOLORS = 24;  //Number of colors                         
        static long LOGPIXELSX = 88;  //Logical pixelsinch in X                  
        static long LOGPIXELSY = 90;  //Logical pixelsinch in Y                  
        static long SIZEPALETTE = 104; //Number of entries in physical palette    
        static long NUMRESERVED = 106; //Number of reserved entries in palette    


        //==============================================
        //Text Alignment Options
        //==============================================
        static long TA_NOUPDATECP = 0;
        static long TA_UPDATECP = 1;
        static long TA_LEFT = 0;
        static long TA_RIGHT = 2;
        static long TA_CENTER = 6;
        static long TA_TOP = 0;
        static long TA_BOTTOM = 8;
        static long TA_BASELINE = 0x18;
        static long TA_RTLREADING = 0x100;
        static long TA_MASK = (TA_BASELINE + TA_CENTER + TA_UPDATECP + TA_RTLREADING);

        //==============================================
        //PolyFill() Modes (polygon fill mode)
        //==============================================
        static long ALTERNATE = 1;
        static long WINDING = 2;
        static long POLYFILL_LAST = 2;

        //==============================================
        //StretchBlt() Modes
        //==============================================

        static long BLACKONWHITE = 1;
        static long WHITEONBLACK = 2;
        static long COLORONCOLOR = 3;
        static long HALFTONE = 4;
        static long MAXSTRETCHBLTMODE = 4;
        //constants for CreateDIBitmap 
        static long CBM_INIT = 4;     //initialize bitmap  

        //==============================================
        //Load/CopyImage constants
        //==============================================
        static long IMAGE_BITMAP = 0;
        static long IMAGE_ICON = 1;
        static long IMAGE_CURSOR = 2;
        static long IMAGE_ENHMETAFILE = 3;
        //loadflags
        static long LR_DEFAULTCOLOR = 0x0000;
        static long LR_MONOCHROME = 0x0001;
        static long LR_COLOR = 0x0002;
        static long LR_COPYRETURNORG = 0x0004;
        static long LR_COPYDELETEORG = 0x0008;
        static long LR_LOADFROMFILE = 0x0010;
        static long LR_LOADTRANSPARENT = 0x0020;
        static long LR_DEFAULTSIZE = 0x0040;
        static long LR_VGACOLOR = 0x0080;
        static long LR_LOADMAP3DCOLORS = 0x1000;
        static long LR_CREATEDIBSECTION = 0x2000;
        static long LR_COPYFROMRESOURCE = 0x4000;
        static long LR_SHARED = 0x8000;

        static long csNone = 0;
        static long csAlignment = 1;
        static long csBox = 2;
        static long csButton = 3;
        static long csComboBox = 4;
        static long csCheckbox = 5;
        static long csEdit = 6;
        static long csForm = 7;
        static long csStaticText = 8;
        static long csgtkTable = 9;
        static long csScrollBar = 10;
        static long csListView = 11;
        static long csMainForm = 12;
        static long csMemo = 13;
        static long csMainMenu = 14;
        static long csMenuBar = 15;
        static long csMenuItem = 16;
        static long csNotebook = 17;
        static long csFileDialog = 18;
        static long csRadioButton = 19;
        static long csScrolledWindow = 20;
        static long csSpinedit = 21;
        static long csStatusBar = 22;
        static long csTable = 23;
        static long csToggleBox = 24;
        static long csVScrollBar = 25;
        static long csFrame = 26;
        static long csButtonBox = 27;
        static long csCanvas = 28;
        static long csGroupBox = 29;

        static long csFont = 30;
        static long csPen = 31;
        static long csBrush = 32;
        static long csTimer = 33;
        static long csPage = 34;

        static long csColorDialog = 35;
        static long csListBox = 36;
        static long csFontDialog = 37;
        static long csProgressBar = 38;
        static long csTrackBar = 39;
        static long csWinControl = 40;
        static long csFixed = csWinControl; //TODO remove
        static long csImage = 41;
        static long csToolbar = 42;
        static long csToolButton = 43;
        static long csBitBtn = 44;
        static long csCListBox = 45;
        static long csSpeedButton = 46;
        static long csPopupMenu = 47;
        static long csHintWindow = 48;

        static long csCalendar = 49;

        static long csArrow = 50;
        static long csPanel = 51;
        static long csScrollBox = 52;

        static long csCheckListBox = 53;
        static long csPairSplitter = 54;
        static long csPairSplitterSide = 55;

        static long csOpenFileDialog = 56;
        static long csSaveFileDialog = 57;
        static long csSelectDirectoryDialog = 58;
        static long csPreviewFileControl = 59;
        static long csPreviewFileDialog = 60;

        static long csNonLCL = 61; //for non LCL controls, that create their own handles


        //Mouse message key states
        static long MK_LBUTTON = 1;
        static long MK_RBUTTON = 2;
        static long MK_SHIFT = 4;
        static long MK_CONTROL = 8;
        static long MK_MBUTTON = 0x10;
        static long MK_XBUTTON1 = 0x20;
        static long MK_XBUTTON2 = 0x40;
        //following are "virtual" key states
        static long MK_DOUBLECLICK = 0x80;
        static long MK_TRIPLECLICK = 0x100;
        static long MK_QUADCLICK = 0x200;

        //==============================================
        //Constants from commctrl
        //==============================================

        //-------------
        //Common
        //-------------

        //all controls
        static long NM_FIRST = 0;
        static long NM_OUTOFMEMORY = NM_FIRST - 1;
        static long NM_CLICK = NM_FIRST - 2;
        static long NM_DBLCLK = NM_FIRST - 3;
        static long NM_RETURN = NM_FIRST - 4;
        static long NM_RCLICK = NM_FIRST - 5;
        static long NM_RDBLCLK = NM_FIRST - 6;
        static long NM_SETFOCUS = NM_FIRST - 7;
        static long NM_KILLFOCUS = NM_FIRST - 8;
        static long NM_CUSTOMDRAW = NM_FIRST - 12;
        static long NM_HOVER = NM_FIRST - 13;
        static long NM_NCHITTEST = NM_FIRST - 14;
        static long NM_KEYDOWN = NM_FIRST - 15;
        static long NM_RELEASEDCAPTURE = NM_FIRST - 16;
        static long NM_SETCURSOR = NM_FIRST - 17;
        static long NM_CHAR = NM_FIRST - 18;
        static long NM_TOOLTIPSCREATED = (NM_FIRST - 19);
        static long NM_LDOWN = (NM_FIRST - 20);
        static long NM_RDOWN = (NM_FIRST - 21);
        static long NM_THEMECHANGED = (NM_FIRST - 22);
        static long NM_FONTCHANGED = (NM_FIRST - 23);
        static long NM_CUSTOMTEXT = (NM_FIRST - 24);
        static long NM_TVSTATEIMAGECHANGING = (NM_FIRST - 24);
        static long NM_LAST = NM_FIRST - 99;
        //toolbar
        static long TBN_First = -700;
        static long TBN_Last = -720;

        static long STATUS_PENDING = 0x103; //259 = STILL_ALIVE

        static long DESKTOP_SWITCHDESKTOP = 0x0100;
        static long ERROR_ACCESS_DENIED = 0x0005;

        // text align
        static long TA_DEFAULT = 0;

        static long
       /* SetGraphicsMode(hdc, iMode ) */
       GM_COMPATIBLE = 1,
       GM_ADVANCED = 2,
       MWT_IDENTITY = 1;

        static long
        PAGE_READONLY = 0x02,
        PAGE_READWRITE = 0x04,
        PAGE_WRITECOPY = 0x08,
        FILE_MAP_COPY = 0x0001,
        FILE_MAP_WRITE = 0x0002,
        FILE_MAP_READ = 0x0004;

        static long SHGFI_ICON = 0x000000100,   // get icon
        SHGFI_DISPLAYNAME = 0x000000200,     // get display name
        SHGFI_TYPENAME = 0x000000400,     // get type name
        SHGFI_ATTRIBUTES = 0x000000800,     // get attributes
        SHGFI_ICONLOCATION = 0x000001000,     // get icon location
        SHGFI_EXETYPE = 0x000002000,     // return exe type
        SHGFI_SYSICONINDEX = 0x000004000,     // get system icon index
        SHGFI_LINKOVERLAY = 0x000008000,     // put a link overlay on icon
        SHGFI_SELECTED = 0x000010000,     // show icon in selected state
        SHGFI_ATTR_SPECIFIED = 0x000020000,     // get only specified attributes
        SHGFI_LARGEICON = 0x000000000,     // get large icon
        SHGFI_SMALLICON = 0x000000001,     // get small icon
        SHGFI_OPENICON = 0x000000002,     // get open icon
        SHGFI_SHELLICONSIZE = 0x000000004,     // get shell size icon
        SHGFI_PIDL = 0x000000008,     // pszPath is a pidl
        SHGFI_USEFILEATTRIBUTES = 0x000000010,     // use passed dwFileAttribute
        SHGFI_ADDOVERLAYS = 0x000000020,     // apply the appropriate overlays
        SHGFI_OVERLAYINDEX = 0x000000040;     // Get the index of the overlay


        public const int DM_DISPLAYORIENTATION = 0x00000080;

        public const int AUTOSUGGEST = 0x10000000,
        AUTOSUGGEST_OFF = 0x20000000,
        AUTOAPPEND = 0x40000000,
        AUTOAPPEND_OFF = (unchecked((int)0x80000000));

        public const int ARW_BOTTOMLEFT = 0x0000,
        ARW_BOTTOMRIGHT = 0x0001,
        ARW_TOPLEFT = 0x0002,
        ARW_TOPRIGHT = 0x0003,
        ARW_LEFT = 0x0000,
        ARW_RIGHT = 0x0000,
        ARW_UP = 0x0004,
        ARW_DOWN = 0x0004,
        ARW_HIDE = 0x0008,
        ADVF_NODATA = 1,
        ADVF_ONLYONCE = 4,
        ADVF_PRIMEFIRST = 2;
        // Note: ADVF_ONLYONCE and ADVF_PRIMEFIRST values now conform with objidl.dll but are backwards from
        // Platform SDK documentation as of 07/21/2003.
        // http://msdn.microsoft.com/library/default.asp?url=/library/en-us/com/htm/oen_a2z_8jxi.asp.

        public const int 
        BFFM_INITIALIZED = 1,
        BFFM_SELCHANGED = 2,
        BFFM_SETSELECTIONA = 0x400 + 102,
        BFFM_SETSELECTIONW = 0x400 + 103,
        BFFM_ENABLEOK = 0x400 + 101;

        public const int CDERR_DIALOGFAILURE = 0xFFFF,
        CDERR_STRUCTSIZE = 0x0001,
        CDERR_INITIALIZATION = 0x0002,
        CDERR_NOTEMPLATE = 0x0003,
        CDERR_NOHINSTANCE = 0x0004,
        CDERR_LOADSTRFAILURE = 0x0005,
        CDERR_FINDRESFAILURE = 0x0006,
        CDERR_LOADRESFAILURE = 0x0007,
        CDERR_LOCKRESFAILURE = 0x0008,
        CDERR_MEMALLOCFAILURE = 0x0009,
        CDERR_MEMLOCKFAILURE = 0x000A,
        CDERR_NOHOOK = 0x000B,
        CDERR_REGISTERMSGFAIL = 0x000C,
        CFERR_NOFONTS = 0x2001,
        CFERR_MAXLESSTHANMIN = 0x2002,
        CC_RGBINIT = 0x00000001,
        CC_FULLOPEN = 0x00000002,
        CC_PREVENTFULLOPEN = 0x00000004,
        CC_SHOWHELP = 0x00000008,
        CC_ENABLEHOOK = 0x00000010,
        CC_SOLIDCOLOR = 0x00000080,
        CC_ANYCOLOR = 0x00000100,
        CF_SCREENFONTS = 0x00000001,
        CF_SHOWHELP = 0x00000004,
        CF_ENABLEHOOK = 0x00000008,
        CF_INITTOLOGFONTSTRUCT = 0x00000040,
        CF_EFFECTS = 0x00000100,
        CF_APPLY = 0x00000200,
        CF_SCRIPTSONLY = 0x00000400,
        CF_NOVECTORFONTS = 0x00000800,
        CF_NOSIMULATIONS = 0x00001000,
        CF_LIMITSIZE = 0x00002000,
        CF_FIXEDPITCHONLY = 0x00004000,
        CF_FORCEFONTEXIST = 0x00010000,
        CF_TTONLY = 0x00040000,
        CF_SELECTSCRIPT = 0x00400000,
        CF_NOVERTFONTS = 0x01000000,
        CP_WINANSI = 1004;

        public const int cmb4 = 0x0473,
        CS_DBLCLKS = 0x0008,
        CS_DROPSHADOW = 0x00020000,
        CS_SAVEBITS = 0x0800,
        CF_TEXT = 1,
        CF_BITMAP = 2,
        CF_METAFILEPICT = 3,
        CF_SYLK = 4,
        CF_DIF = 5,
        CF_TIFF = 6,
        CF_OEMTEXT = 7,
        CF_DIB = 8,
        CF_PALETTE = 9,
        CF_PENDATA = 10,
        CF_RIFF = 11,
        CF_WAVE = 12,
        CF_UNICODETEXT = 13,
        CF_ENHMETAFILE = 14,
        CF_HDROP = 15,
        CF_LOCALE = 16,
        CLSCTX_INPROC_SERVER = 0x1,
        CLSCTX_LOCAL_SERVER = 0x4,
        CW_USEDEFAULT = (unchecked((int)0x80000000)),
        CWP_SKIPINVISIBLE = 0x0001,
        CB_ERR = (-1),
        CBN_SELCHANGE = 1,
        CBN_DBLCLK = 2,
        CBN_EDITCHANGE = 5,
        CBN_EDITUPDATE = 6,
        CBN_DROPDOWN = 7,
        CBN_CLOSEUP = 8,
        CBN_SELENDOK = 9,
        CONNECT_E_NOCONNECTION = unchecked((int)0x80040200),
        CONNECT_E_CANNOTCONNECT = unchecked((int)0x80040202),
        CTRLINFO_EATS_RETURN = 1,
        CTRLINFO_EATS_ESCAPE = 2,
        CSIDL_DESKTOP = 0x0000,        // <desktop>
        CSIDL_INTERNET = 0x0001,        // Internet Explorer (icon on desktop)
        CSIDL_PROGRAMS = 0x0002,        // Start Menu\Programs
        CSIDL_PERSONAL = 0x0005,        // My Documents
        CSIDL_FAVORITES = 0x0006,        // <user name>\Favorites
        CSIDL_STARTUP = 0x0007,        // Start Menu\Programs\Startup
        CSIDL_RECENT = 0x0008,        // <user name>\Recent
        CSIDL_SENDTO = 0x0009,        // <user name>\SendTo
        CSIDL_STARTMENU = 0x000b,        // <user name>\Start Menu
        CSIDL_DESKTOPDIRECTORY = 0x0010,        // <user name>\Desktop
        CSIDL_TEMPLATES = 0x0015,
        CSIDL_APPDATA = 0x001a,        // <user name>\Application Data
        CSIDL_LOCAL_APPDATA = 0x001c,        // <user name>\Local Settings\Applicaiton Data (non roaming)
        CSIDL_INTERNET_CACHE = 0x0020,
        CSIDL_COOKIES = 0x0021,
        CSIDL_HISTORY = 0x0022,
        CSIDL_COMMON_APPDATA = 0x0023,        // All Users\Application Data
        CSIDL_SYSTEM = 0x0025,        // GetSystemDirectory()
        CSIDL_PROGRAM_FILES = 0x0026,        // C:\Program Files
        CSIDL_PROGRAM_FILES_COMMON = 0x002b;        // C:\Program Files\Common

        public const int DUPLICATE = 0x06,
        DISPID_UNKNOWN = (-1),
        DISPID_PROPERTYPUT = (-3),
        DISPATCH_METHOD = 0x1,
        DISPATCH_PROPERTYGET = 0x2,
        DISPATCH_PROPERTYPUT = 0x4,
        DV_E_DVASPECT = unchecked((int)0x8004006B),
        DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003),
        DISP_E_PARAMNOTFOUND = unchecked((int)0x80020004),
        DISP_E_EXCEPTION = unchecked((int)0x80020009),
        DRAGDROP_E_NOTREGISTERED = unchecked((int)0x80040100),
        DRAGDROP_E_ALREADYREGISTERED = unchecked((int)0x80040101),
        DUPLICATE_SAME_ACCESS = 0x00000002,
        DCX_WINDOW = 0x00000001,
        DCX_CACHE = 0x00000002,
        DCX_LOCKWINDOWUPDATE = 0x00000400,
        DCX_INTERSECTRGN = 0x00000080,
        DI_NORMAL = 0x0003,
        DVASPECT_CONTENT = 1,
        DVASPECT_TRANSPARENT = 32,
        DVASPECT_OPAQUE = 16;

        public const int E_NOTIMPL = unchecked((int)0x80004001),
        E_OUTOFMEMORY = unchecked((int)0x8007000E),
        E_INVALIDARG = unchecked((int)0x80070057),
        E_NOINTERFACE = unchecked((int)0x80004002),
        E_POINTER = unchecked((int)0x80004003),
        E_FAIL = unchecked((int)0x80004005),
        E_ABORT = unchecked((int)0x80004004),
        E_UNEXPECTED = unchecked((int)0x8000FFFF),
        INET_E_DEFAULT_ACTION = unchecked((int)0x800C0011),
        ETO_OPAQUE = 0x0002,
        ETO_CLIPPED = 0x0004,
        EMR_POLYTEXTOUTA = 96,
        EMR_POLYTEXTOUTW = 97;

        public const int ERROR_INVALID_HANDLE = 6;
        public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

        public const int FNERR_SUBCLASSFAILURE = 0x3001,
        FNERR_INVALIDFILENAME = 0x3002,
        FNERR_BUFFERTOOSMALL = 0x3003,
        FRERR_BUFFERLENGTHZERO = 0x4001,
        FADF_BSTR = (0x100),
        FADF_UNKNOWN = (0x200),
        FADF_DISPATCH = (0x400),
        FADF_VARIANT = (unchecked((int)0x800)),
        FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000,
        FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200,
        FVIRTKEY = 0x01,
        FSHIFT = 0x04,
        FALT = 0x10;


        public const int GMEM_FIXED = 0x0000,
        GMEM_MOVEABLE = 0x0002,
        GMEM_NOCOMPACT = 0x0010,
        GMEM_NODISCARD = 0x0020,
        GMEM_ZEROINIT = 0x0040,
        GMEM_MODIFY = 0x0080,
        GMEM_DISCARDABLE = 0x0100,
        GMEM_NOT_BANKED = 0x1000,
        GMEM_SHARE = 0x2000,
        GMEM_DDESHARE = 0x2000,
        GMEM_NOTIFY = 0x4000,
        GMEM_LOWER = GMEM_NOT_BANKED,
        GMEM_VALID_FLAGS = 0x7F72,
        GMEM_INVALID_HANDLE = 0x8000,
        GHND = (GMEM_MOVEABLE | GMEM_ZEROINIT),
        GPTR = (GMEM_FIXED | GMEM_ZEROINIT),
        GDI_ERROR = (unchecked((int)0xFFFFFFFF)),
        GA_PARENT = 1,
        GA_ROOT = 2;

        // ImmGetCompostionString index.
        public const int
        GCS_COMPSTR = 0x0008,
        GCS_COMPATTR = 0x0010,
        GCS_RESULTSTR = 0x0800,

        // attribute for COMPOSITIONSTRING Structure
        ATTR_INPUT = 0x00,
        ATTR_TARGET_CONVERTED = 0x01,
        ATTR_CONVERTED = 0x02,
        ATTR_TARGET_NOTCONVERTED = 0x03,
        ATTR_INPUT_ERROR = 0x04,
        ATTR_FIXEDCONVERTED = 0x05,

        // dwAction for ImmNotifyIME
        NI_COMPOSITIONSTR = 0x0015,

        // dwIndex for ImmNotifyIME/NI_COMPOSITIONSTR
        CPS_COMPLETE = 0x01,
        CPS_CANCEL = 0x04;

        public const int
        HTLEFT = 10,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17,
        HTBORDER = 18,
        HCF_HIGHCONTRASTON = 0x00000001;

        // Corresponds to bitmaps in MENUITEMINFO
        public const int HBMMENU_CALLBACK = -1,
        HBMMENU_SYSTEM = 1,
        HBMMENU_MBAR_RESTORE = 2,
        HBMMENU_MBAR_MINIMIZE = 3,
        HBMMENU_MBAR_CLOSE = 5,
        HBMMENU_MBAR_CLOSE_D = 6,
        HBMMENU_MBAR_MINIMIZE_D = 7,
        HBMMENU_POPUP_CLOSE = 8,
        HBMMENU_POPUP_RESTORE = 9,
        HBMMENU_POPUP_MAXIMIZE = 10,
        HBMMENU_POPUP_MINIMIZE = 11;

        public const int IME_CMODE_NATIVE = 0x0001,
        IME_CMODE_KATAKANA = 0x0002,
        IME_CMODE_FULLSHAPE = 0x0008,
        INPLACE_E_NOTOOLSPACE = unchecked((int)0x800401A1),
        ICON_SMALL = 0,
        ICON_BIG = 1;

        public const int IDM_PRINT = 27,
        IDM_PAGESETUP = 2004,
        IDM_PRINTPREVIEW = 2003,
        IDM_PROPERTIES = 28,
        IDM_SAVEAS = 71;

        public const int CSC_NAVIGATEFORWARD = 0x00000001,
        CSC_NAVIGATEBACK = 0x00000002;

        public const int STG_E_INVALIDFUNCTION = unchecked((int)0x80030001);
        public const int STG_E_FILENOTFOUND = unchecked((int)0x80030002);
        public const int STG_E_PATHNOTFOUND = unchecked((int)0x80030003);
        public const int STG_E_TOOMANYOPENFILES = unchecked((int)0x80030004);
        public const int STG_E_ACCESSDENIED = unchecked((int)0x80030005);
        public const int STG_E_INVALIDHANDLE = unchecked((int)0x80030006);
        public const int STG_E_INSUFFICIENTMEMORY = unchecked((int)0x80030008);
        public const int STG_E_INVALIDPOINTER = unchecked((int)0x80030009);
        public const int STG_E_NOMOREFILES = unchecked((int)0x80030012);
        public const int STG_E_DISKISWRITEPROTECTED = unchecked((int)0x80030013);
        public const int STG_E_SEEKERROR = unchecked((int)0x80030019);
        public const int STG_E_WRITEFAULT = unchecked((int)0x8003001D);
        public const int STG_E_READFAULT = unchecked((int)0x8003001E);
        public const int STG_E_SHAREVIOLATION = unchecked((int)0x80030020);
        public const int STG_E_LOCKVIOLATION = unchecked((int)0x80030021);

        public const int INPUT_KEYBOARD = 1;

        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;
        public const int KEYEVENTF_UNICODE = 0x0004;

        public const int 
        LOCK_WRITE = 0x1,
        LOCK_EXCLUSIVE = 0x2,
        LOCK_ONLYONCE = 0x4,
        LWA_COLORKEY = 0x00000001,
        LWA_ALPHA = 0x00000002;

    }
}