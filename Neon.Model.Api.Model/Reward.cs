
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Reward {
    [ProtoMember(1)]
    public required int type { get; set; }

    [ProtoMember(2)]
    public required int id { get; set; }

    [ProtoMember(3)]
    public required int quantity { get; set; }

    [ProtoMember(4)]
    public required int entityId { get; set; }

    [ProtoMember(5)]
    public required ResourceParams resourceParams { get; set; }

    [ProtoMember(6)]
    public required bool isNew { get; set; }

    [ProtoMember(7)]
    public required bool isBonus { get; set; }

    [ProtoMember(10)]
    public required bool overflowed { get; set; }

    [ProtoMember(12)]
    public required int discardedQuantity { get; set; }

    [ProtoMember(8)]
    public required bool sentAsMail { get; set; }

    [ProtoMember(9)]
    public required int oldValue { get; set; }

    [ProtoMember(11)]
    public required Reward[] otherRewards { get; set; }

}