﻿using System.Collections.Generic;
using static mitama.Pages.Capture.Interop;

namespace mitama.Pages.Capture;

using System;
using System.Diagnostics;
using System.Text;

public partial class Interop {
    /// <summary>
    /// ウィンドウを列挙します。
    /// </summary>
    /// <param name="lpEnumFunc">コールバック関数</param>
    /// <param name="lParam">アプリケーション定義の値</param>
    /// <returns></returns>
    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    public static partial bool EnumWindows(EnumWinProc lpEnumFunc, IntPtr lParam);

    /// <summary>
    /// EnumWindowsから呼び出されるコールバック関数EnumWinProcのデリゲート
    /// </summary>
    /// <param name="hWnd">ウィンドウのハンドル</param>
    /// <param name="lParam">アプリケーション定義の値</param>
    /// <returns></returns>
    public delegate bool EnumWinProc(IntPtr hWnd, IntPtr lParam);

    /// <summary>
    /// ウィンドウハンドルからキャプションを取得します
    /// </summary>
    /// <param name="hWnd">ウィンドウのハンドル</param>
    /// <param name="lpString">キャプション</param>
    /// <param name="nMaxCount">キャプションの最大桁数</param>
    /// <returns></returns>
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    /// <summary>
    /// ウィンドウハンドルからプロセスＩＤを取得します。
    /// </summary>
    /// <param name="hWnd">ウィンドウのハンドル</param>
    /// <param name="lpdwProcessId">プロセスＩＤ</param>
    /// <returns></returns>
    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    // ReSharper disable once IdentifierTypo
    public static partial int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

    /// <summary>
    /// ウィンドウが可視かどうかを調べます。
    /// </summary>
    /// <param name="hWnd">ウィンドウのハンドル</param>
    /// <returns></returns>
    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    public static partial bool IsWindowVisible(IntPtr hWnd);
}

public class Search {
    public static IntPtr WindowHandleFromCaption(string target) {
        nint result = -1;
        // ウィンドウの列挙を開始
        EnumWindows((hWnd, _) => {
            var caption = Caption(hWnd);
            if (IsWindowVisible(hWnd) && caption.Contains(target)) {
                result = hWnd;
            }

            return true;
        }, IntPtr.Zero);

        return result > 0 ? result : throw new KeyNotFoundException("Assaultlily Not Found");
    }

    public static List<(string, IntPtr)> GetWindowList() {
        List<(string, IntPtr)> result = new();
        // ウィンドウの列挙を開始
        EnumWindows((hWnd, _) => {
            if (IsWindowVisible(hWnd)) {
                result.Add((Caption(hWnd), hWnd));
            }

            return true;
        }, IntPtr.Zero);

        return result;
    }

    private static string Caption(IntPtr hWnd) {
        GetWindowThreadProcessId(hWnd, out var processId);

        // プロセスIDからProcessクラスのインスタンスを取得
        Process.GetProcessById(processId);

        // ウィンドウのキャプションを取得・表示
        var caption = new StringBuilder(0x1000);

        GetWindowText(hWnd, caption, caption.Capacity);

        return caption.ToString();
    }
}
