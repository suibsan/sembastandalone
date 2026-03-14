
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class HappyWorkerModel {

public static HappyWorkerCancelResponse? HappyWorker_Cancel(HappyWorkerCancelRequest req) {
    Console.WriteLine($"HappyWorker_Cancel: {req}");
    return HappyWorkerCancelResponse.Parser.ParseJson(
        SembaWrapper.Call("/happy_worker/cancel", req.ToString())
    );
}


public static HappyWorkerListResponse? HappyWorker_List(HappyWorkerListRequest req) {
    Console.WriteLine($"HappyWorker_List: {req}");
    return HappyWorkerListResponse.Parser.ParseJson(
        SembaWrapper.Call("/happy_worker/list", req.ToString())
    );
}


public static HappyWorkerStartResponse? HappyWorker_Start(HappyWorkerStartRequest req) {
    Console.WriteLine($"HappyWorker_Start: {req}");
    return HappyWorkerStartResponse.Parser.ParseJson(
        SembaWrapper.Call("/happy_worker/start", req.ToString())
    );
}

}
