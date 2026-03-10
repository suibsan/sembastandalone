
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Formation {
    [ProtoMember(1)]
    public int number { get; set; }

    [ProtoMember(3)]
    public FormationMembers members { get; set; }

    [ProtoMember(4)]
    public FormationCards cards { get; set; }

}