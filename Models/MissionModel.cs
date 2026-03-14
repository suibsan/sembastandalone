
namespace sembastandalone.Models;

using Neon.Model.Api.Rpc;
using sembastandalone.Utils;

public class MissionModel {

public static MissionCountRewardReceiveResponse? Mission_CountRewardReceive(MissionCountRewardReceiveRequest req) {
    Console.WriteLine($"Mission_CountRewardReceive: {req}");
    return MissionCountRewardReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/mission/count_reward_receive", req.ToString())
    );
}


public static MissionReceiveResponse? Mission_Receive(MissionReceiveRequest req) {
    Console.WriteLine($"Mission_Receive: {req}");
    return MissionReceiveResponse.Parser.ParseJson(
        SembaWrapper.Call("/mission/receive", req.ToString())
    );
}

}
