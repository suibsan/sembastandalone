
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class WebSessionModel {

public WebSessionTokenResponse? WebSession_Token() {
    // no request
    return WebSessionTokenResponse.Parser.ParseJson(
        sembaWrapper.Call("/web_session/token", "")
    );
}


private ISembaWrapper sembaWrapper;

public WebSessionModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
