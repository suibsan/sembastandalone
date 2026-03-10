
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowDetailResponse {
    [ProtoMember(1)]
    public CharacterLikability[] characterLikabilities { get; set; }

}