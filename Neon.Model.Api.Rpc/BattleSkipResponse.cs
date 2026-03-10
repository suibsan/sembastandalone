
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleSkipResponse {
    [ProtoMember(3)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(5)]
    public Resource[] ignoredRewards { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

    [ProtoMember(4)]
    public CharacterExp[] characterExps { get; set; }

    [ProtoMember(6)]
    public AreaObject[] areaObjects { get; set; }

}