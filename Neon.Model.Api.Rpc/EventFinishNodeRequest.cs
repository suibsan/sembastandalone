
namespace Neon.Model.Api.Rpc;

using ProtoBuf;

using Neon.Model.Api.Model;
using Neon.Model.Api.Enum;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class EventFinishNodeRequest {
    [ProtoMember(1)]
    public int eventFloorNodeId { get; set; }

    [ProtoMember(3)]
    public int[] clearedAchievementIds { get; set; }

    [ProtoMember(4)]
    public bool isConsumeItem { get; set; }

    [ProtoMember(5)]
    public EventFloorNodeQuestResult result { get; set; }

    [ProtoMember(6)]
    public QuestResult questResult { get; set; }

}