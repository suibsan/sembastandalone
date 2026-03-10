
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FormationUpdateRequest {
    [ProtoMember(1)]
    public required int number { get; set; }

    [ProtoMember(2)]
    public required FormationMembers members { get; set; }

    [ProtoMember(3)]
    public required FormationCards cards { get; set; }

}