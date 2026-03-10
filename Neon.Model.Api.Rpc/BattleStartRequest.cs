
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BattleStartRequest {
    [ProtoMember(1)]
    public int[] battleEntryIds { get; set; }

    [ProtoMember(2)]
    public int[] lineCharacterIds { get; set; }

    [ProtoMember(3)]
    public BattleTrigger[] battleTriggers { get; set; }

    [ProtoMember(4)]
    public BattleAdvantageType advantageType { get; set; }

    [ProtoMember(5)]
    public bool isAttackHit { get; set; }

    [ProtoMember(6)]
    public CurrentLocation currentLocation { get; set; }

    [ProtoMember(7)]
    public BloodStainLocation bloodStainLocation { get; set; }

}