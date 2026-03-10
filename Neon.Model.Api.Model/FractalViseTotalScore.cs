
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseTotalScore {
    [ProtoMember(1)]
    public required int totalScore { get; set; }

    [ProtoMember(2)]
    public required int receivedStepCount { get; set; }

}