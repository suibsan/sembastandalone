
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class TutorialModel {

public static TutorialSkipResponse? Tutorial_Skip() {
    // no request
    return TutorialSkipResponse.Parser.ParseJson(
        SembaWrapper.Call("/tutorial/skip", "")
    );
}

}
