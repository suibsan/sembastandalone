
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class EventFloorNode {
    [ProtoMember(1)]
    public required int eventFloorNodeId { get; set; }

    [ProtoMember(2)]
    public required int[] clearedAchievementIds { get; set; }

    [ProtoMember(3)]
    public required DateTime? allAchievementClearedAt { get; set; }

    [ProtoMember(4)]
    public required DateTime? unlockedAt { get; set; }

}