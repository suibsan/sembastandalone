
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationRequestRefundRequest {
    [ProtoMember(1)]
    public bool isSkipItunesGoogleplay { get; set; }

    [ProtoMember(2)]
    public RefundDestinationBank bank { get; set; }

    [ProtoMember(3)]
    public RefundDestinationPaypal paypal { get; set; }

    [ProtoMember(4)]
    public RefundDestinationWise wise { get; set; }

    [ProtoMember(5)]
    public RefundDestinationOverseaBank overseaBank { get; set; }

}