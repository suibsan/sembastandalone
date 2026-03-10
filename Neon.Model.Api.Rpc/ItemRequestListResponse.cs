
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemRequestListResponse {
    [ProtoMember(1)]
    public ItemRequest[] itemRequests { get; set; }

    [ProtoMember(2)]
    public FollowUser[] users { get; set; }

    [ProtoMember(3)]
    public int deliveryCount { get; set; }

}