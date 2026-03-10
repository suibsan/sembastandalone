
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Gear {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int gearId { get; set; }

    [ProtoMember(4)]
    public DateTime? receivedAt { get; set; }

    [ProtoMember(17)]
    public int rarity { get; set; }

    [ProtoMember(5)]
    public bool isLocked { get; set; }

    [ProtoMember(7)]
    public int? subStatus1Id { get; set; }

    [ProtoMember(8)]
    public int? subStatus2Id { get; set; }

    [ProtoMember(9)]
    public int? subStatus3Id { get; set; }

    [ProtoMember(15)]
    public int trainingScoreLevelScore { get; set; }

}