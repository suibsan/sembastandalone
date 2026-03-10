
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopProduct {
    [ProtoMember(1)]
    public required int id { get; set; }

    [ProtoMember(17)]
    public required int shopId { get; set; }

    [ProtoMember(16)]
    public required PurchaseStep[] purchaseSteps { get; set; }

    [ProtoMember(2)]
    public required int? dailyPassId { get; set; }

    [ProtoMember(7)]
    public required int limitCount { get; set; }

    [ProtoMember(8)]
    public required int? resetCycle { get; set; }

    [ProtoMember(19)]
    public required int resetPeriod { get; set; }

    [ProtoMember(9)]
    public required int priority { get; set; }

    [ProtoMember(3)]
    public required KeyTask[] keyTasks { get; set; }

    [ProtoMember(10)]
    public required DateTime? startAt { get; set; }

    [ProtoMember(11)]
    public required DateTime? endAt { get; set; }

    [ProtoMember(4)]
    public required string imagePath { get; set; }

}