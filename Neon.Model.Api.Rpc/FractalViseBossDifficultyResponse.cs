
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBossDifficultyResponse {
    [ProtoMember(1)]
    public FractalViseBossDifficulty[] fractalViseBossDifficulties { get; set; }

    [ProtoMember(3)]
    public bool difficultyReleased { get; set; }

    [ProtoMember(2)]
    public Resources changedResources { get; set; }

}