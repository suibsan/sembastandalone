
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class MissionCountRewardState {
    [ProtoMember(1)]
    public int missionCountRewardId { get; set; }

    [ProtoMember(2)]
    public int receivedStepCount { get; set; }

    [ProtoMember(3)]
    public DateTime? resetAt { get; set; }

}