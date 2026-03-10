
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class ChallengeProgress {
    [ProtoMember(1)]
    public required int challengeProgressId { get; set; }

    [ProtoMember(5)]
    public required int state { get; set; }

    [ProtoMember(3)]
    public required DateTime? clearedAt { get; set; }

}