
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleFinishRequest {
    [ProtoMember(1)]
    public required BattleResult battleResult { get; set; }

    [ProtoMember(2)]
    public required CharacterUpdate[] characterUpdates { get; set; }

    [ProtoMember(3)]
    public required BattleTaskTopic[] battleTaskTopics { get; set; }

    [ProtoMember(4)]
    public required int[] encounteredEnemyIds { get; set; }

    [ProtoMember(5)]
    public required int battleTimeSecond { get; set; }

    [ProtoMember(7)]
    public required BattleTaskConditionResult taskConditionResult { get; set; }

}