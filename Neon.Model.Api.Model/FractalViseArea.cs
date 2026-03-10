
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseArea {
    [ProtoMember(1)]
    public int fractalViseAreaId { get; set; }

    [ProtoMember(2)]
    public FractalViseAreaEnemy[] enemies { get; set; }

    [ProtoMember(3)]
    public FractalViseAreaItem[] items { get; set; }

    [ProtoMember(4)]
    public FractalViseAreaScoreAreaItem[] scoreAreaItems { get; set; }

}