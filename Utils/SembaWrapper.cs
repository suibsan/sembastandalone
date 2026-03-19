namespace sembastandalone.Utils;

using System.Runtime.InteropServices;
using Google.Protobuf;

public enum SembaStatus {
    StatusOk = 0,
    StatusException = 1,
    StatusVersionUnknown = 2,
    StatusDbError = 3,
    StatusAllocError = 4,
    StatusInvalidContext = 5,
}

public enum SembaGameVersion {
    GameVersion_1_1_3_35 = 0,
    GameVersion_0_2_1_20 = 1,
}

public class SembaError : Exception
{
    public SembaError()
    {
    }

    public static SembaError CreateFromStatus(SembaStatus status, string? msg) {
        switch (status) {
        case SembaStatus.StatusOk:
            throw new ArgumentException("status == StatusOk");
        case SembaStatus.StatusException:
            return new SembaError($"Nim Exception: {msg}");
        case SembaStatus.StatusVersionUnknown:
            return new SembaError("Unknown game version");
        case SembaStatus.StatusDbError:
            return new SembaError("Failed to open the db");
        case SembaStatus.StatusAllocError:
            return new SembaError("Failed to allocate SembaContext");
        case SembaStatus.StatusInvalidContext:
            return new SembaError("The context passed is null");
        default:
            throw new ArgumentException("Invalid status");
        }
    }

    public SembaError(string message)
        : base(message)
    {
    }

    public SembaError(string message, Exception inner)
        : base(message, inner)
    {
    }
}

public interface ISembaWrapper {
    public string? Call(string path, string req);
}

public class SembaWrapper : ISembaWrapper {
    private IntPtr ctx;

    static SembaWrapper() {
        Semba.NimMain();
    }

    public SembaWrapper() : this("semba.db", SembaGameVersion.GameVersion_1_1_3_35) {
    }

    public SembaWrapper(string dbPath, SembaGameVersion gameVersion) {
        var dbPathUtf8 = Marshal.StringToCoTaskMemUTF8(dbPath);

        var statusPtr = Marshal.AllocCoTaskMem(sizeof(int));

        ctx = Semba.SembaExInit(dbPathUtf8, (int)gameVersion, statusPtr);

        var status = Marshal.ReadInt32(statusPtr);

        Marshal.FreeCoTaskMem(statusPtr);
        Marshal.FreeCoTaskMem(dbPathUtf8);

        if ((SembaStatus)status != SembaStatus.StatusOk) {
            throw SembaError.CreateFromStatus((SembaStatus)status, "");
        }
    }

    public string? Call(string path, string req) {
        var pathUtf8 = Marshal.StringToCoTaskMemUTF8(path);
        var reqJsonUtf8 = Marshal.StringToCoTaskMemUTF8(req);

        var statusPtr = Marshal.AllocCoTaskMem(sizeof(int));

        var resUtf8 = Semba.SembaExCall(ctx, pathUtf8, reqJsonUtf8, statusPtr);
        var res = Marshal.PtrToStringUTF8(resUtf8);

        Semba.SembaExFreeResponse(resUtf8);

        Marshal.FreeCoTaskMem(pathUtf8);
        Marshal.FreeCoTaskMem(reqJsonUtf8);

        var status = Marshal.ReadInt32(statusPtr);
        Marshal.FreeCoTaskMem(statusPtr);

        if ((SembaStatus)status != SembaStatus.StatusOk) {
            throw SembaError.CreateFromStatus((SembaStatus)status, res);
        }

        return res;
    }
}