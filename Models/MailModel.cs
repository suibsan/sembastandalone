namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class MailModel {
    public static MailListResponse? Mail_List() {
        return MailListResponse.Parser.ParseJson(
            SembaWrapper.Call("/mail/list", "")
        );
    }
}