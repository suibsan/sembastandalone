
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsReceiveResponse {
    [ProtoMember(1)]
    public required FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(2)]
    public required FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(3)]
    public required Reward[] rewards { get; set; }

    [ProtoMember(4)]
    public required Resources changedResources { get; set; }

}