﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [DllImport(Libraries.Gdi32, ExactSpelling = true)]
        public static extern BOOL LineTo(IntPtr hdc, int x, int y);

        public static BOOL LineTo(HandleRef hdc, int x, int y)
        {
            BOOL result = LineTo(hdc.Handle, x, y);
            GC.KeepAlive(hdc.Wrapper);
            return result;
        }
    }
}
