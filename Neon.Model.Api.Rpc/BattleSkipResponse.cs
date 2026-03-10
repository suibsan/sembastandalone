
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleSkipResponse {
    [ProtoMember(3)]
    public required Rewards[] rewards { get; set; }

    [ProtoMember(5)]
    public required Resource[] ignoredRewards { get; set; }

    [ProtoMember(2)]
    public required Resources changedResources { get; set; }

    [ProtoMember(4)]
    public required CharacterExp[] characterExps { get; set; }

    [ProtoMember(6)]
    public required AreaObject[] areaObjects { get; set; }

}