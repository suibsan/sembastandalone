
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleTaskConditionResult {
    [ProtoMember(1)]
    public CharacterSkillCount[] usedSkills { get; set; }

    [ProtoMember(2)]
    public EnemyStabilityBreakCount[] enemyStabilityBreaks { get; set; }

}