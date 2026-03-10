
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureReadSequenceResponse {
    [ProtoMember(1)]
    public required AreaObject[] areaObjects { get; set; }

    [ProtoMember(2)]
    public required Rewards[] rewards { get; set; }

    [ProtoMember(3)]
    public required Resources changedResources { get; set; }

    [ProtoMember(6)]
    public required int[] deletedCharacterIds { get; set; }

}