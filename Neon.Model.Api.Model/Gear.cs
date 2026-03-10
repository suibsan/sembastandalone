
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Gear {
    [ProtoMember(1)]
    public required int entityId { get; set; }

    [ProtoMember(2)]
    public required int gearId { get; set; }

    [ProtoMember(4)]
    public required DateTime? receivedAt { get; set; }

    [ProtoMember(17)]
    public required int rarity { get; set; }

    [ProtoMember(5)]
    public required bool isLocked { get; set; }

    [ProtoMember(7)]
    public required int? subStatus1Id { get; set; }

    [ProtoMember(8)]
    public required int? subStatus2Id { get; set; }

    [ProtoMember(9)]
    public required int? subStatus3Id { get; set; }

    [ProtoMember(15)]
    public required int trainingScoreLevelScore { get; set; }

}