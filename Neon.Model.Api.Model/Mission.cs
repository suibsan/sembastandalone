
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Mission {
    [ProtoMember(1)]
    public required int missionId { get; set; }

    [ProtoMember(2)]
    public required int count { get; set; }

    [ProtoMember(3)]
    public required int receivedStepCount { get; set; }

    [ProtoMember(4)]
    public required DateTime? resetAt { get; set; }

    [ProtoMember(5)]
    public required DateTime? clearedAt { get; set; }

}