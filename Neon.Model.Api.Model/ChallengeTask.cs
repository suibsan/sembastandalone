
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ChallengeTask {
    [ProtoMember(1)]
    public int challengeTaskId { get; set; }

    [ProtoMember(4)]
    public int count { get; set; }

    [ProtoMember(3)]
    public DateTime? clearedAt { get; set; }

}