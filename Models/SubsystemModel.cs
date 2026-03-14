
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class SubsystemModel {

public static SubsystemStatusResponse? Subsystem_Status() {
    // no request
    return SubsystemStatusResponse.Parser.ParseJson(
        SembaWrapper.Call("/subsystem/status", "")
    );
}

}
