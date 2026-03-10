
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowListResponse {
    [ProtoMember(1)]
    public required FollowUser[] users { get; set; }

}