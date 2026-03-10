
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonDifficultyPiece {
    [ProtoMember(1)]
    public required int dungeonPieceId { get; set; }

    [ProtoMember(2)]
    public required int x { get; set; }

    [ProtoMember(3)]
    public required int y { get; set; }

    [ProtoMember(4)]
    public required int rotate { get; set; }

}