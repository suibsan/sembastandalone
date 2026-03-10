
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class TrialBattleStartRequest {
    [ProtoMember(1)]
    public int trialCharacterEventId { get; set; }

    [ProtoMember(2)]
    public int trialBattleId { get; set; }

}