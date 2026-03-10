
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FormationCards {
    [ProtoMember(1)]
    public required int? tensionCard1Id { get; set; }

    [ProtoMember(2)]
    public required int? tensionCard2Id { get; set; }

    [ProtoMember(3)]
    public required int? tensionCard3Id { get; set; }

    [ProtoMember(4)]
    public required int? tensionCard4Id { get; set; }

    [ProtoMember(5)]
    public required int? tensionCard5Id { get; set; }

}