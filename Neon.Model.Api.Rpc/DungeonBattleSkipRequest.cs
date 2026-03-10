
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonBattleSkipRequest {
    [ProtoMember(1)]
    public int dungeonDifficultyId { get; set; }

    [ProtoMember(2)]
    public int entityId { get; set; }

    [ProtoMember(3)]
    public int[] lineCharacterIds { get; set; }

}