
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ShopProduct {
    [ProtoMember(1)]
    public int id { get; set; }

    [ProtoMember(17)]
    public int shopId { get; set; }

    [ProtoMember(16)]
    public PurchaseStep[] purchaseSteps { get; set; }

    [ProtoMember(2)]
    public int? dailyPassId { get; set; }

    [ProtoMember(7)]
    public int limitCount { get; set; }

    [ProtoMember(8)]
    public int? resetCycle { get; set; }

    [ProtoMember(19)]
    public int resetPeriod { get; set; }

    [ProtoMember(9)]
    public int priority { get; set; }

    [ProtoMember(3)]
    public KeyTask[] keyTasks { get; set; }

    [ProtoMember(10)]
    public DateTime? startAt { get; set; }

    [ProtoMember(11)]
    public DateTime? endAt { get; set; }

    [ProtoMember(4)]
    public string imagePath { get; set; }

}