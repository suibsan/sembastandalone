
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FormationCards {
    [ProtoMember(1)]
    public int? tensionCard1Id { get; set; }

    [ProtoMember(2)]
    public int? tensionCard2Id { get; set; }

    [ProtoMember(3)]
    public int? tensionCard3Id { get; set; }

    [ProtoMember(4)]
    public int? tensionCard4Id { get; set; }

    [ProtoMember(5)]
    public int? tensionCard5Id { get; set; }

}