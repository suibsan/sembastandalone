
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class UserLinkAppleRequest {
    [ProtoMember(1)]
    public required string idToken { get; set; }

}