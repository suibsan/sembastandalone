
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class XbPvPUserInfo {
    [ProtoMember(1)]
    public string name { get; set; }

    [ProtoMember(2)]
    public long userId { get; set; }

    [ProtoMember(3)]
    public int profileBannerId { get; set; }

    [ProtoMember(4)]
    public int[] profileBadgeIds { get; set; }

    [ProtoMember(5)]
    public FollowUserCharacter[] characters { get; set; }

    [ProtoMember(6)]
    public int flowerMark { get; set; }

    [ProtoMember(7)]
    public bool isCpuUser { get; set; }

    [ProtoMember(8)]
    public int? rankMatchRank { get; set; }

}