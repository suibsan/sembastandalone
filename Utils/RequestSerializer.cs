namespace sembastandalone.Utils;

using System.Web;
using Microsoft.AspNetCore.Mvc;
using Google.Protobuf;
using System.Reflection;

public class RequestSerializer {
    public static async Task<byte[]> GetBodyAsync(HttpRequest req) {
        using (var ms = new MemoryStream()) {
            await req.Body.CopyToAsync(ms);
            return ms.ToArray();
        }
    }

    public static async Task<T> Deserialize<T>(HttpRequest req) where T : IMessage, new() {
        var data = await GetBodyAsync(req);
        var decData = Encryptor.DecryptData(data);

        T res = new T();
        res.MergeFrom(decData);

        return res;
    }

    public static FileContentResult Serialize<T>(T obj) where T : IMessage {
        using (var ms = new MemoryStream()) {
            obj.WriteTo(ms);
            var data = ms.ToArray();
            var encData = Encryptor.EncryptData(data, 0);
            return new FileContentResult(encData, "application/octet-stream");
        }
    }
}