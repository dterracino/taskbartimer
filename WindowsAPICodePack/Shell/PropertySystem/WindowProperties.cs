//Copyright (c) Microsoft Corporation.  All rights reserved.

using System;
using System.Windows;
using System.Windows.Interop;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace Microsoft.WindowsAPICodePack.Shell.PropertySystem
{
    /// <summary>
    /// Helper class to modify properties for a given window
    /// </summary>
    public class WindowProperties
    {
        /// <summary>
        /// Sets a shell property for a given window
        /// </summary>
        /// <param name="propkey">The property to set</param>
        /// <param name="windowHandle">Handle to the window that the property will be set on</param>
        /// <param name="value">The value to set for the property</param>
        public static void SetWindowProperty(IntPtr windowHandle, PropertyKey propkey, string value)
        {
            TaskbarNativeMethods.SetWindowProperty(windowHandle, propkey, value);
        }

        /// <summary>
        /// Sets a shell property for a given window
        /// </summary>
        /// <param name="propkey">The property to set</param>
        /// <param name="window">Window that the property will be set on</param>
        /// <param name="value">The value to set for the property</param>
        public static void SetWindowProperty(Window window, PropertyKey propkey, string value)
        {
            TaskbarNativeMethods.SetWindowProperty((new WindowInteropHelper(window)).Handle, propkey, value);
        }
    }
}
