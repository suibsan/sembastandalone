
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class MailModel {

public MailDeleteResponse? Mail_Delete(MailDeleteRequest req) {
    Console.WriteLine($"Mail_Delete: {req}");
    return MailDeleteResponse.Parser.ParseJson(
        sembaWrapper.Call("/mail/delete", req.ToString())
    );
}


public MailListResponse? Mail_List() {
    // no request
    return MailListResponse.Parser.ParseJson(
        sembaWrapper.Call("/mail/list", "")
    );
}


public MailOpenResponse? Mail_Open(MailOpenRequest req) {
    Console.WriteLine($"Mail_Open: {req}");
    return MailOpenResponse.Parser.ParseJson(
        sembaWrapper.Call("/mail/open", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public MailModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
