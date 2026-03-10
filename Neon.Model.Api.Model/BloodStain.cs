
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStain {
    [ProtoMember(9)]
    public required long userId { get; set; }

    [ProtoMember(10)]
    public required string userName { get; set; }

    [ProtoMember(11)]
    public required PositionCoordinates positionCoordinates { get; set; }

    [ProtoMember(1)]
    public required int? areaEnemyId { get; set; }

    [ProtoMember(2)]
    public required int? fieldBossId { get; set; }

    [ProtoMember(8)]
    public required int? dungeonId { get; set; }

    [ProtoMember(3)]
    public required int? fractalViseBossDifficultyId { get; set; }

    [ProtoMember(5)]
    public required BloodStainCharacter[] characters { get; set; }

    [ProtoMember(6)]
    public required BloodStainTensionCard[] tensionCards { get; set; }

}