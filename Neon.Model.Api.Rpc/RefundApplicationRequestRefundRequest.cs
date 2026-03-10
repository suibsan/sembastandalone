
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundApplicationRequestRefundRequest {
    [ProtoMember(1)]
    public required bool isSkipItunesGoogleplay { get; set; }

    [ProtoMember(2)]
    public required RefundDestinationBank bank { get; set; }

    [ProtoMember(3)]
    public required RefundDestinationPaypal paypal { get; set; }

    [ProtoMember(4)]
    public required RefundDestinationWise wise { get; set; }

    [ProtoMember(5)]
    public required RefundDestinationOverseaBank overseaBank { get; set; }

}