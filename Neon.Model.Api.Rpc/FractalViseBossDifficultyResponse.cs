
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBossDifficultyResponse {
    [ProtoMember(1)]
    public required FractalViseBossDifficulty[] fractalViseBossDifficulties { get; set; }

    [ProtoMember(3)]
    public required bool difficultyReleased { get; set; }

    [ProtoMember(2)]
    public required Resources changedResources { get; set; }

}