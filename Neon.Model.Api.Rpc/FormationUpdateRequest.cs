
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FormationUpdateRequest {
    [ProtoMember(1)]
    public int number { get; set; }

    [ProtoMember(2)]
    public FormationMembers members { get; set; }

    [ProtoMember(3)]
    public FormationCards cards { get; set; }

}