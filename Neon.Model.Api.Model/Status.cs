
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Status {
    [ProtoMember(1)]
    public required int exp { get; set; }

    [ProtoMember(2)]
    public required int rank { get; set; }

    [ProtoMember(3)]
    public required int gold { get; set; }

    [ProtoMember(4)]
    public required int staminaWhenUpdated { get; set; }

    [ProtoMember(5)]
    public required DateTime? staminaUpdatedAt { get; set; }

    [ProtoMember(6)]
    public required int formationNumber { get; set; }

    [ProtoMember(23)]
    public required int? currentAreaType { get; set; }

    [ProtoMember(8)]
    public required int? currentAreaKeyId { get; set; }

    [ProtoMember(19)]
    public required PositionCoordinates currentPositionCoordinates { get; set; }

    [ProtoMember(9)]
    public required int? currentDirection { get; set; }

    [ProtoMember(10)]
    public required int staminaPurchasedCount { get; set; }

    [ProtoMember(11)]
    public required int? birthYear { get; set; }

    [ProtoMember(12)]
    public required int? birthMonth { get; set; }

    [ProtoMember(13)]
    public required DateTime? loggedInAt { get; set; }

    [ProtoMember(14)]
    public required int? trackingWarpPointId { get; set; }

    [ProtoMember(15)]
    public required int? trackingFieldBossId { get; set; }

    [ProtoMember(16)]
    public required int? trackingDungeonId { get; set; }

    [ProtoMember(17)]
    public required DateTime? enemyForcedRespawnAt { get; set; }

    [ProtoMember(18)]
    public required int flowerMark { get; set; }

    [ProtoMember(20)]
    public required int? dishId { get; set; }

    [ProtoMember(21)]
    public required DateTime? dishEffectExpiredAt { get; set; }

    [ProtoMember(24)]
    public required int? dishEffectBaseGearEntityId { get; set; }

    [ProtoMember(25)]
    public required int? dishEffectCount { get; set; }

    [ProtoMember(22)]
    public required int costumeToken { get; set; }

}