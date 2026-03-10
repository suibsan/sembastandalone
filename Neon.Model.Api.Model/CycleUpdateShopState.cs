
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CycleUpdateShopState {
    [ProtoMember(1)]
    public required int cycleUpdateShopId { get; set; }

    [ProtoMember(4)]
    public required bool isReleased { get; set; }

    [ProtoMember(2)]
    public required int purchasedCount { get; set; }

    [ProtoMember(3)]
    public required DateTime? lastPurchasedAt { get; set; }

}