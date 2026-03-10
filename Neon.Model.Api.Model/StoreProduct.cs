
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class StoreProduct {
    [ProtoMember(6)]
    public int id { get; set; }

    [ProtoMember(1)]
    public string productId { get; set; }

    [ProtoMember(2)]
    public int moneyAmount { get; set; }

    [ProtoMember(3)]
    public int freeAmount { get; set; }

    [ProtoMember(4)]
    public double? price { get; set; }

    [ProtoMember(5)]
    public string currency { get; set; }

}