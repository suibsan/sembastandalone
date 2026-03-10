
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class PurchaseHistory {
    [ProtoMember(1)]
    public string name { get; set; }

    [ProtoMember(3)]
    public DateTime? gameTime { get; set; }

    [ProtoMember(4)]
    public int moneyAmount { get; set; }

    [ProtoMember(5)]
    public int freeAmount { get; set; }

    [ProtoMember(6)]
    public double? clientPrice { get; set; }

    [ProtoMember(7)]
    public string clientCurrency { get; set; }

}