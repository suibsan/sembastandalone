
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class StoreProduct {
    [ProtoMember(6)]
    public required int id { get; set; }

    [ProtoMember(1)]
    public required string productId { get; set; }

    [ProtoMember(2)]
    public required int moneyAmount { get; set; }

    [ProtoMember(3)]
    public required int freeAmount { get; set; }

    [ProtoMember(4)]
    public required double? price { get; set; }

    [ProtoMember(5)]
    public required string currency { get; set; }

}