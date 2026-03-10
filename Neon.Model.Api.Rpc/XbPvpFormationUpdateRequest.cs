
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvpFormationUpdateRequest {
    [ProtoMember(1)]
    public XbPvpMemberRequest[] playerMembers { get; set; }

}