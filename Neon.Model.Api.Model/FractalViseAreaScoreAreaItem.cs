
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FractalViseAreaScoreAreaItem {
    [ProtoMember(1)]
    public int entityId { get; set; }

    [ProtoMember(2)]
    public int index { get; set; }

    [ProtoMember(3)]
    public int fractalViseScoreAreaItemId { get; set; }

    [ProtoMember(4)]
    public DateTime? acquiredAt { get; set; }

}