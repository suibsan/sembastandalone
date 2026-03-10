
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Follow {
    [ProtoMember(1)]
    public required long followUserId { get; set; }

    [ProtoMember(2)]
    public required DateTime? followedAt { get; set; }

}