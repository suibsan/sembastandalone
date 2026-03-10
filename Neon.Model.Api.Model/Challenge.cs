
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class Challenge {
    [ProtoMember(1)]
    public int challengeId { get; set; }

    [ProtoMember(2)]
    public int state { get; set; }

    [ProtoMember(3)]
    public DateTime? clearedAt { get; set; }

    [ProtoMember(4)]
    public DateTime? expiresAt { get; set; }

}