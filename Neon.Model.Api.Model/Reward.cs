
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Reward {
    [ProtoMember(1)]
    public int type { get; set; }

    [ProtoMember(2)]
    public int id { get; set; }

    [ProtoMember(3)]
    public int quantity { get; set; }

    [ProtoMember(4)]
    public int entityId { get; set; }

    [ProtoMember(5)]
    public ResourceParams resourceParams { get; set; }

    [ProtoMember(6)]
    public bool isNew { get; set; }

    [ProtoMember(7)]
    public bool isBonus { get; set; }

    [ProtoMember(10)]
    public bool overflowed { get; set; }

    [ProtoMember(12)]
    public int discardedQuantity { get; set; }

    [ProtoMember(8)]
    public bool sentAsMail { get; set; }

    [ProtoMember(9)]
    public int oldValue { get; set; }

    [ProtoMember(11)]
    public Reward[] otherRewards { get; set; }

}