
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Tip {
    [ProtoMember(1)]
    public int tipId { get; set; }

    [ProtoMember(2)]
    public DateTime? releasedAt { get; set; }

}