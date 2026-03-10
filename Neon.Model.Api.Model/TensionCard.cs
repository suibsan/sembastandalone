
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TensionCard {
    [ProtoMember(1)]
    public required int tensionCardId { get; set; }

    [ProtoMember(8)]
    public required int entityId { get; set; }

    [ProtoMember(2)]
    public required int exp { get; set; }

    [ProtoMember(3)]
    public required int limitBreak { get; set; }

    [ProtoMember(4)]
    public required DateTime? receivedAt { get; set; }

    [ProtoMember(5)]
    public required int maxLevel { get; set; }

    [ProtoMember(6)]
    public required AbilityEfficacy[] abilityEfficacies { get; set; }

    [ProtoMember(7)]
    public required int trainingScoreLevelScore { get; set; }

    [ProtoMember(9)]
    public required bool isLocked { get; set; }

}