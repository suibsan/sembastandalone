
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseAreaScoreAreaItem {
    [ProtoMember(1)]
    public required int entityId { get; set; }

    [ProtoMember(2)]
    public required int index { get; set; }

    [ProtoMember(3)]
    public required int fractalViseScoreAreaItemId { get; set; }

    [ProtoMember(4)]
    public required DateTime? acquiredAt { get; set; }

}