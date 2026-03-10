
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class AdventureReadSequenceResponse {
    [ProtoMember(1)]
    public AreaObject[] areaObjects { get; set; }

    [ProtoMember(2)]
    public Rewards[] rewards { get; set; }

    [ProtoMember(3)]
    public Resources changedResources { get; set; }

    [ProtoMember(6)]
    public int[] deletedCharacterIds { get; set; }

}