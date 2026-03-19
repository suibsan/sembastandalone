
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class MissionModel {

public MissionCountRewardReceiveResponse? Mission_CountRewardReceive(MissionCountRewardReceiveRequest req) {
    Console.WriteLine($"Mission_CountRewardReceive: {req}");
    return MissionCountRewardReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/mission/count_reward_receive", req.ToString())
    );
}


public MissionReceiveResponse? Mission_Receive(MissionReceiveRequest req) {
    Console.WriteLine($"Mission_Receive: {req}");
    return MissionReceiveResponse.Parser.ParseJson(
        sembaWrapper.Call("/mission/receive", req.ToString())
    );
}


private ISembaWrapper sembaWrapper;

public MissionModel(ISembaWrapper wrapper) {
    sembaWrapper = wrapper;
}

}
