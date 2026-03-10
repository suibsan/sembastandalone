
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Formation {
    [ProtoMember(1)]
    public required int number { get; set; }

    [ProtoMember(3)]
    public required FormationMembers members { get; set; }

    [ProtoMember(4)]
    public required FormationCards cards { get; set; }

}