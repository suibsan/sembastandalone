
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class SubsystemModel {

public SubsystemStatusResponse? Subsystem_Status() {
    // no request
    return SubsystemStatusResponse.Parser.ParseJson(
        sembaWrapper.Call("/subsystem/status", "")
    );
}


private ISembaWrapper sembaWrapper;

public SubsystemModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
