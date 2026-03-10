
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBattleStartRequest {
    [ProtoMember(1)]
    public required int fractalViseAreaId { get; set; }

    [ProtoMember(2)]
    public required int[] entityIds { get; set; }

    [ProtoMember(3)]
    public required int[] lineCharacterIds { get; set; }

    [ProtoMember(4)]
    public required BattleAdvantageType advantageType { get; set; }

    [ProtoMember(5)]
    public required bool isAttackHit { get; set; }

    [ProtoMember(6)]
    public required CurrentLocation currentLocation { get; set; }

    [ProtoMember(7)]
    public required BloodStainLocation bloodStainLocation { get; set; }

}