
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseArea {
    [ProtoMember(1)]
    public required int fractalViseAreaId { get; set; }

    [ProtoMember(2)]
    public required FractalViseAreaEnemy[] enemies { get; set; }

    [ProtoMember(3)]
    public required FractalViseAreaItem[] items { get; set; }

    [ProtoMember(4)]
    public required FractalViseAreaScoreAreaItem[] scoreAreaItems { get; set; }

}