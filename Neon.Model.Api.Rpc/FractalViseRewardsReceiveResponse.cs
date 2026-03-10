
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsReceiveResponse {
    [ProtoMember(1)]
    public FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(2)]
    public FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(3)]
    public Reward[] rewards { get; set; }

    [ProtoMember(4)]
    public Resources changedResources { get; set; }

}