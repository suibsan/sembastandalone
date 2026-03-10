
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundPurchase {
    [ProtoMember(1)]
    public RefundPurchaseItem[] itunesGoogleplay { get; set; }

    [ProtoMember(2)]
    public RefundPurchaseItem[] steam { get; set; }

    [ProtoMember(3)]
    public RefundPurchaseItem[] xsolla { get; set; }

}