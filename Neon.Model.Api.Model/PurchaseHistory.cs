
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseHistory {
    [ProtoMember(1)]
    public required string name { get; set; }

    [ProtoMember(3)]
    public required DateTime? gameTime { get; set; }

    [ProtoMember(4)]
    public required int moneyAmount { get; set; }

    [ProtoMember(5)]
    public required int freeAmount { get; set; }

    [ProtoMember(6)]
    public required double? clientPrice { get; set; }

    [ProtoMember(7)]
    public required string clientCurrency { get; set; }

}