
namespace Neon.Model.Api.Model;

using ProtoBuf;

using Neon.Model.Api.Model;

[ProtoContract, CompatibilityLevel(CompatibilityLevel.Level300)]
public class NineSequence {
    [ProtoMember(1)]
    public required int nineSequenceId { get; set; }

    [ProtoMember(2)]
    public required string choices { get; set; }

    [ProtoMember(3)]
    public required DateTime? expiresAt { get; set; }

    [ProtoMember(4)]
    public required DateTime? lastReceiveAt { get; set; }

    [ProtoMember(5)]
    public required DateTime? lastReadAt { get; set; }

}