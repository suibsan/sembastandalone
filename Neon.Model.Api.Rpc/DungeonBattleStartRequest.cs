
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class DungeonBattleStartRequest {
    [ProtoMember(1)]
    public int dungeonDifficultyId { get; set; }

    [ProtoMember(2)]
    public int[] entityIds { get; set; }

    [ProtoMember(3)]
    public int[] lineCharacterIds { get; set; }

    [ProtoMember(4)]
    public BattleAdvantageType advantageType { get; set; }

    [ProtoMember(5)]
    public bool isAttackHit { get; set; }

}