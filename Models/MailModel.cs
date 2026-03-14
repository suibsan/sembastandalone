
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class MailModel {

public static MailDeleteResponse? Mail_Delete(MailDeleteRequest req) {
    Console.WriteLine($"Mail_Delete: {req}");
    return MailDeleteResponse.Parser.ParseJson(
        SembaWrapper.Call("/mail/delete", req.ToString())
    );
}


public static MailListResponse? Mail_List() {
    // no request
    return MailListResponse.Parser.ParseJson(
        SembaWrapper.Call("/mail/list", "")
    );
}


public static MailOpenResponse? Mail_Open(MailOpenRequest req) {
    Console.WriteLine($"Mail_Open: {req}");
    return MailOpenResponse.Parser.ParseJson(
        SembaWrapper.Call("/mail/open", req.ToString())
    );
}

}
