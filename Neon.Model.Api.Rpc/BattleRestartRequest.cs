
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleRestartRequest {
    [ProtoMember(1)]
    public int[] lineCharacterIds { get; set; }

    [ProtoMember(2)]
    public int[] encounteredEnemyIds { get; set; }

    [ProtoMember(3)]
    public bool isDifficultyDecrease { get; set; }

}