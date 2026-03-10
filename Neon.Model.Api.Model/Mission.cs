
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Mission {
    [ProtoMember(1)]
    public int missionId { get; set; }

    [ProtoMember(2)]
    public int count { get; set; }

    [ProtoMember(3)]
    public int receivedStepCount { get; set; }

    [ProtoMember(4)]
    public DateTime? resetAt { get; set; }

    [ProtoMember(5)]
    public DateTime? clearedAt { get; set; }

}