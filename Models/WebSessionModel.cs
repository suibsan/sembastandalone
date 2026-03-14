
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class WebSessionModel {

public static WebSessionTokenResponse? WebSession_Token() {
    // no request
    return WebSessionTokenResponse.Parser.ParseJson(
        SembaWrapper.Call("/web_session/token", "")
    );
}

}
