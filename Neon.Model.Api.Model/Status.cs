
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Status {
    [ProtoMember(1)]
    public int exp { get; set; }

    [ProtoMember(2)]
    public int rank { get; set; }

    [ProtoMember(3)]
    public int gold { get; set; }

    [ProtoMember(4)]
    public int staminaWhenUpdated { get; set; }

    [ProtoMember(5)]
    public DateTime? staminaUpdatedAt { get; set; }

    [ProtoMember(6)]
    public int formationNumber { get; set; }

    [ProtoMember(23)]
    public int? currentAreaType { get; set; }

    [ProtoMember(8)]
    public int? currentAreaKeyId { get; set; }

    [ProtoMember(19)]
    public PositionCoordinates currentPositionCoordinates { get; set; }

    [ProtoMember(9)]
    public int? currentDirection { get; set; }

    [ProtoMember(10)]
    public int staminaPurchasedCount { get; set; }

    [ProtoMember(11)]
    public int? birthYear { get; set; }

    [ProtoMember(12)]
    public int? birthMonth { get; set; }

    [ProtoMember(13)]
    public DateTime? loggedInAt { get; set; }

    [ProtoMember(14)]
    public int? trackingWarpPointId { get; set; }

    [ProtoMember(15)]
    public int? trackingFieldBossId { get; set; }

    [ProtoMember(16)]
    public int? trackingDungeonId { get; set; }

    [ProtoMember(17)]
    public DateTime? enemyForcedRespawnAt { get; set; }

    [ProtoMember(18)]
    public int flowerMark { get; set; }

    [ProtoMember(20)]
    public int? dishId { get; set; }

    [ProtoMember(21)]
    public DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(24)]
    public int? dishEffectBaseGearEntityId { get; set; }

    [ProtoMember(25)]
    public int? dishEffectCount { get; set; }

    [ProtoMember(22)]
    public int costumeToken { get; set; }

}