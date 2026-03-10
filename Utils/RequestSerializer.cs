namespace sembastandalone.Utils;

using System.Web;
using Microsoft.AspNetCore.Mvc;
using ProtoBuf;

public class RequestSerializer {
    private static async Task<byte[]> GetBodyAsync(HttpRequest req) {
        using (var ms = new MemoryStream()) {
            await req.Body.CopyToAsync(ms);
            return ms.ToArray();
        }
    }

    public static async Task<T> Deserialize<T>(HttpRequest req) {
        var data = await GetBodyAsync(req);
        var decData = Encryptor.DecryptData(data);
        return Serializer.Deserialize<T>(new ReadOnlySpan<byte>(decData));
    }

    public static FileContentResult Serialize<T>(T obj) {
        using (var ms = new MemoryStream()) {
            Serializer.Serialize(ms, obj);
            var data = ms.ToArray();
            var encData = Encryptor.EncryptData(data, 0);
            return new FileContentResult(encData, "application/octet-stream");
        }
    }
}