namespace sembastandalone.Utils;

using System.Runtime.InteropServices;
using Google.Protobuf;

public class SembaWrapper {
    public static void Init(string dbPath) {
        Semba.NimMain();
        var dbPathUtf8 = Marshal.StringToCoTaskMemUTF8(dbPath);
        Semba.SembaInitOfflineDb(dbPathUtf8);
        Marshal.FreeCoTaskMem(dbPathUtf8);
    }

    public static string? Call(string path, string req) {
        var pathUtf8 = Marshal.StringToCoTaskMemUTF8(path);
        var reqJsonUtf8 = Marshal.StringToCoTaskMemUTF8(req);
        // FIXME: add a SembaFree in libsemba
        var resUtf8 = Semba.SembaCall(pathUtf8, reqJsonUtf8);
        Marshal.FreeCoTaskMem(pathUtf8);
        Marshal.FreeCoTaskMem(reqJsonUtf8);
        return Marshal.PtrToStringUTF8(resUtf8);
    }
}