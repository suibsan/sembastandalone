
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonEnemy {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int dungeonEnemyRateId { get; set; }

    [ProtoMember(3)]
    public bool isBoss { get; set; }

    [ProtoMember(5)]
    public int dungeonPieceId { get; set; }

    [ProtoMember(6)]
    public int dungeonPieceX { get; set; }

    [ProtoMember(7)]
    public int dungeonPieceY { get; set; }

    [ProtoMember(8)]
    public int dungeonPieceIndex { get; set; }

    [ProtoMember(9)]
    public DateTime? defeatedAt { get; set; }

}