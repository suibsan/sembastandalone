
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MagicOrb {
    [ProtoMember(1)]
    public int magicOrbId { get; set; }

}