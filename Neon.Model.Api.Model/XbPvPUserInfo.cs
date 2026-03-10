
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvPUserInfo {
    [ProtoMember(1)]
    public required string name { get; set; }

    [ProtoMember(2)]
    public required long userId { get; set; }

    [ProtoMember(3)]
    public required int profileBannerId { get; set; }

    [ProtoMember(4)]
    public required int[] profileBadgeIds { get; set; }

    [ProtoMember(5)]
    public required FollowUserCharacter[] characters { get; set; }

    [ProtoMember(6)]
    public required int flowerMark { get; set; }

    [ProtoMember(7)]
    public required bool isCpuUser { get; set; }

    [ProtoMember(8)]
    public required int? rankMatchRank { get; set; }

}