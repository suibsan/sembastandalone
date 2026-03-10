
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowAddResponse {
    [ProtoMember(1)]
    public DateTime? followedAt { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}