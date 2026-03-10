
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class FollowUser {
    [ProtoMember(1)]
    public required long userId { get; set; }

    [ProtoMember(2)]
    public required DateTime? followedAt { get; set; }

    [ProtoMember(3)]
    public required int flowerMark { get; set; }

    [ProtoMember(4)]
    public required DateTime? loggedInAt { get; set; }

    [ProtoMember(5)]
    public required int? cityId { get; set; }

    [ProtoMember(6)]
    public required Profile profile { get; set; }

    [ProtoMember(7)]
    public required Formation formation { get; set; }

    [ProtoMember(8)]
    public required FollowUserCharacter[] characters { get; set; }

    [ProtoMember(9)]
    public required FollowUserTensionCard[] tensionCards { get; set; }

    [ProtoMember(10)]
    public required bool isXbPvpFormationInitialized { get; set; }

    [ProtoMember(11)]
    public required int[] profileBadgeIds { get; set; }

}