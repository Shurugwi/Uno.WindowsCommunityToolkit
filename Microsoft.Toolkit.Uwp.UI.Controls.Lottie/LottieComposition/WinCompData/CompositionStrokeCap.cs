﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WinCompData
{
#if !WINDOWS_UWP
    public
#endif
    enum CompositionStrokeCap
    {
        Flat,
        Square,
        Round,
        Triangle,
    }
}