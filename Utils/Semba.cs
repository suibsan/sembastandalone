namespace sembastandalone.Utils;

using System.Runtime.InteropServices;

public class Semba {
    // extern void NimMain(void);
    [DllImport("libsemba")]
    public static extern void NimMain();

    // extern struct SembaExContext *SembaExInit(const char *dbPath, int32_t gameVersion, int32_t *status);
    [DllImport("libsemba")]
    public static extern IntPtr SembaExInit(IntPtr dbPath, int gameVersion, IntPtr status);

    // extern char *SembaExCall(struct SembaExContext *ctx, const char *path, const char *req, int32_t *status);
    [DllImport("libsemba")]
    public static extern IntPtr SembaExCall(IntPtr ctx, IntPtr path, IntPtr req, IntPtr status);

    // extern void SembaExFreeResponse(char *response);
    [DllImport("libsemba")]
    public static extern void SembaExFreeResponse(IntPtr response);

    // extern void SembaExDeinit(struct SembaExContext *ctx);
    [DllImport("libsemba")]
    public static extern void SembaExDeinit(IntPtr ctx);
}