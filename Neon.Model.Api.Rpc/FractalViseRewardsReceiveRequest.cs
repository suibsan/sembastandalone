
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsReceiveRequest {
    [ProtoMember(1)]
    public FractalViseRewardsReceiveMissionParam receiveMission { get; set; }

    [ProtoMember(2)]
    public bool isReceiveTotalScoreRewards { get; set; }

}