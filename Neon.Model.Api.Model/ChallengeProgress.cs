
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ChallengeProgress {
    [ProtoMember(1)]
    public int challengeProgressId { get; set; }

    [ProtoMember(5)]
    public int state { get; set; }

    [ProtoMember(3)]
    public DateTime? clearedAt { get; set; }

}