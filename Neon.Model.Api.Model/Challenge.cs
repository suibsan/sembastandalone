
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Challenge {
    [ProtoMember(1)]
    public required int challengeId { get; set; }

    [ProtoMember(2)]
    public required int state { get; set; }

    [ProtoMember(3)]
    public required DateTime? clearedAt { get; set; }

    [ProtoMember(4)]
    public required DateTime? expiresAt { get; set; }

}