
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Profile {
    [ProtoMember(1)]
    public string name { get; set; }

    [ProtoMember(2)]
    public int profileBannerId { get; set; }

    [ProtoMember(3)]
    public int[] profileBadgeIds { get; set; }

    [ProtoMember(7)]
    public int characterLikabilityScale { get; set; }

}