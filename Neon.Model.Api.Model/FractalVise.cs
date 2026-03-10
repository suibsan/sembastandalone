
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalVise {
    [ProtoMember(1)]
    public int fractalViseId { get; set; }

    [ProtoMember(2)]
    public int fractalViseScore { get; set; }

    [ProtoMember(5)]
    public DateTime? specialTreasureBoxAcquiredAt { get; set; }

    [ProtoMember(3)]
    public bool inProgress { get; set; }

    [ProtoMember(4)]
    public int currentScore { get; set; }

    [ProtoMember(6)]
    public int[] selectedAreaIds { get; set; }

}