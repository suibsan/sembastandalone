
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ItemExchangeRequest {
    [ProtoMember(1)]
    public required int itemExchangeId { get; set; }

    [ProtoMember(2)]
    public required int count { get; set; }

    [ProtoMember(3)]
    public required int[] consumedItemIds { get; set; }

    [ProtoMember(4)]
    public required CurrentLocation currentLocation { get; set; }

}