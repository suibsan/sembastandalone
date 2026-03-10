
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbFormationUpdateResponse {
    [ProtoMember(1)]
    public required XbMember[] playerMembers { get; set; }

}