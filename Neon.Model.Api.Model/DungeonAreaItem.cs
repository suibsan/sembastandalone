
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonAreaItem {
    [ProtoMember(1)]
    public required int entityId { get; set; }

    [ProtoMember(2)]
    public required int dungeonAreaItemId { get; set; }

    [ProtoMember(3)]
    public required int dungeonPieceId { get; set; }

    [ProtoMember(4)]
    public required int dungeonPieceX { get; set; }

    [ProtoMember(5)]
    public required int dungeonPieceY { get; set; }

    [ProtoMember(6)]
    public required int dungeonPieceIndex { get; set; }

    [ProtoMember(7)]
    public required DateTime? acquiredAt { get; set; }

}