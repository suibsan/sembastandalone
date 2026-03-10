
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TensionCard {
    [ProtoMember(1)]
    public int tensionCardId { get; set; }

    [ProtoMember(8)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int exp { get; set; }

    [ProtoMember(3)]
    public int limitBreak { get; set; }

    [ProtoMember(4)]
    public DateTime? receivedAt { get; set; }

    [ProtoMember(5)]
    public int maxLevel { get; set; }

    [ProtoMember(6)]
    public AbilityEfficacy[] abilityEfficacies { get; set; }

    [ProtoMember(7)]
    public int trainingScoreLevelScore { get; set; }

    [ProtoMember(9)]
    public bool isLocked { get; set; }

}