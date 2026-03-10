
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalVise {
    [ProtoMember(1)]
    public required int fractalViseId { get; set; }

    [ProtoMember(2)]
    public required int fractalViseScore { get; set; }

    [ProtoMember(5)]
    public required DateTime? specialTreasureBoxAcquiredAt { get; set; }

    [ProtoMember(3)]
    public required bool inProgress { get; set; }

    [ProtoMember(4)]
    public required int currentScore { get; set; }

    [ProtoMember(6)]
    public required int[] selectedAreaIds { get; set; }

}