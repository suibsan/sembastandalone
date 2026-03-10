
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowRemoveResponse {
    [ProtoMember(1)]
    public required ResourceEntities deletedResources { get; set; }

}