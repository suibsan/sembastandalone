
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPassTierPurchaseRequest {
    [ProtoMember(1)]
    public int seasonId { get; set; }

    [ProtoMember(2)]
    public int purchaseCount { get; set; }

}