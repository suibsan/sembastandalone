
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbFormationUpdateRequest {
    [ProtoMember(1)]
    public required int xbId { get; set; }

    [ProtoMember(2)]
    public required XbMemberRequest[] playerMembers { get; set; }

}