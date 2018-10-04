﻿using System;
using System.Runtime.InteropServices;

namespace Meziantou.Framework.Win32.Natives
{
    [ComImport,
    Guid(IIDGuid.IShellItem),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IShellItem
    {
        void BindToHandler([In, MarshalAs(UnmanagedType.Interface)] IntPtr pbc, [In] ref Guid bhid, [In] ref Guid riid, out IntPtr ppv);

        void GetParent([MarshalAs(UnmanagedType.Interface)] out IShellItem ppsi);

        void GetDisplayName([In] SIGDN sigdnName, [MarshalAs(UnmanagedType.LPWStr)] out string ppszName);

        void GetAttributes([In] uint sfgaoMask, out uint psfgaoAttribs);

        void Compare([In, MarshalAs(UnmanagedType.Interface)] IShellItem psi, [In] uint hint, out int piOrder);
    }
}
