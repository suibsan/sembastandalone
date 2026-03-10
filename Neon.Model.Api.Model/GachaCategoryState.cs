
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaCategoryState {
    [ProtoMember(1)]
    public int gachaCategoryId { get; set; }

    [ProtoMember(2)]
    public int guaranteedCount { get; set; }

    [ProtoMember(3)]
    public bool isGuaranteedPickup { get; set; }

    [ProtoMember(4)]
    public int executionCount { get; set; }

    [ProtoMember(5)]
    public bool isSelectable { get; set; }

}