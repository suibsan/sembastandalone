namespace sembastandalone.Utils;

using System.Runtime.InteropServices;

public class Semba {
    // extern void NimMain(void);
    [DllImport("libsemba.dll")]
    public static extern void NimMain();

    // extern char *SembaCall(const char *uri, const char *request);
    [DllImport("libsemba.dll")]
    public static extern IntPtr SembaCall(IntPtr uri, IntPtr request);

    // extern char *SembaCallDemo(const char *uri, const char *request);
    [DllImport("libsemba.dll")]
    public static extern IntPtr SembaCallDemo(IntPtr uri, IntPtr request);

    // extern void SembaInitOfflineDb(const char *path);
    [DllImport("libsemba.dll")]
    public static extern void SembaInitOfflineDb(IntPtr path);

    // extern void SembaSetRemoteUrl(const char *url);
    [DllImport("libsemba.dll")]
    public static extern void SembaSetRemoteUrl(IntPtr url);
}