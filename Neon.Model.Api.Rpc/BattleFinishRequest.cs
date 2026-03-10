
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleFinishRequest {
    [ProtoMember(1)]
    public BattleResult battleResult { get; set; }

    [ProtoMember(2)]
    public CharacterUpdate[] characterUpdates { get; set; }

    [ProtoMember(3)]
    public BattleTaskTopic[] battleTaskTopics { get; set; }

    [ProtoMember(4)]
    public int[] encounteredEnemyIds { get; set; }

    [ProtoMember(5)]
    public int battleTimeSecond { get; set; }

    [ProtoMember(7)]
    public BattleTaskConditionResult taskConditionResult { get; set; }

}