
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemExchangeRequest {
    [ProtoMember(1)]
    public int itemExchangeId { get; set; }

    [ProtoMember(2)]
    public int count { get; set; }

    [ProtoMember(3)]
    public int[] consumedItemIds { get; set; }

    [ProtoMember(4)]
    public CurrentLocation currentLocation { get; set; }

}