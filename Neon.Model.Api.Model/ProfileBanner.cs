
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ProfileBanner {
    [ProtoMember(1)]
    public required int profileBannerId { get; set; }

    [ProtoMember(2)]
    public required DateTime? receivedAt { get; set; }

}