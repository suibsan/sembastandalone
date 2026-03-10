
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class CycleUpdateShopState {
    [ProtoMember(1)]
    public int cycleUpdateShopId { get; set; }

    [ProtoMember(4)]
    public bool isReleased { get; set; }

    [ProtoMember(2)]
    public int purchasedCount { get; set; }

    [ProtoMember(3)]
    public DateTime? lastPurchasedAt { get; set; }

}