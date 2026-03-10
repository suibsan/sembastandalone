
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseRewardsTopResponse {
    [ProtoMember(1)]
    public int? fractalViseId { get; set; }

    [ProtoMember(2)]
    public FractalViseTotalScore fractalViseTotalScore { get; set; }

    [ProtoMember(3)]
    public FractalViseMission[] fractalViseMissions { get; set; }

    [ProtoMember(7)]
    public bool isChallengeableFractalViseBoss { get; set; }

    [ProtoMember(4)]
    public Reward[] rewards { get; set; }

    [ProtoMember(5)]
    public Resources changedResources { get; set; }

}