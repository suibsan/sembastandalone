
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopProductState {
    [ProtoMember(1)]
    public required int shopProductId { get; set; }

    [ProtoMember(2)]
    public required int purchasedCount { get; set; }

    [ProtoMember(3)]
    public required DateTime? nextResetAt { get; set; }

}