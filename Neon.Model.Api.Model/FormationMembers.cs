
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FormationMembers {
    [ProtoMember(1)]
    public int? character1Id { get; set; }

    [ProtoMember(2)]
    public int? character2Id { get; set; }

    [ProtoMember(3)]
    public int? character3Id { get; set; }

    [ProtoMember(4)]
    public int? character1OwnershipType { get; set; }

    [ProtoMember(5)]
    public int? character2OwnershipType { get; set; }

    [ProtoMember(6)]
    public int? character3OwnershipType { get; set; }

}