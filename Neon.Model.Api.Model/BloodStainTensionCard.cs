
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class BloodStainTensionCard {
    [ProtoMember(1)]
    public required int tensionCardId { get; set; }

    [ProtoMember(2)]
    public required int exp { get; set; }

    [ProtoMember(3)]
    public required int limitBreak { get; set; }

}