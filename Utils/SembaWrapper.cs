namespace sembastandalone.Utils;

using System.Runtime.InteropServices;
using System.Text.Json;

public class SembaWrapper {
    public static JsonSerializerOptions options = new JsonSerializerOptions(
        JsonSerializerDefaults.Web
    );

    public static void Init(string dbPath) {
        Semba.NimMain();
        var dbPathUtf8 = Marshal.StringToCoTaskMemUTF8(dbPath);
        Semba.SembaInitOfflineDb(dbPathUtf8);
        Marshal.FreeCoTaskMem(dbPathUtf8);
    }

    public static ResType? Call<ResType, ReqType>(string path, ReqType request) {
        var pathUtf8 = Marshal.StringToCoTaskMemUTF8(path);
        var reqJsonUtf8 = Marshal.StringToCoTaskMemUTF8(JsonSerializer.Serialize(request, options));
        // FIXME: add a SembaFree in libsemba
        var resUtf8 = Semba.SembaCall(pathUtf8, reqJsonUtf8);
        Marshal.FreeCoTaskMem(pathUtf8);
        Marshal.FreeCoTaskMem(reqJsonUtf8);
        var resJson = Marshal.PtrToStringUTF8(resUtf8);
        return (resJson != null) ? JsonSerializer.Deserialize<ResType>(resJson, options) : default(ResType);
    }

    public static ResType? Call<ResType>(string path) {
        var pathUtf8 = Marshal.StringToCoTaskMemUTF8(path);
        var reqJsonUtf8 = Marshal.StringToCoTaskMemUTF8("");
        // FIXME: add a SembaFree in libsemba
        var resUtf8 = Semba.SembaCall(pathUtf8, reqJsonUtf8);
        Marshal.FreeCoTaskMem(pathUtf8);
        Marshal.FreeCoTaskMem(reqJsonUtf8);
        var resJson = Marshal.PtrToStringUTF8(resUtf8);
        return (resJson != null) ? JsonSerializer.Deserialize<ResType>(resJson, options) : default(ResType);
    }
}