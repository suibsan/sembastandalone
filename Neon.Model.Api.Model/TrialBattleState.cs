
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TrialBattleState {
    [ProtoMember(1)]
    public int trialBattleId { get; set; }

    [ProtoMember(2)]
    public DateTime? rewardReceivedAt { get; set; }

}