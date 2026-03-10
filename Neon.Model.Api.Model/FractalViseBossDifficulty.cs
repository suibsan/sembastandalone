
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseBossDifficulty {
    [ProtoMember(1)]
    public required int fractalViseBossDifficultyId { get; set; }

    [ProtoMember(2)]
    public required int defeatCount { get; set; }

}