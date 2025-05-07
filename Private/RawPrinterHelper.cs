using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

public class RawPrinterHelper {
    [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true)]
    private static extern bool OpenPrinter(string szPrinter, out IntPtr hPrinter, IntPtr pd);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool ClosePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool StartDocPrinter(IntPtr hPrinter, int level, [In] ref DOCINFOA di);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool EndDocPrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool StartPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool EndPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", SetLastError = true)]
    private static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, int dwCount, out int dwWritten);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DOCINFOA {
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataType;
    }

    public static bool SendStringToPrinter(string printerName, string text) {
        IntPtr pBytes;
        IntPtr hPrinter;
        DOCINFOA di = new DOCINFOA { pDocName = "Test Comanda", pDataType = "RAW" };
        bool success = false;

        byte[] bytes = System.Text.Encoding.ASCII.GetBytes(text);
        pBytes = Marshal.AllocCoTaskMem(bytes.Length);
        Marshal.Copy(bytes, 0, pBytes, bytes.Length);

        if (OpenPrinter(printerName.Normalize(), out hPrinter, IntPtr.Zero)) {
            if (StartDocPrinter(hPrinter, 1, ref di)) {
                if (StartPagePrinter(hPrinter)) {
                    success = WritePrinter(hPrinter, pBytes, bytes.Length, out _);
                    EndPagePrinter(hPrinter);
                }
                EndDocPrinter(hPrinter);
            }
            ClosePrinter(hPrinter);
        }

        Marshal.FreeCoTaskMem(pBytes);
        return success;
    }
}
