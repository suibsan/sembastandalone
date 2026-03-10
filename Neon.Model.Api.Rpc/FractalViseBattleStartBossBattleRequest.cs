
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBattleStartBossBattleRequest {
    [ProtoMember(1)]
    public int fractalViseId { get; set; }

    [ProtoMember(2)]
    public int fractalViseBossDifficultyId { get; set; }

    [ProtoMember(3)]
    public int[] lineCharacterIds { get; set; }

    [ProtoMember(4)]
    public CurrentLocation currentLocation { get; set; }

    [ProtoMember(5)]
    public BloodStainLocation bloodStainLocation { get; set; }

}