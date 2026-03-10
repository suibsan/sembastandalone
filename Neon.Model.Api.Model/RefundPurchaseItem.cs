
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundPurchaseItem {
    [ProtoMember(2)]
    public string clientCurrency { get; set; }

    [ProtoMember(3)]
    public double clientPrice { get; set; }

}