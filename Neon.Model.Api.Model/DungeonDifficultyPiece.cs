
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonDifficultyPiece {
    [ProtoMember(1)]
    public int dungeonPieceId { get; set; }

    [ProtoMember(2)]
    public int x { get; set; }

    [ProtoMember(3)]
    public int y { get; set; }

    [ProtoMember(4)]
    public int rotate { get; set; }

}