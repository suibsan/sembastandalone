
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class GachaCategoryState {
    [ProtoMember(1)]
    public required int gachaCategoryId { get; set; }

    [ProtoMember(2)]
    public required int guaranteedCount { get; set; }

    [ProtoMember(3)]
    public required bool isGuaranteedPickup { get; set; }

    [ProtoMember(4)]
    public required int executionCount { get; set; }

    [ProtoMember(5)]
    public required bool isSelectable { get; set; }

}