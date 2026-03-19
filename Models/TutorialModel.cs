
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TutorialModel {

public TutorialSkipResponse? Tutorial_Skip() {
    // no request
    return TutorialSkipResponse.Parser.ParseJson(
        sembaWrapper.Call("/tutorial/skip", "")
    );
}


private ISembaWrapper sembaWrapper;

public TutorialModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
