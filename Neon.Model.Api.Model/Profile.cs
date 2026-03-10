
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Profile {
    [ProtoMember(1)]
    public required string name { get; set; }

    [ProtoMember(2)]
    public required int profileBannerId { get; set; }

    [ProtoMember(3)]
    public required int[] profileBadgeIds { get; set; }

    [ProtoMember(7)]
    public required int characterLikabilityScale { get; set; }

}