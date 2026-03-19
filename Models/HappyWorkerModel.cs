
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class HappyWorkerModel {

public HappyWorkerCancelResponse? HappyWorker_Cancel(HappyWorkerCancelRequest req) {
    Console.WriteLine($"HappyWorker_Cancel: {req}");
    return HappyWorkerCancelResponse.Parser.ParseJson(
        sembaWrapper.Call("/happy_worker/cancel", req.ToString())
    );
}


public HappyWorkerListResponse? HappyWorker_List(HappyWorkerListRequest req) {
    Console.WriteLine($"HappyWorker_List: {req}");
    return HappyWorkerListResponse.Parser.ParseJson(
        sembaWrapper.Call("/happy_worker/list", req.ToString())
    );
}


public HappyWorkerStartResponse? HappyWorker_Start(HappyWorkerStartRequest req) {
    Console.WriteLine($"HappyWorker_Start: {req}");
    return HappyWorkerStartResponse.Parser.ParseJson(
        sembaWrapper.Call("/happy_worker/start", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public HappyWorkerModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
