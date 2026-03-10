
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequestListResponse {
    [ProtoMember(1)]
    public required ItemRequest[] itemRequests { get; set; }

    [ProtoMember(2)]
    public required FollowUser[] users { get; set; }

    [ProtoMember(3)]
    public required int deliveryCount { get; set; }

}