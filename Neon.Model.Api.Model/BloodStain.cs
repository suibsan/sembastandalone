
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStain {
    [ProtoMember(9)]
    public long userId { get; set; }

    [ProtoMember(10)]
    public string userName { get; set; }

    [ProtoMember(11)]
    public PositionCoordinates positionCoordinates { get; set; }

    [ProtoMember(1)]
    public int? areaEnemyId { get; set; }

    [ProtoMember(2)]
    public int? fieldBossId { get; set; }

    [ProtoMember(8)]
    public int? dungeonId { get; set; }

    [ProtoMember(3)]
    public int? fractalViseBossDifficultyId { get; set; }

    [ProtoMember(5)]
    public BloodStainCharacter[] characters { get; set; }

    [ProtoMember(6)]
    public BloodStainTensionCard[] tensionCards { get; set; }

}