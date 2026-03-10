
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class RefundPaidGem {
    [ProtoMember(1)]
    public required int quantity { get; set; }

    [ProtoMember(2)]
    public required string[] purchaseCurrencies { get; set; }

}