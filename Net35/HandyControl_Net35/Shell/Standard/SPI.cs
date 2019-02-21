﻿namespace Standard
{
    using System;

    internal enum SPI
    {
        GETACCESSTIMEOUT = 60,
        GETACTIVEWINDOWTRACKING = 0x1000,
        GETACTIVEWNDTRKTIMEOUT = 0x2002,
        GETACTIVEWNDTRKZORDER = 0x100c,
        GETANIMATION = 0x48,
        GETAUDIODESCRIPTION = 0x74,
        GETBEEP = 1,
        GETBLOCKSENDINPUTRESETS = 0x1026,
        GETBORDER = 5,
        GETCARETWIDTH = 0x2006,
        GETCLEARTYPE = 0x1048,
        GETCLIENTAREAANIMATION = 0x1042,
        GETCOMBOBOXANIMATION = 0x1004,
        GETCURSORSHADOW = 0x101a,
        GETDEFAULTINPUTLANG = 0x59,
        GETDESKWALLPAPER = 0x73,
        GETDISABLEOVERLAPPEDCONTENT = 0x1040,
        GETDOCKMOVING = 0x90,
        GETDRAGFROMMAXIMIZE = 140,
        GETDRAGFULLWINDOWS = 0x26,
        GETDROPSHADOW = 0x1024,
        GETFASTTASKSWITCH = 0x23,
        GETFILTERKEYS = 50,
        GETFLATMENU = 0x1022,
        GETFOCUSBORDERHEIGHT = 0x2010,
        GETFOCUSBORDERWIDTH = 0x200e,
        GETFONTSMOOTHING = 0x4a,
        GETFONTSMOOTHINGCONTRAST = 0x200c,
        GETFONTSMOOTHINGORIENTATION = 0x2012,
        GETFONTSMOOTHINGTYPE = 0x200a,
        GETFOREGROUNDFLASHCOUNT = 0x2004,
        GETFOREGROUNDLOCKTIMEOUT = 0x2000,
        GETGRADIENTCAPTIONS = 0x1008,
        GETGRIDGRANULARITY = 0x12,
        GETHIGHCONTRAST = 0x42,
        GETHOTTRACKING = 0x100e,
        GETHUNGAPPTIMEOUT = 120,
        GETICONMETRICS = 0x2d,
        GETICONTITLELOGFONT = 0x1f,
        GETICONTITLEWRAP = 0x19,
        GETKEYBOARDCUES = 0x100a,
        GETKEYBOARDDELAY = 0x16,
        GETKEYBOARDPREF = 0x44,
        GETKEYBOARDSPEED = 10,
        GETLISTBOXSMOOTHSCROLLING = 0x1006,
        GETLOWPOWERACTIVE = 0x53,
        GETLOWPOWERTIMEOUT = 0x4f,
        GETMENUANIMATION = 0x1002,
        GETMENUDROPALIGNMENT = 0x1b,
        GETMENUFADE = 0x1012,
        GETMENUSHOWDELAY = 0x6a,
        GETMENUUNDERLINES = 0x100a,
        GETMESSAGEDURATION = 0x2016,
        GETMINIMIZEDMETRICS = 0x2b,
        GETMINIMUMHITRADIUS = 0x2014,
        GETMOUSE = 3,
        GETMOUSECLICKLOCK = 0x101e,
        GETMOUSECLICKLOCKTIME = 0x2008,
        GETMOUSEDOCKTHRESHOLD = 0x7e,
        GETMOUSEDRAGOUTTHRESHOLD = 0x84,
        GETMOUSEHOVERHEIGHT = 100,
        GETMOUSEHOVERTIME = 0x66,
        GETMOUSEHOVERWIDTH = 0x62,
        GETMOUSEKEYS = 0x36,
        GETMOUSESIDEMOVETHRESHOLD = 0x88,
        GETMOUSESONAR = 0x101c,
        GETMOUSESPEED = 0x70,
        GETMOUSETRAILS = 0x5e,
        GETMOUSEVANISH = 0x1020,
        GETNONCLIENTMETRICS = 0x29,
        GETPENDOCKTHRESHOLD = 0x80,
        GETPENDRAGOUTTHRESHOLD = 0x86,
        GETPENSIDEMOVETHRESHOLD = 0x8a,
        GETPOWEROFFACTIVE = 0x54,
        GETPOWEROFFTIMEOUT = 80,
        GETSCREENREADER = 70,
        GETSCREENSAVEACTIVE = 0x10,
        GETSCREENSAVERRUNNING = 0x72,
        GETSCREENSAVESECURE = 0x76,
        GETSCREENSAVETIMEOUT = 14,
        GETSELECTIONFADE = 0x1014,
        GETSERIALKEYS = 0x3e,
        GETSHOWIMEUI = 110,
        GETSHOWSOUNDS = 0x38,
        GETSNAPSIZING = 0x8e,
        GETSNAPTODEFBUTTON = 0x5f,
        GETSOUNDSENTRY = 0x40,
        GETSPEECHRECOGNITION = 0x104a,
        GETSTICKYKEYS = 0x3a,
        GETTOGGLEKEYS = 0x34,
        GETTOOLTIPANIMATION = 0x1016,
        GETTOOLTIPFADE = 0x1018,
        GETUIEFFECTS = 0x103e,
        GETWAITTOKILLSERVICETIMEOUT = 0x7c,
        GETWAITTOKILLTIMEOUT = 0x7a,
        GETWHEELSCROLLCHARS = 0x6c,
        GETWHEELSCROLLLINES = 0x68,
        GETWINARRANGING = 130,
        GETWINDOWSEXTENSION = 0x5c,
        GETWORKAREA = 0x30,
        ICONHORIZONTALSPACING = 13,
        ICONVERTICALSPACING = 0x18,
        LANGDRIVER = 12,
        SCREENSAVERRUNNING = 0x61,
        SETACCESSTIMEOUT = 0x3d,
        SETACTIVEWINDOWTRACKING = 0x1001,
        SETACTIVEWNDTRKTIMEOUT = 0x2003,
        SETACTIVEWNDTRKZORDER = 0x100d,
        SETANIMATION = 0x49,
        SETAUDIODESCRIPTION = 0x75,
        SETBEEP = 2,
        SETBLOCKSENDINPUTRESETS = 0x1027,
        SETBORDER = 6,
        SETCARETWIDTH = 0x2007,
        SETCLEARTYPE = 0x1049,
        SETCLIENTAREAANIMATION = 0x1043,
        SETCOMBOBOXANIMATION = 0x1005,
        SETCURSORS = 0x57,
        SETCURSORSHADOW = 0x101b,
        SETDEFAULTINPUTLANG = 90,
        SETDESKPATTERN = 0x15,
        SETDESKWALLPAPER = 20,
        SETDISABLEOVERLAPPEDCONTENT = 0x1041,
        SETDOCKMOVING = 0x91,
        SETDOUBLECLICKTIME = 0x20,
        SETDOUBLECLKHEIGHT = 30,
        SETDOUBLECLKWIDTH = 0x1d,
        SETDRAGFROMMAXIMIZE = 0x8d,
        SETDRAGFULLWINDOWS = 0x25,
        SETDRAGHEIGHT = 0x4d,
        SETDRAGWIDTH = 0x4c,
        SETDROPSHADOW = 0x1025,
        SETFASTTASKSWITCH = 0x24,
        SETFILTERKEYS = 0x33,
        SETFLATMENU = 0x1023,
        SETFOCUSBORDERHEIGHT = 0x2011,
        SETFOCUSBORDERWIDTH = 0x200f,
        SETFONTSMOOTHING = 0x4b,
        SETFONTSMOOTHINGCONTRAST = 0x200d,
        SETFONTSMOOTHINGORIENTATION = 0x2013,
        SETFONTSMOOTHINGTYPE = 0x200b,
        SETFOREGROUNDFLASHCOUNT = 0x2005,
        SETFOREGROUNDLOCKTIMEOUT = 0x2001,
        SETGRADIENTCAPTIONS = 0x1009,
        SETGRIDGRANULARITY = 0x13,
        SETHANDHELD = 0x4e,
        SETHIGHCONTRAST = 0x43,
        SETHOTTRACKING = 0x100f,
        SETHUNGAPPTIMEOUT = 0x79,
        SETICONMETRICS = 0x2e,
        SETICONS = 0x58,
        SETICONTITLELOGFONT = 0x22,
        SETICONTITLEWRAP = 0x1a,
        SETKEYBOARDCUES = 0x100b,
        SETKEYBOARDDELAY = 0x17,
        SETKEYBOARDPREF = 0x45,
        SETKEYBOARDSPEED = 11,
        SETLANGTOGGLE = 0x5b,
        SETLISTBOXSMOOTHSCROLLING = 0x1007,
        SETLOWPOWERACTIVE = 0x55,
        SETLOWPOWERTIMEOUT = 0x51,
        SETMENUANIMATION = 0x1003,
        SETMENUDROPALIGNMENT = 0x1c,
        SETMENUFADE = 0x1013,
        SETMENUSHOWDELAY = 0x6b,
        SETMENUUNDERLINES = 0x100b,
        SETMESSAGEDURATION = 0x2017,
        SETMINIMIZEDMETRICS = 0x2c,
        SETMINIMUMHITRADIUS = 0x2015,
        SETMOUSE = 4,
        SETMOUSEBUTTONSWAP = 0x21,
        SETMOUSECLICKLOCK = 0x101f,
        SETMOUSECLICKLOCKTIME = 0x2009,
        SETMOUSEDOCKTHRESHOLD = 0x7f,
        SETMOUSEDRAGOUTTHRESHOLD = 0x85,
        SETMOUSEHOVERHEIGHT = 0x65,
        SETMOUSEHOVERTIME = 0x67,
        SETMOUSEHOVERWIDTH = 0x63,
        SETMOUSEKEYS = 0x37,
        SETMOUSESIDEMOVETHRESHOLD = 0x89,
        SETMOUSESONAR = 0x101d,
        SETMOUSESPEED = 0x71,
        SETMOUSETRAILS = 0x5d,
        SETMOUSEVANISH = 0x1021,
        SETNONCLIENTMETRICS = 0x2a,
        SETPENDOCKTHRESHOLD = 0x81,
        SETPENDRAGOUTTHRESHOLD = 0x87,
        SETPENSIDEMOVETHRESHOLD = 0x8b,
        SETPENWINDOWS = 0x31,
        SETPOWEROFFACTIVE = 0x56,
        SETPOWEROFFTIMEOUT = 0x52,
        SETSCREENREADER = 0x47,
        SETSCREENSAVEACTIVE = 0x11,
        SETSCREENSAVERRUNNING = 0x61,
        SETSCREENSAVESECURE = 0x77,
        SETSCREENSAVETIMEOUT = 15,
        SETSELECTIONFADE = 0x1015,
        SETSERIALKEYS = 0x3f,
        SETSHOWIMEUI = 0x6f,
        SETSHOWSOUNDS = 0x39,
        SETSNAPSIZING = 0x8f,
        SETSNAPTODEFBUTTON = 0x60,
        SETSOUNDSENTRY = 0x41,
        SETSPEECHRECOGNITION = 0x104b,
        SETSTICKYKEYS = 0x3b,
        SETTOGGLEKEYS = 0x35,
        SETTOOLTIPANIMATION = 0x1017,
        SETTOOLTIPFADE = 0x1019,
        SETUIEFFECTS = 0x103f,
        SETWAITTOKILLSERVICETIMEOUT = 0x7d,
        SETWAITTOKILLTIMEOUT = 0x7b,
        SETWHEELSCROLLCHARS = 0x6d,
        SETWHEELSCROLLLINES = 0x69,
        SETWINARRANGING = 0x83,
        SETWORKAREA = 0x2f
    }
}

