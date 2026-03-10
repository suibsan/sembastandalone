
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class SeasonPassPurchasePaidPassRequest {
    [ProtoMember(1)]
    public int seasonId { get; set; }

    [ProtoMember(2)]
    public bool purchaseUpper { get; set; }

}