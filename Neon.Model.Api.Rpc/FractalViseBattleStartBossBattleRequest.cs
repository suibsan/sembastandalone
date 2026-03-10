
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBattleStartBossBattleRequest {
    [ProtoMember(1)]
    public required int fractalViseId { get; set; }

    [ProtoMember(2)]
    public required int fractalViseBossDifficultyId { get; set; }

    [ProtoMember(3)]
    public required int[] lineCharacterIds { get; set; }

    [ProtoMember(4)]
    public required CurrentLocation currentLocation { get; set; }

    [ProtoMember(5)]
    public required BloodStainLocation bloodStainLocation { get; set; }

}